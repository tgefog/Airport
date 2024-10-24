namespace CinemaApp.Data
{
    using Microsoft.EntityFrameworkCore;
    using Models;
    using System.Reflection;

    public class CinemaDbContext : DbContext
    {
        public CinemaDbContext()
        {
            
        }
        public CinemaDbContext(DbContextOptions options) 
            :base(options)
        { 
        }
        public virtual DbSet<Movie> Movies { get; set; } = null!;
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
