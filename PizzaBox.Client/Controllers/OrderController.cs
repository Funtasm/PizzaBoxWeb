using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using PizzaBox.Client.Models;
using PizzaBox.Domain.Models;
using PizzaBox.Storage;

namespace PizzaBox.Client.Controllers
{
  [Route("[controller]")]
  public class OrderController : Controller
  {
    private readonly UnitOfWork _unitOfWork;
    public OrderController(UnitOfWork unitOfWork)
    {
      _unitOfWork = unitOfWork;
    }
    [HttpGet]
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(OrderViewModel order)
    {
      if (ModelState.IsValid)
      {
        var crust = _unitOfWork.Repo.Select<Crust>(_unitOfWork.context.Crusts, a => a.Name == order.SelectedCrust).First();
        var size = _unitOfWork.Repo.Select<Size>(_unitOfWork.context.Sizes, a => a.Name == order.SelectedSize).First();
        var toppings = new List<Topping>();
        foreach (var item in order.SelectedToppings)
        {
          toppings.Add(_unitOfWork.Repo.Select<Topping>(_unitOfWork.context.Toppings, a => a.Name == item).First());
        }
        var newPizza = new Pizza { Crust = crust, Size = size, Toppings = toppings };
        var customer = _unitOfWork.Repo.Select<Customer>(_unitOfWork.context.Customers, a => a.FirstName == "Seth").First();
        var store = _unitOfWork.Repo.Select<Store>(_unitOfWork.context.Stores, a => a.EntityID == 1).First();
        var newOrder = new Order { Pizzas = new List<Pizza> { newPizza }, Customer = customer, Store = store };


        _unitOfWork.Repo.Insert<Order>(_unitOfWork.context.Orders, newOrder);
        _unitOfWork.Save();

        ViewBag.Order = newOrder;
        return View("checkout", order);
      }
      order.Load(_unitOfWork);
      return View("index", order);
    }
  }
}