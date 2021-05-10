using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;
namespace PizzaBox.Domain.Models
{
  public class Customer : Entity
  {
    public string UserName { set; get; }
    public string FirstName { set; get; }
    public string LastName { set; get; }
    public List<Order> Orders { set; get; }
    public string Password { set; get; }

  }
}