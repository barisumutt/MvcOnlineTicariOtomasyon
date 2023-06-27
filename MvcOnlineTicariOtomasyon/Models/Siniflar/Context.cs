using Microsoft.EntityFrameworkCore;

namespace MvcOnlineTicariOtomasyon.Models.Siniflar
{
    public class TicariOtomasyonDbContext : DbContext
    {

        public TicariOtomasyonDbContext(DbContextOptions<TicariOtomasyonDbContext> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json")
                .Build(); 


            string connectionString = configuration.GetConnectionString("TicariOtomasyonDbConnection");
            optionsBuilder.UseSqlServer(connectionString);
        }
        // DbSet properties for your database tables go here
        // Example: public DbSet<Customer> Customers { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Cariler> Carilers { get; set; }
        public DbSet<Departman> Departmans { get; set; }
        public DbSet<FaturaKalem> FaturaKalems { get; set; }
        public DbSet<Faturalar> Faturalars { get; set; }
        public DbSet<Gider> Giders { get; set; }
        public DbSet<Kategori> Kategoris { get; set; }
        public DbSet<Personel> Personels { get; set; }
        public DbSet<SatisHareket> SatisHarekets { get; set; }
        public DbSet<Urun> Uruns { get; set; }
    }
}
