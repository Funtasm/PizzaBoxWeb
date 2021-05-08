using Microsoft.AspNetCore.Mvc;
using PizzaBox.Client.Models;
using PizzaBox.Storage;

namespace PizzaBox.Client.Controllers
{

  [Route("")]

  public class HomeController : Controller
  {
    [HttpGet]
    public IActionResult Index()
    {
      return View("HomePage");
    }
  }
}