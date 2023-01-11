using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace moviesite.Models
{
    public class AppDbContext : IdentityDbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options)
                : base(options)
        {
        
        }

        public DbSet<Film> TBLMOVIES { get; set; }
        public DbSet<WantToWatch> WantToWatch { get; set; }
        public DbSet<Watched> Watched { get; set; }

    }
}
