using disntney_plus_api.Models;
using Microsoft.EntityFrameworkCore;

namespace disntney_plus_api.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}

        public DbSet<Movie> Movies { get; set; }

        public DbSet<MovieImage> MoviesImages { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<CategoryGallery> CategoriesGallery { get; set; }

        public DbSet<Recommendation> Recommendations { get; set; }
    }
}
