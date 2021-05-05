using PizzaBox.Storage.Repositories;

namespace PizzaBox.Storage
{
  public class UnitOfWork
  {
    public CrustRepository Crusts { get; }
    public SizeRepository Sizes { get; }
    public ToppingsRepository Toppings { get; }
    public UnitOfWork()
    {
      Crusts = new CrustRepository();
      Sizes = new SizeRepository();
      Toppings = new ToppingsRepository();
    }
  }
}