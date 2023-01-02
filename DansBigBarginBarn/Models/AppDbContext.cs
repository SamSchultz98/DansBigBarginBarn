using Microsoft.EntityFrameworkCore;

namespace DansBigBarginBarn.Models
{
    public class AppDbContext : DbContext 
    {
        AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder) { }
    }
}
