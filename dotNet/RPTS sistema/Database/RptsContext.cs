using Microsoft.EntityFrameworkCore;
using RPTS_sistema.Database.InitialData;
using RPTS_sistema.Models;

namespace RPTS_sistema.Database
{
    public class RptsContext : DbContext
    {
        public RptsContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<AdministrativeInspection> AdministrativeInspections { get; set; }
        public DbSet<Company> Company { get; set; }
        public DbSet<Complain> Complain { get; set; }
        public DbSet<Conclusion> Conclusion { get; set; }
        public DbSet<Investigation> Investigation { get; set; }
        public DbSet<InvestigationStage> InvestigationStage { get; set; }
        public DbSet<LocalUser> LocalUser { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           // modelBuilder.Entity<LocalUser>().HasData(LocalUserInitialData.GetDataSeed());
            modelBuilder.Entity<Conclusion>().HasData(ConclusionInitialData.DataSeed);
            
            modelBuilder.Seed();

        }
    }
}
