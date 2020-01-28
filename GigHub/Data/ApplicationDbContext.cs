using GigHub.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GigHub.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {

        public DbSet<Genre> Genres { get; set; }
        public DbSet<Gig> Gigs { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Genre>().HasData(
                new Genre { Id = 1, Name = "Jazz" },
                new Genre { Id = 2, Name = "Classic" },
                new Genre { Id = 3, Name = "Rock" },
                new Genre { Id = 4, Name = "Pop" });
        }
    }
}
