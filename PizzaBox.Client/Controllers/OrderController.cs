using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using PizzaBox.Client.Models;
using PizzaBox.Domain.Models;
using PizzaBox.Storage;

namespace PizzaBox.Client.Controllers
{
  [Route("[controller]")]
  [Route("[controller]/[Action]")]
  public class OrderController : Controller
  {
    private readonly UnitOfWork _unitOfWork;
    public OrderController(UnitOfWork unitOfWork)
    {
      _unitOfWork = unitOfWork;
    }
    [HttpGet]
    [HttpPost]
    [Route("/Order")]
    public IActionResult Menu()
    {
      var order = new OrderViewModel();
      order.Load(_unitOfWork);
      return View("order", order);
    }
    [Route("/order/newpizza")]
    [ValidateAntiForgeryToken]
    public IActionResult NewPizza(OrderViewModel order)
    {
      if (ModelState.IsValid)
      {

        var crust = _unitOfWork.Repo.Select<Crust>(_unitOfWork.context.Crusts, a => a.Name == order.SelectedCrust).FirstOrDefault();
        var size = _unitOfWork.Repo.Select<Size>(_unitOfWork.context.Sizes, a => a.Name == order.SelectedSize).FirstOrDefault();
        var toppings = new List<Topping>();
        foreach (var item in order.SelectedToppings)
        {
          toppings.Add(_unitOfWork.Repo.Select<Topping>(_unitOfWork.context.Toppings, a => a.Name == item).First());
        }
        var newPizza = new Pizza { Crust = crust, Size = size, Toppings = toppings };
        if (TempData["username"] != null)
        {
          var customer = _unitOfWork.Repo.Select<Customer>(_unitOfWork.context.Customers, a => a.UserName == TempData["username"].ToString()).FirstOrDefault();
          var store = _unitOfWork.Repo.Select<Store>(_unitOfWork.context.Stores, a => a.Address == order.SelectedStore).FirstOrDefault();
          TempData.Keep();
          var CheckOrder = _unitOfWork.OrderRepo.Select(a => a.Customer.UserName == TempData["username"].ToString())
          .LastOrDefault();
          if (CheckOrder == null || CheckOrder.Done)
          {
            var newOrder = new Order { Pizzas = new List<Pizza> { newPizza }, Customer = customer, Store = store, Done = false };
            _unitOfWork.Repo.Insert<Order>(_unitOfWork.context.Orders, newOrder);
            _unitOfWork.Save();
            order.Load(newOrder.Pizzas);
            return View("Cart", order);
          }
          else if (!CheckOrder.Done)
          {
            CheckOrder.Pizzas.Add(newPizza);
            _unitOfWork.Repo.Update<Order>(_unitOfWork.context.Orders, CheckOrder);
            _unitOfWork.Save();
            order.Load(CheckOrder.Pizzas);
            return View("Cart", order);
          }
        }
        else
        {
          return View("Login");
        }

      }
      //shouldnt ever be reached
      order.Load(_unitOfWork);
      return View("order", order);
    }
    [Route("/Order/Checkout")]
    public IActionResult Checkout(OrderViewModel order)
    {
      var CheckOrder = _unitOfWork.OrderRepo.Select(a => a.Customer.UserName == TempData["username"].ToString()).LastOrDefault();
      if (CheckOrder != null && !CheckOrder.Done)
      {
        CheckOrder.Done = true;
        _unitOfWork.Repo.Update<Order>(_unitOfWork.context.Orders, CheckOrder);
        _unitOfWork.Save();
        order.Load(CheckOrder.Pizzas);
        return View("checkout", order);
      }


      return View("Error", new ErrorViewModel() { RequestId = "Checkout" });
    }
    [Route("/Order/Cart")]
    [ValidateAntiForgeryToken]
    public IActionResult Cart(OrderViewModel order)
    {
      //order.Load(CustomerPizzas);
      order.Load(_unitOfWork);
      return View("checkout", order);
    }
  }
}