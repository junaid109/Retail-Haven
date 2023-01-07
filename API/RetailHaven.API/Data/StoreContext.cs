using Microsoft.EntityFrameworkCore;
using RetailHaven.API.Models;

namespace RetailHaven.API.Data
{
    public class StoreContext: DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .Property(p => p.DateAdded)
                .HasDefaultValueSql("getdate()");
            modelBuilder.Entity<Product>()
                .Property(p => p.DateModified)
                .HasDefaultValueSql("getdate()");
            modelBuilder.Entity<Product>()
                .Property(p => p.DateDeleted)
                .HasDefaultValueSql("getdate()");
            modelBuilder.Entity<Product>()
                .Property(p => p.IsDeleted)
                .HasDefaultValueSql("0");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=StoreDb;Trusted_Connection=True;");
        }

        


    }
}
