using PizzaBox.Domain.Models;
using Xunit;
using PizzaBox.Client.Models;
using System.Collections.Generic;
using PizzaBox.Storage;
using Microsoft.EntityFrameworkCore;
using PizzaBox.Client.Controllers;

namespace PizzaBox.Testing.Tests
{
  public class Testing
  {
    [Fact]
    public void Test_PizzaConstructor()
    {
      var sut = new Pizza();

      Assert.NotNull(sut);
    }
    [Fact]
    public void Test_CrustConstructor()
    {
      var sut = new Crust();

      Assert.NotNull(sut);
    }
    [Fact]
    public void Test_ToppingConstructor()
    {
      var sut = new Topping();

      Assert.NotNull(sut);
    }
    [Fact]
    public void Test_SizeConstructor()
    {
      var sut = new Crust();

      Assert.NotNull(sut);
    }
    [Fact]
    public void Test_ErrorViewModel()
    {
      var sut = new ErrorViewModel();

      Assert.NotNull(sut);
    }
    [Fact]
    public void Test_HistoryViewModel()
    {
      var sut = new HistoryViewModel();
      Assert.NotNull(sut);
    }
    [Fact]
    public void Test_OrderViewModel()
    {
      var sut = new OrderViewModel();
      sut.Load(new List<Pizza>());
      Assert.NotNull(sut.Pizzas);
    }
    [Fact]
    public void Test_UserViewModel()
    {
      var sut = new UserViewModel();
      Assert.NotNull(sut);
    }
    [Fact]
    public void Test_ExistingUserViewModel()
    {
      var sut = new ExistingUserViewModel();
      Assert.NotNull(sut);
    }
    [Fact]
    public void Test_UserVieModel()
    {
      var sut = new UserViewModel();
      Assert.NotNull(sut);
    }
    [Fact]
    public void Test_HomeController()
    {
      var sut = new HomeController();
      Assert.NotNull(sut);
    }
  }
}