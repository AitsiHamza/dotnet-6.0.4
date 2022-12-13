using AppartmentsApp.Models;

namespace AppartmentsApp.Data;

public class Seed
{
    public static void SeedData(IApplicationBuilder applicationBuilder)
    {
        using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
        {
            var context = serviceScope.ServiceProvider.GetService<ApplicationDbContext>();

            context.Database.EnsureCreated();

            if (!context.Categories.Any())
            {
                context.Categories.AddRange(new List<Category>()
                {
                    new Category()
                    {
                        Name = "villa"
                    },
                    new Category()
                    {
                        Name = "studio"
                    },
                });
                context.SaveChanges();
            }
            if (!context.Apartments.Any())
            {
                context.Apartments.AddRange(new List<Apartment>()
                {
                    new Apartment()
                    {
                        address = "Mohammedia ...",
                        surface = "1355m2",
                        CategoryId=1
                    },
                    new Apartment()
                    {
                        address = "Casa ...",
                        surface = "5655m2",
                        CategoryId=1
                    },
                    new Apartment()
                    {
                        address = "Rabat ...",
                        surface = "885m2",
                        CategoryId=2
                    },
                });
                context.SaveChanges();
            }
        }
    }

}