using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using PizzaBox.Domain.Models;
using PizzaBox.Storage;
using PizzaBox.Storage.Repositories;

namespace PizzaBox.Client.Models
{
  public class UserViewModel : IValidatableObject
  {
    private static List<string> TakenUsernames { get; set; }

    [Required(ErrorMessage = "Required")]
    [DataType(DataType.Text)]
    public string Username { get; set; }
    [Required(ErrorMessage = "Required")]
    [DataType(DataType.Text)]
    public string FirstName { get; set; }
    [Required(ErrorMessage = "Required")]
    [DataType(DataType.Text)]
    public string LastName { get; set; }
    [Required(ErrorMessage = "Required")]
    [DataType(DataType.Text)]
    public string Password { get; set; }
    [Required(ErrorMessage = "Required")]
    [DataType(DataType.Text)]
    public string ConfirmPassword { get; set; }


    public void Load(UnitOfWork unitOfWork)
    {
      TakenUsernames = unitOfWork.Repo.Select<Customer>(unitOfWork.context.Customers, c => !string.IsNullOrWhiteSpace(c.UserName)).Select(a => a.UserName).ToList();
    }
    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
      if (TakenUsernames.Contains(Username))
      {
        yield return new ValidationResult("Username is taken!", new[] { "username" });
      }
      if (ConfirmPassword != Password)
      {
        yield return new ValidationResult("Passwords do not match!", new[] { "confirmpassword", "password" });
      }
    }
  }
}