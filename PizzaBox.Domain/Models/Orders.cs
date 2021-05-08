<<<<<<< HEAD
using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;
=======
>>>>>>> parent of c4f2f25... WorkingPostGres
namespace PizzaBox.Domain.Models
{
  public class Order
  {
    public List<Pizza> Pizzas { set; get; }
    public Customer Customer { set; get; }
    public long CustomerEntityID { set; get; }
    public long StoreEntityID { set; get; }
    public Store Store { set; get; }
  }
}