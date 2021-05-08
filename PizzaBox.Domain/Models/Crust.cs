using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
  public class Crust : AComponent
  {
    public ICollection<Pizza> Pizzas { get; set; }

  }
}