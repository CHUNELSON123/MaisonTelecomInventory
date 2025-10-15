// Inside Data/Models/Customer.cs
using System.ComponentModel.DataAnnotations;

public class Customer
{
    [Key]
    public int CustomerID { get; set; }

    [Required]
    [StringLength(150)]
    public string Name { get; set; } = string.Empty;

    [StringLength(50)]
    public string? PhoneNumber { get; set; }

    // This is the new property that links a customer to their sales.
    public virtual ICollection<Sale> Sales { get; set; } = new List<Sale>();
}