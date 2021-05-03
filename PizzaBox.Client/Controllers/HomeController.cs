using Microsoft.AspNetCore.Mvc;
using PizzaBox.Client.Models;

namespace PizzaBox.Client.Controllers
{

  [Route("[controller]/[action]")]
  //[Route("[controller]")]
  public class HomeController : Controller
  {
    [HttpGet]
    public IActionResult Index()
    {
      ViewBag.Order = new OrderViewModel();
      //ViewData
      //TempData - does not survive redirects.
      return View("Index");
      //explicitly find Index.cshtml. If not stated, will find based on method name.
    }
  }
}