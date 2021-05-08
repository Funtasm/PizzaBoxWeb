using System.Collections.Generic;

namespace PizzaBox.Domain.Interfaces
{
  public interface IRepository
  {
<<<<<<< HEAD
    IEnumerable<T> Select(Func<T, bool> filter);
    void Insert(T entry);
    T Update();
=======
    List<T> Select<T>();
    bool Insert();
    T Update<T>();
>>>>>>> parent of c4f2f25... WorkingPostGres
    bool Delete();
  }
}