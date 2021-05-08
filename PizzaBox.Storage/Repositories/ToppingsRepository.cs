using System;
using System.Collections.Generic;
using System.Linq;
using PizzaBox.Domain.Interfaces;
using PizzaBox.Domain.Models;

namespace PizzaBox.Storage.Repositories
{
  public class ToppingsRepository : IRepository<Topping>
  {
    private readonly PizzaBoxContext _context;
    public ToppingsRepository(PizzaBoxContext context)
    {
      _context = context;
    }
    public bool Delete()
    {
      throw new System.NotImplementedException();
    }

    public void Insert(Topping entry)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<Topping> Select(Func<Topping, bool> filter)
    {
      return _context.Toppings.Where(filter);
    }

    public Topping Update()
    {
      throw new System.NotImplementedException();
    }
  }
}