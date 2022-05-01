using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Weather.Database.Models;

namespace Weather.Database
{
    public class AppDbContext : DbContext
    {

        public AppDbContext() : base("DbContext")
        {
        }

        public DbSet<WeatherDetails> Weathers { get; set; }
        public DbSet<City> Cities { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
