using PizzaBox.Storage.Repositories;

namespace PizzaBox.Storage
{
  public class UnitOfWork
  {
    public readonly PizzaBoxContext context;
    public Repository Repo { get; }
    public OrderRepository OrderRepo { get; }
    public UnitOfWork(PizzaBoxContext Thecontext)
    {
      context = Thecontext;
      Repo = new Repository();
      OrderRepo = new OrderRepository(Thecontext);
    }

    public void Save()
    {
      context.SaveChanges();
    }
  }
}