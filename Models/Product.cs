using System.ComponentModel.DataAnnotations;

namespace Blazor8Shop.Models;

public class Product {

    [Key]
    public int Id { get; set; }
    [Required(ErrorMessage = "Nome obrigatório")] 
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    [Required(ErrorMessage = "Preço obrigatório")] 
    public double Price { get; set; }

    public int CategoryId { get; set; }
    public Category Category { get; set; } = null!;
}
