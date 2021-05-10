using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;
namespace PizzaBox.Domain.Models
{
  public class Store : Entity
  {
    public string Address { set; get; }
    public List<Order> Orders { set; get; }
  }
}