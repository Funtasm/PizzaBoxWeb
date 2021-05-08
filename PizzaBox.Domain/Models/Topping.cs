<<<<<<< HEAD
using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;
=======
>>>>>>> parent of c4f2f25... WorkingPostGres
namespace PizzaBox.Domain.Models
{
  public class Topping
  {
    public ICollection<Pizza> Pizzas { get; set; }
  }
}