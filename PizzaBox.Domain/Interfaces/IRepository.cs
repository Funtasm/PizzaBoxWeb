using System.Collections.Generic;

namespace PizzaBox.Domain.Interfaces
{
  public interface IRepository
  {
    List<T> Select<T>();
    bool Insert();
    T Update<T>();
    bool Delete();
  }
}