using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace Project2_IoT_Management.Models
{
        public class DevicesContext : DbContext
        {
            public DevicesContext(DbContextOptions<DevicesContext> options)
                : base(options)
            {
            }

            public DbSet<Devices> Devices { get; set; } = null!;
        }
}
