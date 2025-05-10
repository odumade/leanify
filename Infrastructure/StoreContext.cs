using Entity;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions options) : base(options)
        {            
        }        

        public DbSet<Course> Courses { get; set; }
        public DbSet<Category> Categories { get; set; }

        public DbSet<Requirement> Requirements { get; set; }
        public DbSet<Learning> Learnings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(StoreContext).Assembly);
            DataSeeder.SeedData(modelBuilder);
        }
    }
}
