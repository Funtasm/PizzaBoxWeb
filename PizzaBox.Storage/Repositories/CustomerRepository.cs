using System;
using System.Collections.Generic;
using PizzaBox.Domain.Interfaces;
using PizzaBox.Domain.Models;

namespace PizzaBox.Storage.Repositories
{
<<<<<<< HEAD
  public class CustomerRepository : IRepository<Customer>
=======
  public class CustomerRepository : IRepository
>>>>>>> parent of c4f2f25... WorkingPostGres
  {
    public bool Delete()
    {
      throw new NotImplementedException();
    }

    public void Insert(Customer entry)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<Customer> Select(Func<Customer, bool> filter)
    {
      throw new NotImplementedException();
    }

    public Customer Update()
    {
      throw new NotImplementedException();
    }
  }
}