using System.ComponentModel.DataAnnotations;

namespace ProductCatalog.Models;
public class Seller
{
    [Key]
    public Guid Id { get; set; }
    public string? Name { get; set; }
}