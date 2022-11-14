using System.ComponentModel.DataAnnotations;

namespace ProductCatalog.Models;
public class Product
{
    [Key]
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public string? Type { get; set; }
    public string? DisplayName { get; set; }
    public string? Brand { get; set; }
    public string? Category { get; set; }
    public bool Active { get; set; }
}
