using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;
namespace PizzaBox.Domain.Models
{
  public class Order : Entity
  {
    public List<Pizza> Pizzas { set; get; }
    public Customer Customer { set; get; }
    public long CustomerEntityID { set; get; }
    public long StoreEntityID { set; get; }
    public Store Store { set; get; }
    public bool Done { get; set; }
  }
}