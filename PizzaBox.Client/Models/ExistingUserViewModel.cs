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
    [Required(ErrorMessage = "Required")]
    [DataType(DataType.Text)]
    public string Username { get; set; }
    [Required(ErrorMessage = "Required")]
    [DataType(DataType.Text)]
    public string Password { get; set; }

    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
      if (Password == null)
      {
        yield return new ValidationResult("Username or password does not match.", new[] { "username" });
      }
    }
  }
}