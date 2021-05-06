using Microsoft.AspNetCore.Mvc;
using PizzaBox.Client.Models;
using PizzaBox.Storage;

namespace PizzaBox.Client.Controllers
{

  [Route("[controller]/[action]")]
  //[Route("[controller]")]
  public class HomeController : Controller
  {
    private readonly UnitOfWork _unitOfWork;
    public HomeController(UnitOfWork unitOfWork)
    {
      _unitOfWork = unitOfWork;
    }
    [HttpGet]
    public IActionResult Index()
    {
      // ViewBag.Order = new OrderViewModel();
      //ViewData
      //TempData - does not survive redirects.
      var order = new OrderViewModel();
      order.Load(_unitOfWork);
      return View("order", order);
      //explicitly find Index.cshtml. If not stated, will find based on method name.
    }
    [HttpGet]
    public IActionResult Privacy()
    {
      //ViewData
      //TempData - does not survive redirects.
      return View("Privacy");
      //explicitly find Privacy.cshtml. If not stated, will find based on method name.
    }
  }
}