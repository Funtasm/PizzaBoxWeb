using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;
namespace PizzaBox.Domain.Models
{
  public class Customer : Entity
  {
    string UserName { set; get; }
    List<Order> Orders { set; get; }

  }
}