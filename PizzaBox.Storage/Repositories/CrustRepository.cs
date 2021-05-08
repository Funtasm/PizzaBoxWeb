using System.Collections.Generic;
using PizzaBox.Domain.Interfaces;
using PizzaBox.Domain.Models;

namespace PizzaBox.Storage.Repositories
{
  public class CrustRepository : IRepository
  {
    public IEnumerable<Crust> Select()
    {

<<<<<<< HEAD
    public Crust Update()
    {
      throw new System.NotImplementedException();
    }

    public bool Delete()
=======
    }

    public void Update()
>>>>>>> parent of c4f2f25... WorkingPostGres
    {

    }
    public Crust Insert()
    {

<<<<<<< HEAD
    public void Insert(Crust entry)
    {
      throw new NotImplementedException();
=======
    }
    public void Delete()
    {

>>>>>>> parent of c4f2f25... WorkingPostGres
    }
  }
}