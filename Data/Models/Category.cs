 using System.ComponentModel.DataAnnotations;

public class Category
{
    [Key] // This marks CategoryID as the Primary Key
    public int CategoryID { get; set; }

    [Required] // This makes the Name field required
    [StringLength(100)]
    public string Name { get; set; } = string.Empty;
}