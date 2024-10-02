using Microsoft.EntityFrameworkCore;
using TATU.Domain;

namespace TATU.Infrastructure
{
    public class ApplicationDbContext : DbContext
    {
        private const string MSSQL_CONECTION = "Server=(localdb)\\mssqllocaldb;Database=TATU_BD;Trusted_Connection=True;";

        public DbSet<Account> Accounts { get; set; }
        public DbSet<Manager> Managers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Services> Services { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Master> Masters { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(MSSQL_CONECTION);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
            modelBuilder.Entity<Account>().UseTptMappingStrategy();
        }

    }
}
