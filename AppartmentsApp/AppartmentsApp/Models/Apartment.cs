using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppartmentsApp.Models;

public class Apartment
{
    [Key]
    public int Id { get; set; }
    public String address { get; set; }
    public String surface { get; set; }

    [ForeignKey("Category")]
    public int CategoryId { get; set; }
    public Category Category { get; set; }
}