global using Microsoft.EntityFrameworkCore;
using HumanAPI.Configuration;
using HumanAPI.Models;

namespace HumanAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<HumanModel> HumanModels { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new HumanConfiguration());
        }
    }
}
