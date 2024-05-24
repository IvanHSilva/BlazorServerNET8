using System.ComponentModel.DataAnnotations;

namespace Blazor8Shop.Models; 

public class Category {
    
    [Key]
    public int Id { get; set; }
    [Required(ErrorMessage = "Nome obrigatório")]
    public string Name { get; set; } = string.Empty;
}
