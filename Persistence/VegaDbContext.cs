using AspNetCoreAngular.Models;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreAngular.Persistence
{
    public class VegaDbContext : DbContext
    {
        public DbSet<Make> Makes { get; set; }
        public DbSet<Feature> Features { get; set; }

        public VegaDbContext(DbContextOptions<VegaDbContext> options)
            : base(options) 
        {

        }

    }
}