using System.Collections.Generic;

namespace PizzaBox.Client.Models
{
  public class OrderViewModel
  {
    public List<string> Crusts { get; set; } = new List<string> { "original", "deep dish" };
    public List<string> Sizes { get; set; }
    public List<string> Toppings { get; set; }
    public string SelectedCrust { get; set; }
    public string SelectedSize { get; set; }
    public List<string> SelectedToppings { get; set; }
  }
}