using PizzaBox.Storage.Repositories;

namespace PizzaBox.Storage
{
  public class UnitOfWork
  {
    public readonly PizzaBoxContext context;
    public Repository Repo { get; }
    public UnitOfWork(PizzaBoxContext Thecontext)
    {
      context = Thecontext;
      Repo = new Repository();
    }

    public void Save()
    {
      context.SaveChanges();
    }
  }
}