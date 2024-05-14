using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace WebSBazom
{
    public class MojaPrvaBazaDbContext : DbContext
    {
        public DbSet<Osoba> Osobe { get; set; }
        public DbSet<Zivotinja> Zivotinje { get; set; }
        public DbSet<OsobaZivotinja> OsobeZivotinje { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            var sb = new SqlConnectionStringBuilder
            {
                DataSource = @"localhost\MSSQL14",
                InitialCatalog = "MojaPrvaBaza",
                IntegratedSecurity = true,
                MultipleActiveResultSets = true
            };

            builder.UseSqlServer(sb.ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OsobaZivotinja>().HasKey(x => new { x.OsobaId, x.ZivotinjaId });

            base.OnModelCreating(modelBuilder);
        }
    }
}
