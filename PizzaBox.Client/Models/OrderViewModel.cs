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
    public List<Store> Stores { get; set; }
    [Required(ErrorMessage = "Please select a crust.")]
    [DataType(DataType.Text)]
    public string SelectedCrust { get; set; }
    [Required(ErrorMessage = "Please select a size.")]
    [DataType(DataType.Text)]
    public string SelectedSize { get; set; }
    [Required(ErrorMessage = "Please select 2-5 toppings.")]
    public List<string> SelectedToppings { get; set; }
    [Required(ErrorMessage = "Required")]
    [DataType(DataType.Text)]
    public Store SelectedStore { get; set; }
    public Customer Customer { get; set; }



    public void Load(UnitOfWork unitOfWork)
    {
      Crusts = unitOfWork.Repo.Select<Crust>(unitOfWork.context.Crusts, c => !string.IsNullOrWhiteSpace(c.Name)).ToList();
      Sizes = unitOfWork.Repo.Select<Size>(unitOfWork.context.Sizes, a => a.EntityID > 0).ToList();
      Toppings = unitOfWork.Repo.Select<Topping>(unitOfWork.context.Toppings, a => a.EntityID > 0).ToList();
      Stores = unitOfWork.Repo.Select<Store>(unitOfWork.context.Stores, a => a.EntityID > 0).ToList();
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