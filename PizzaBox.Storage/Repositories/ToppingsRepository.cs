using System;
using System.Collections.Generic;
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

    public bool Insert()
    {
      throw new System.NotImplementedException();
    }

    public IEnumerable<Topping> Select(Func<Topping, bool> filter)
    {
      throw new System.NotImplementedException();
    }

    public Topping Update()
    {
      throw new System.NotImplementedException();
    }
  }
}