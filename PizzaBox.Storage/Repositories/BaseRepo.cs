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
    public void Insert<T>(DbSet<T> Database, T entry) where T : class
    {
      Database.Add(entry);
    }
    public void Update<T>(DbSet<T> Database, T entry) where T : class
    {
      Database.Update(entry);
    }
    public bool Delete()
    {
      throw new System.NotImplementedException();
    }
  }
}