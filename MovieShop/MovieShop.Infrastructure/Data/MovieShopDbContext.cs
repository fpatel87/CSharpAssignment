using Microsoft.EntityFrameworkCore;
using MovieShop.ApplicationCore.Entities;

namespace MovieShop.Infrastructure.Data
{
    public class MovieShopDbContext : DbContext
    {
        public MovieShopDbContext(DbContextOptions<MovieShopDbContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<MovieGenres> MovieGenres { get; set; }
        public DbSet<Cast> Casts { get; set; }
        public DbSet<MovieCasts> MovieCasts { get; set; }
        public DbSet<Trailers> Trailers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // MovieGenre - composite primary key
            modelBuilder.Entity<MovieGenres>()
                .HasKey(x => new { x.MovieId, x.GenreId });

            // MovieCast - composite primary key
            modelBuilder.Entity<MovieCasts>()
                .HasKey(x => new { x.MovieId, x.CastId });

            // MovieGenre relationships
            modelBuilder.Entity<MovieGenres>()
                .HasOne(x => x.Movie)
                .WithMany(x => x.MovieGenres)
                .HasForeignKey(x => x.MovieId);

            modelBuilder.Entity<MovieGenres>()
                .HasOne(x => x.Genre)
                .WithMany(x => x.MovieGenres)
                .HasForeignKey(x => x.GenreId);

            // MovieCast relationships
            modelBuilder.Entity<MovieCasts>()
                .HasOne(x => x.Movie)
                .WithMany(x => x.MovieCasts)
                .HasForeignKey(x => x.MovieId);

            modelBuilder.Entity<MovieCasts>()
                .HasOne(x => x.Cast)
                .WithMany(x => x.MovieCasts)
                .HasForeignKey(x => x.CastId);

            // Trailer relationship
            modelBuilder.Entity<Trailers>()
                .HasOne(x => x.Movie)
                .WithMany(x => x.Trailers)
                .HasForeignKey(x => x.MovieId);
        }
    }
}