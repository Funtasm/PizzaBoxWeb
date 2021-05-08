using System.Linq;
using Microsoft.EntityFrameworkCore;
using PizzaBox.Domain.Models;

namespace PizzaBox.Storage
{

  public class PizzaBoxContext : DbContext
  {
    public DbSet<Crust> Crusts { get; set; }
    public DbSet<Size> Sizes { get; set; }
    public DbSet<Topping> Toppings { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Pizza> Pizzas { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Store> Stores { get; set; }
    public PizzaBoxContext(DbContextOptions options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Crust>().HasKey(a => a.EntityID);
      builder.Entity<Size>().HasKey(a => a.EntityID);
      builder.Entity<Topping>().HasKey(a => a.EntityID);
      builder.Entity<Pizza>().HasKey(a => a.EntityID);
      builder.Entity<Order>().HasKey(a => a.EntityID);
      builder.Entity<Customer>().HasKey(a => a.EntityID);
      builder.Entity<Store>().HasKey(a => a.EntityID);
      OnDataSeeding(builder);
    }
    protected void OnDataSeeding(ModelBuilder builder)
    {
      builder.Entity<Crust>().HasData(new Crust[]
      {
        new Crust() {EntityID =1, Name="Original", Price = 0.00m},
        new Crust() {EntityID =2, Name="Thin", Price = 0.00m},
        new Crust() {EntityID =3, Name="StuffedCrust", Price = 0.00m}
      });
      builder.Entity<Size>().HasData(new Size[]
      {
        new Size() {EntityID =1, Name="Small", Price = 5.00m },
        new Size() {EntityID =2, Name="Medium", Price = 7.00m },
        new Size() {EntityID =3, Name="Large", Price = 9.00m }
      });
      builder.Entity<Topping>().HasData(new Topping[]
      {
        new Topping() {EntityID =1, Name="Peperroni", Price = 1.00m },
        new Topping() {EntityID =2, Name="Pizza Cheese Blend", Price = 1.00m },
        new Topping() {EntityID =3, Name="Marinara Sauce", Price = 0.00m },
        new Topping() {EntityID =4, Name="Alfredo Sauce", Price = 0.00m },
        new Topping() {EntityID =5, Name="Asiago", Price = 1.00m },
        new Topping() {EntityID =6, Name="Grilled Chicken", Price = 1.00m }
      });
    }
  }
}