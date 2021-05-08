using System.Collections.Generic;
using PizzaBox.Domain.Interfaces;
using PizzaBox.Domain.Models;

namespace PizzaBox.Storage.Repositories
{
  public class OrderRepository : IRepository
  {
    public IEnumerable<Order> Select()
    {

    }

<<<<<<< HEAD
    public void Insert(Order entry)
    {
      _context.Orders.Add(entry);
    }
=======
    public void Update()
    {
>>>>>>> parent of c4f2f25... WorkingPostGres

    }
    public Order Insert()
    {

    }
    public void Delete()
    {

    }
  }
}