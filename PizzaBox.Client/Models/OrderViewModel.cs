using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using PizzaBox.Domain.Models;
using PizzaBox.Storage;
using PizzaBox.Storage.Repositories;

namespace PizzaBox.Client.Models
{
  public class OrderViewModel : IValidatableObject
  {
    public List<Crust> Crusts { get; set; }
    public List<Size> Sizes { get; set; }
    public List<Topping> Toppings { get; set; }
    [Required(ErrorMessage = "CrustError")]
    [DataType(DataType.Text)]
    public string SelectedCrust { get; set; }
    [Required(ErrorMessage = "SizeError")]
    [DataType(DataType.Text)]
    public string SelectedSize { get; set; }
    [Required(ErrorMessage = "ToppingError")]
    public List<string> SelectedToppings { get; set; }

    public OrderViewModel(UnitOfWork unitOfWork)
    {
<<<<<<< HEAD
      Crusts = unitOfWork.Repo.Select<Crust>(unitOfWork.context.Crusts, c => !string.IsNullOrWhiteSpace(c.Name)).ToList();
      Sizes = unitOfWork.Repo.Select<Size>(unitOfWork.context.Sizes, a => a.EntityID > 0).ToList();
      Toppings = unitOfWork.Repo.Select<Topping>(unitOfWork.context.Toppings, a => a.EntityID > 0).ToList();
=======
      Crusts = unitOfWork.Crusts.Select().ToList();
      Sizes = unitOfWork.Sizes.Select().ToList();
      Toppings = unitOfWork.Toppings.Select().ToList();

>>>>>>> parent of c4f2f25... WorkingPostGres
    }
    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
      if (SelectedToppings.Count < 2 || SelectedToppings.Count > 5)
      {
        yield return new ValidationResult("Toppings must be between 2 and 5", new[] { "SelectedToppings" });
      }
    }
  }
}