using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace Project2_IoT_Management.Models
{
    public class CategoriesContext : DbContext
    {
        public CategoriesContext(DbContextOptions<CategoriesContext> options)
            : base(options)
        {
        }

        public DbSet<Categories> Categories { get; set; } = null!;
    }
}