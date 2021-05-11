using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using PizzaBox.Domain.Models;
using PizzaBox.Storage;
using PizzaBox.Storage.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace PizzaBox.Client.Models
{

  public class HistoryViewModel
  {
    public string User { get; set; }
    public string Store { get; set; }
    public List<Store> Stores;
    public List<Order> Orders;
    public void LoadStore(UnitOfWork unitOfWork, string StoreAddress)
    {
      Orders = unitOfWork.OrderRepo.Select(a => a.Store.Address == StoreAddress).ToList();
      Stores = unitOfWork.Repo.Select<Store>(unitOfWork.context.Stores, a => a.EntityID > 0).ToList();
    }
    public void LoadCustomer(UnitOfWork unitOfWork, string Username)
    {
      Orders = unitOfWork.OrderRepo.Select(a => a.Customer.UserName == Username).ToList();
      Stores = unitOfWork.Repo.Select<Store>(unitOfWork.context.Stores, a => a.EntityID > 0).ToList();
    }

  }
}