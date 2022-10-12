using csharp_boolflix.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection.PortableExecutable;

namespace csharp_boolflix.Data
{
    public class BoolflixContext : DbContext
    {
        public DbSet<Movie>? Movies { get; set; }
        public DbSet<TvSerie>? TvSeries { get; set; }
        public DbSet<MediaLink>? MediaLinks { get; set; }
        public DbSet<Episode>? Episodes { get; set; }
        public DbSet<Actor>? Actors { get; set; }
        public DbSet<Genre>? Genres { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=db-boolflix;Integrated Security=True;Pooling=False");
        }
    }
}
