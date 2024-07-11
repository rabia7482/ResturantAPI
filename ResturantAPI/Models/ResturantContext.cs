

using Microsoft.EntityFrameworkCore;

namespace ResturantAPI.Models
{
    public class ResturantContext : DbContext
    {
        public ResturantContext(DbContextOptions<ResturantContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Menu>()
                .HasMany(c => c.Dishes)
                .WithOne(a => a.Menu)
                .HasForeignKey(a => a.MenuId);

            modelBuilder.Seed();
        }

        public DbSet<Dish> Dishes { get; set; }
        public DbSet<Menu> Categories { get; set; }
    }
}


