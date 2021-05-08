using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace PizzaBox.Storage.Repositories
{
  public class Repository
  {
    public IEnumerable<T> Select<T>(DbSet<T> Database, Func<T, bool> filter) where T : class
    {
      return Database.Where(filter);
    }
    void Insert<T>(T entry)
    {
      throw new System.NotImplementedException();
    }
    T Update<T>()
    {
      throw new System.NotImplementedException();
    }
    bool Delete()
    {
      throw new System.NotImplementedException();
    }
  }
}