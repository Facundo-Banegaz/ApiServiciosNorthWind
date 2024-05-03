using Microsoft.EntityFrameworkCore;
using ServiciosNorthWind.Models;

namespace ServiciosNorthWind.Data
{
    public class NorthwindContext:DbContext
    {
        public NorthwindContext(DbContextOptions<NorthwindContext> options): base(options) { }
    
    
        public DbSet<Shipper> Shippers { get; set; }
    
        public DbSet<Region> Region { get; set; }

        public DbSet<Category> Categories { get; set; } 
    }
}
