using System;
using System.Collections.Generic;
using System.Linq;
using PizzaBox.Domain.Interfaces;
using PizzaBox.Domain.Models;
using Microsoft.EntityFrameworkCore;


namespace PizzaBox.Storage.Repositories
{
  public class OrderRepository : Repository
  {
    private readonly PizzaBoxContext _context;
    public OrderRepository(PizzaBoxContext context)
    {
      _context = context;
    }

    public void Insert(Order entry)
    {
      _context.Orders.Add(entry);
    }

    public IEnumerable<Order> Select(Func<Order, bool> filter)
    {
      return _context.Orders
      .Include(a => a.Customer)
      .Include(a => a.Store)
      .Include(a => a.Pizzas)
      .ThenInclude(a => a.Toppings)
      .Include(a => a.Pizzas)
      .ThenInclude(a => a.Size)
      .Include(a => a.Pizzas)
      .ThenInclude(a => a.Crust)
      .Where(filter);
    }

    public Order Update()
    {
      throw new System.NotImplementedException();
    }
  }
}