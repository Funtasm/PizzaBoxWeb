using Microsoft.AspNetCore.Mvc;
using PizzaBox.Client.Models;
using PizzaBox.Storage;

namespace PizzaBox.Client.Controllers
{

  [Route("")]
  [Route("[controller]/[action]")]

  public class HomeController : Controller
  {
    [HttpGet]
    public IActionResult Index()
    {
      return View("HomePage");
    }
    public IActionResult Meme()
    {
      return View("Privacy");
    }

  }
}