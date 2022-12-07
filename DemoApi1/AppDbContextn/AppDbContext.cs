using DemoApi1.Model;
using Microsoft.EntityFrameworkCore;

namespace DemoApi1.AppDbContextn
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<School> Schools { get; set; }
    }
}
