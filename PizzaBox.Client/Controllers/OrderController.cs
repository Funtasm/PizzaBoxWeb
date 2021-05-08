using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using PizzaBox.Client.Models;
<<<<<<< HEAD
using PizzaBox.Domain.Models;
using PizzaBox.Storage;
=======
>>>>>>> parent of c4f2f25... WorkingPostGres

namespace PizzaBox.Client.Controllers
{
  [Route("[controller]")]
  public class OrderController : Controller
  {
    [HttpGet]
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(OrderViewModel order)
    {
      if (ModelState.IsValid)
<<<<<<< HEAD
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
=======
        return View("checkout", order);
      else
        return View("index", order);
>>>>>>> parent of c4f2f25... WorkingPostGres
    }
  }
}