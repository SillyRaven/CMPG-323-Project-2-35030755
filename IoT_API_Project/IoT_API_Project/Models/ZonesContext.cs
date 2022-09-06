using Microsoft.EntityFrameworkCore;

namespace Project2_IoT_Management.Models
{
    public class ZonesContext : DbContext
    {
        public ZonesContext(DbContextOptions<ZonesContext> options)
            : base(options)
        {
        }

        public DbSet<Zones> Zones { get; set; } = null!;
    }
}
