using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Product
{
    [Key]
    public int ProductID { get; set; }

    [Required]
    [StringLength(200)]
    public string Name { get; set; } = string.Empty;

    [Column(TypeName = "decimal(18, 2)")]
    public decimal CostPrice { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal SellingPrice { get; set; }

    public int StockQuantity { get; set; }

    // Foreign Key to the Category table
    public int CategoryID { get; set; }
    public Category? Category { get; set; }

    // Foreign Key to the Brand table
    public int BrandID { get; set; }
    public Brand? Brand { get; set; }
}