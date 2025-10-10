// Inside Data/Sale.cs
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Sale
{
    [Key]
    public int SaleID { get; set; }

    public DateTime SaleDate { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal TotalPrice { get; set; }

    // Foreign Key to the Customer table (optional)
    public int? CustomerID { get; set; }
    public Customer? Customer { get; set; }

    // A sale can have many items
    public ICollection<SaleItem> SaleItems { get; set; } = new List<SaleItem>();
}