using Microsoft.EntityFrameworkCore;

namespace Spange_Bob.Models
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Home> Homes { get; set; }

        public DbSet<Friend> Friends { get; set; }
    }
}
