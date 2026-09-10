using The25th_WEB.Models;
using Microsoft.EntityFrameworkCore;

namespace The25th_WEB.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
           
           modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Sci-Fi" },
                new Category { Id = 2, Name = "Fantasy" },
                new Category { Id = 3, Name = "Mystery" }
            );
        }
    }
}