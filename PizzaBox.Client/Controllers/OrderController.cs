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
        var newOrder = new Order { Pizzas = new List<Pizza> { newPizza } };

        return View("checkout", order);
      }
      order.Load(_unitOfWork);
      return View("index", order);
    }
  }
}