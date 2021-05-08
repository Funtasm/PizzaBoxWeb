using System.Collections.Generic;
using System.Linq;
using PizzaBox.Domain.Interfaces;
using PizzaBox.Domain.Models;

namespace PizzaBox.Storage.Repositories
{
  public class ToppingsRepository : IRepository
  {
    public IEnumerable<Topping> Select()
    {

<<<<<<< HEAD
    public void Insert(Topping entry)
    {
      throw new NotImplementedException();
=======
>>>>>>> parent of c4f2f25... WorkingPostGres
    }

    public void Update()
    {
<<<<<<< HEAD
      return _context.Toppings.Where(filter);
=======

>>>>>>> parent of c4f2f25... WorkingPostGres
    }
    public Topping Insert()
    {

    }
    public void Delete()
    {

    }
  }
}