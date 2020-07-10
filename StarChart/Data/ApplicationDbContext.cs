using Microsoft.EntityFrameworkCore;
using StarChart.Models;

namespace StarChart.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        //TODO 02.03 : add CelestialObjects to ApplicationDbContext
        public DbSet<CelestialObject> CelestialObjects { get; set; }
    }
}
