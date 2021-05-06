using Microsoft.AspNetCore.Mvc;
using PizzaBox.Client.Models;
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
        return View("checkout", order);

      order.Load(_unitOfWork);
      return View("index", order);
    }
  }
}