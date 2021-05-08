using System.Collections.Generic;
using System.Linq;
using PizzaBox.Domain.Interfaces;
using PizzaBox.Domain.Models;

namespace PizzaBox.Storage.Repositories
{
  public class SizeRepository : IRepository
  {
    public IEnumerable<Size> Select()
    {

    }

<<<<<<< HEAD
    public void Insert(Size entry)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<Size> Select(Func<Size, bool> filter)
    {
      return _context.Sizes.Where(filter);
=======
    public void Update()
    {

>>>>>>> parent of c4f2f25... WorkingPostGres
    }
    public Size Insert()
    {

    }
    public void Delete()
    {

    }
  }
}