using Microsoft.EntityFrameworkCore;

namespace Solution.API.Test.Models
{
    public class BrandContext : DbContext
    {

        public BrandContext(DbContextOptions<BrandContext> options) : base(options) { 
        
        }

        public DbSet<Brand> Brands { get; set; }

    }
}
