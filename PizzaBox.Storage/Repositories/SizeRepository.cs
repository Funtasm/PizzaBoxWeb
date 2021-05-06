using System;
using System.Collections.Generic;
using PizzaBox.Domain.Interfaces;
using PizzaBox.Domain.Models;

namespace PizzaBox.Storage.Repositories
{
  public class SizeRepository : IRepository<Size>
  {
    private readonly PizzaBoxContext _context;
    public SizeRepository(PizzaBoxContext context)
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

    public IEnumerable<Size> Select(Func<Size, bool> filter)
    {
      throw new NotImplementedException();
    }

    public Size Update()
    {
      throw new System.NotImplementedException();
    }
  }
}