using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace Project2_IoT_Management.Models
{
    public class DeviceContext : DbContext
    {
        public DeviceContext(DbContextOptions<DeviceContext> options)
            : base(options)
        {
        }

        public DbSet<Devices> Devices { get; set; } = null!;
    }
}