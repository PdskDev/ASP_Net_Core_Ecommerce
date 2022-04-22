using Bakery.Models;
using Microsoft.EntityFrameworkCore;
using Bakery.Data.Configurations;

namespace Bakery.Data
{
    public class Bakerycontext: DbContext
    {
        public DbSet<Product> Products {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=XXX;Database=BakeryDb;Integrated security=true;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductConfiguration()).Seed();
        }
        
    }
}
