using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using PizzaBox.Domain.Models;
using PizzaBox.Storage;
using PizzaBox.Storage.Repositories;

namespace PizzaBox.Client.Models
{

  public class ExistingUserViewModel : IValidatableObject
  {
    private static List<Customer> Customers { get; set; }
    [Required(ErrorMessage = "Required")]
    [DataType(DataType.Text)]
    public string Username { get; set; }
    [Required(ErrorMessage = "Required")]
    [DataType(DataType.Text)]
    public string Password { get; set; }
    public void Load(UnitOfWork unitOfWork)
    {
      Customers = unitOfWork.Repo.Select<Customer>(unitOfWork.context.Customers, a => a.EntityID > 0).ToList();
    }
    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
      var customer = Customers.Where(a => a.UserName == Username).FirstOrDefault();
      if (customer == null)
      {
        yield return new ValidationResult("Username or password does not match.", new[] { "username" });
      }
      else if (customer.Password != Password)
      {
        yield return new ValidationResult("Username or password does not match.", new[] { "username" });
      }
    }
  }
}