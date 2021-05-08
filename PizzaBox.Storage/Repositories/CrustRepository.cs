using System;
using System.Collections.Generic;
using System.Linq;
using PizzaBox.Domain.Interfaces;
using PizzaBox.Domain.Models;

namespace PizzaBox.Storage.Repositories
{
  public class CrustRepository : IRepository<Crust>
  {
    private readonly PizzaBoxContext _context;
    public CrustRepository(PizzaBoxContext context)
    {
      _context = context;
    }
    public IEnumerable<Crust> Select(Func<Crust, bool> filter)
    {
      return _context.Crusts.Where(filter);
    }

    public Crust Update()
    {
      throw new System.NotImplementedException();
    }

    public bool Delete()
    {
      throw new System.NotImplementedException();
    }

    public void Insert(Crust entry)
    {
      throw new NotImplementedException();
    }
  }
}