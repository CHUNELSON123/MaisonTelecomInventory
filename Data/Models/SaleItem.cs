// Inside Data/SaleItem.cs
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class SaleItem
{
    [Key]
    public int SaleItemID { get; set; }

    // Foreign Key to the Sale table
    public int SaleID { get; set; }
    public Sale? Sale { get; set; }

    // Foreign Key to the Product table
    public int ProductID { get; set; }
    public Product? Product { get; set; }

    public int QuantitySold { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal PriceAtTimeOfSale { get; set; }
}