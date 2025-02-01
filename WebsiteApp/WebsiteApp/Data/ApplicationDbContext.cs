using Microsoft.EntityFrameworkCore;
using WebsiteApp.Models;

namespace WebsiteApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Race> Races { get; set; }
        public DbSet<Club> CLubs { get; set; }
        public object Clubs { get; internal set; }
        public DbSet<Address> Addresses { get; set; }
    }
}
