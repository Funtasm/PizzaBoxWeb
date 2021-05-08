using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;
namespace PizzaBox.Domain.Models
{
  public class Size : AComponent
  {
    public ICollection<Pizza> Pizzas { get; set; }
  }
}