using Fiorelle_BACKEND.Models;
using Microsoft.EntityFrameworkCore;

namespace Fiorelle_BACKEND.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> option) : base(option)
        {

        }

        public DbSet<Slider> Sliders { get; set; }




    }
}
