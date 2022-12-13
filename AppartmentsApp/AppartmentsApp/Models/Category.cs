using System.ComponentModel.DataAnnotations;

namespace AppartmentsApp.Models;

public class Category
{
    [Key]
    public int Id { get; set; }
    public String Name { get; set; }
    
}