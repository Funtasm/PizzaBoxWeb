using PizzaBox.Storage.Repositories;

namespace PizzaBox.Storage
{
  public class UnitOfWork
  {
<<<<<<< HEAD
    public readonly PizzaBoxContext context;
=======
>>>>>>> parent of c4f2f25... WorkingPostGres
    public CrustRepository Crusts { get; }
    public SizeRepository Sizes { get; }
    public ToppingsRepository Toppings { get; }
    public OrderRepository Orders { get; }
    public Repository Repo { get; }
    public UnitOfWork(PizzaBoxContext Thecontext)
    {
<<<<<<< HEAD
      context = Thecontext;
      Repo = new Repository();
    }

    public void Save()
    {
      context.SaveChanges();
=======
      Crusts = new CrustRepository();
      Sizes = new SizeRepository();
      Toppings = new ToppingsRepository();
>>>>>>> parent of c4f2f25... WorkingPostGres
    }
  }
}