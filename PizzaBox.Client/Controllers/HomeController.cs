using Microsoft.AspNetCore.Mvc;

namespace PizzaBox.Client.Controllers
{

  [Route("[controller]/[action]")]
  //[Route("[controller]")]
  public class HomeController : Controller
  {
    [HttpGet]
    public IActionResult Index()
    {
      return View();
    }
  }
}