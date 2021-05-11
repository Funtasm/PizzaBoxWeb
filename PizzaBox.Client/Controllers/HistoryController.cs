using System.Linq;
using Microsoft.AspNetCore.Mvc;
using PizzaBox.Client.Models;
using PizzaBox.Domain.Models;
using PizzaBox.Storage;

namespace PizzaBox.Client.Controllers
{

  [Route("[controller]")]
  [Route("[controller]/[Action]")]
  public class HistoryController : Controller
  {
    private readonly UnitOfWork _unitOfWork;
    public HistoryController(UnitOfWork unitOfWork)
    {
      _unitOfWork = unitOfWork;
    }
    [Route("/history")]
    public IActionResult History()
    {
      var history = new HistoryViewModel();
      history.LoadStore(_unitOfWork, history.Store);
      return View("History", history);
    }
    [Route("/history/Store")]
    public IActionResult StoreHistory(HistoryViewModel history)
    {
      history.LoadStore(_unitOfWork, history.Store);
      if (history.Orders.Count == 0)
        ModelState.AddModelError("user", "No History Found.");
      if (ModelState.IsValid)
      {

        return View("CustomerHistory", history);
      }
      history.LoadStore(_unitOfWork, history.Store);
      return View("History", history);
    }
    [Route("/history/Customer")]
    public IActionResult CustomerHistory(HistoryViewModel history)
    {
      history.LoadCustomer(_unitOfWork, history.User);
      if (history.Orders.Count == 0)
        ModelState.AddModelError("user", "No History Found.");
      if (ModelState.IsValid)
      {

        return View("CustomerHistory", history);
      }
      history.LoadStore(_unitOfWork, history.Store);
      return View("History", history);
    }
  }
}