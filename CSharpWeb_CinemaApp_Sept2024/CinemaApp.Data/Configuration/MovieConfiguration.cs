namespace CinemaApp.Data.Configuration
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Models;
    using static Common.EntityValidationConstants.Movie;
    public class MovieConfiguration : IEntityTypeConfiguration<Movie>
    {
        public void Configure(EntityTypeBuilder<Movie> builder)
        {
            //Fluent API
            builder.HasKey(m=> m.Id);
            builder.Property(m => m.Title).IsRequired().HasMaxLength(TitleMaxLength);
            builder.Property(m => m.Genre).IsRequired().HasMaxLength(GenreMaxLength);
            builder.Property(m => m.Director).IsRequired().HasMaxLength(DirectorNameMaxLength);
            builder.Property(m=>m.Description).IsRequired().HasMaxLength(DescriptionMaxLength);

            builder.HasData(this.SeedMovies());
        }
        private List<Movie> SeedMovies()
        {
            List<Movie> movies = new List<Movie>();
            //
            return movies;
        }
    }
}
