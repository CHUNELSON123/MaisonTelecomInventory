// Inside Data/Product.cs
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Product
{
    [Key]
    public int ProductID { get; set; }

    [Required]
    [StringLength(200)]
    public string Name { get; set; } = string.Empty;

    [StringLength(100)]
    public string? Brand { get; set; }

    public string? Specifications { get; set; }

    [Column(TypeName = "decimal(18, 2)")] // For storing money values
    public decimal CostPrice { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal SellingPrice { get; set; }

    public int StockQuantity { get; set; }

    // This is the Foreign Key to the Category table
    public int CategoryID { get; set; }
    public Category? Category { get; set; }
}