using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace Project2_IoT_Management.Models
{
    public class ZoneContext : DbContext
    {
        public ZoneContext(DbContextOptions<ZoneContext> options)
            : base(options)
        {
        }

        public DbSet<Zones> Zones { get; set; } = null!;
    }
}