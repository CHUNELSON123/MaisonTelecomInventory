using System.ComponentModel.DataAnnotations;

public class Brand
{
    [Key]
    public int BrandID { get; set; }

    [Required]
    [StringLength(100)]
    public string Name { get; set; } = string.Empty;

    public ICollection<Product>? Products { get; set; }
}