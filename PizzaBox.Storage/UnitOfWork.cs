using PizzaBox.Storage.Repositories;

namespace PizzaBox.Storage
{
  public class UnitOfWork
  {
    private readonly PizzaBoxContext _context;
    public CrustRepository Crusts { get; }
    public SizeRepository Sizes { get; }
    public ToppingsRepository Toppings { get; }
    public UnitOfWork()
    {
      Crusts = new CrustRepository(_context);
      Sizes = new SizeRepository(_context);
      Toppings = new ToppingsRepository(_context);
    }

    public void Save()
    {
      _context.SaveChanges();
    }
  }
}