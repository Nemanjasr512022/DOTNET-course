using DOTNET_course.Models.Models;
using Microsoft.EntityFrameworkCore;

namespace DOTNET_course.Data.Access.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(

                new Category { Id = 1, DisplayOrder = 1, Name = "Sci-fi" },
                new Category { Id = 3, DisplayOrder = 3, Name = "Romance" },
                new Category { Id = 2, DisplayOrder = 2, Name = "Fantasy" });
        }
    }

}
