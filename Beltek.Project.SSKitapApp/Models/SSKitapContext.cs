using Microsoft.EntityFrameworkCore;
using Beltek.Project.SSKitapApp.Models;

namespace Beltek.Project.SSKitapApp.Models
{
    public class SSKitapContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=.; Initial Catalog =SSKitapDB; Integrated Security= true");
        }
        public DbSet<Beltek.Project.SSKitapApp.Models.Books> Books { get; set; }
        public DbSet<Beltek.Project.SSKitapApp.Models.Booktypes> Booktypes { get; set; }
        public DbSet<Beltek.Project.SSKitapApp.Models.BookWriters> BookWriters { get; set; }
        public DbSet<Beltek.Project.SSKitapApp.Models.Stationary> Stationary { get; set; }
    }
}
