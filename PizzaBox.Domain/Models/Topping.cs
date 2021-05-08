using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;
namespace PizzaBox.Domain.Models
{
  public class Topping : AComponent
  {
    public ICollection<Pizza> Pizzas { get; set; }
  }
}