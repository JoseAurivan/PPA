using Microsoft.EntityFrameworkCore;
using PPA.Models;

namespace PPA.Data
{
    public class AppContext : DbContext
    {
        public AppContext(DbContextOptions<AppContext> options) : base(options)
        {
        }

        public DbSet<Opiniao> Opiniaos { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Opiniao>().ToTable("Entrada");
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured) return;
            optionsBuilder.UseSqlServer("Server=localhost;Database=opiniao;" +
                                        "Trusted_Connection=True;MultipleActiveResultSets=true");
        }
    }
}