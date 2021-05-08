using PizzaBox.Storage.Repositories;

namespace PizzaBox.Storage
{
  public class UnitOfWork
  {
    public readonly PizzaBoxContext context;
    public CrustRepository Crusts { get; }
    public SizeRepository Sizes { get; }
    public ToppingsRepository Toppings { get; }
    public OrderRepository Orders { get; }
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