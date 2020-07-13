using LinkInBio.Host.Models.Data;
using Microsoft.EntityFrameworkCore;

namespace LinkInBio.Host
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
         : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BioLanding>()
                .HasMany(c => c.Tiles)
                .WithOne();
        }

        public DbSet<BioLanding> Landings { get; set; }

        public DbSet<Tile> Tiles { get; set; }
    }
}
