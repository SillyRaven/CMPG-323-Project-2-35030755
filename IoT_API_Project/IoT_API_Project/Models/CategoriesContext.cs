using Microsoft.EntityFrameworkCore;

namespace Project2_IoT_Management.Models
{
        public class CategoriesContext : DbContext
        {
            public CategoriesContext(DbContextOptions<CategoriesContext> options)
                : base(options)
            {
            }

            public DbSet<Categories> categories { get; set; } = null!;
        }
}
