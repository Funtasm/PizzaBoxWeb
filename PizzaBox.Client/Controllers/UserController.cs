using System.ComponentModel.DataAnnotations;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using PizzaBox.Client.Models;
using PizzaBox.Domain.Models;
using PizzaBox.Storage;

namespace PizzaBox.Client.Controllers
{



  public class UserController : Controller
  {
    private readonly UnitOfWork _unitOfWork;
    public UserController(UnitOfWork unitOfWork)
    {
      _unitOfWork = unitOfWork;
    }
    [Route("User/Create")]
    public IActionResult Create()
    {
      var User = new UserViewModel();
      return View("NewUser", User);
    }
    [Route("User/Welcome")]
    [ValidateAntiForgeryToken]
    public IActionResult Welcome(UserViewModel User)
    {
      var TakenUsernames = _unitOfWork.Repo.Select<Customer>(_unitOfWork.context.Customers, c => !string.IsNullOrWhiteSpace(c.UserName)).Select(a => a.UserName).ToList();
      if (TakenUsernames.Contains(User.Username))
      {
        ModelState.AddModelError("Username", "Username is taken!");
      }
      if (ModelState.IsValid)
      {
        var customer = new Customer() { UserName = User.Username, FirstName = User.FirstName, LastName = User.LastName, Password = User.Password };
        _unitOfWork.Repo.Insert<Customer>(_unitOfWork.context.Customers, customer);
        _unitOfWork.Save();
        return View("Welcome", User);

        //view chooses the .cshtml, method name has no bearing.
      }
      return View("NewUser", User);
    }
    [Route("User/Login")]
    public IActionResult Login(ExistingUserViewModel User)
    {

      if (User.Username == null)
      {
        ModelState.Clear();
        return View("Login", User);
      }
      if (ModelState.IsValid)
      {
        var Customer = _unitOfWork.Repo.Select<Customer>(_unitOfWork.context.Customers, a => a.UserName == User.Username).FirstOrDefault();
        if (Customer == null)
        {
          ModelState.AddModelError("username", "Username or password does not match.");
          return View("Login", User);
        }
        else if (Customer.Password != User.Password)
        {
          ModelState.AddModelError("username", "Username or password does not match.");
          return View("Login", User);
        }
        else
        {
          TempData["username"] = User.Username;
          TempData.Keep("username");
          return View("Success");
        }
      }
      return View("Login", User);
    }
  }
}