using AppartmentsApp.Models;
using Microsoft.EntityFrameworkCore;

namespace AppartmentsApp.Data;

public class ApplicationDbContext:DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
    {
    }

    public DbSet<Apartment> Apartments { get; set; }
    public DbSet<Category> Categories { get; set; }
}