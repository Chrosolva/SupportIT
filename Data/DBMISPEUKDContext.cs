using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using SupportIT.Model;

namespace SupportIT.Data
{
    public class DBMISPEUKDContext : DbContext
    {
        public DBMISPEUKDContext() : base("name=DBMISPEUKD_Prod")
        {
            // Configure if needed
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }

        // DbSets for all tables from the screenshot
        public DbSet<Kategori> Kategoris { get; set; }
        public DbSet<Bagian> Bagians { get; set; }
        public DbSet<Kebun> Kebuns { get; set; }
        public DbSet<TblInventarisKomputer> InventarisKomputers { get; set; }
        public DbSet<DetailInventarisKomputer> DetailInventarisKomputers { get; set; }
        public DbSet<TblSuratPerbaikan> SuratPerbaikans { get; set; }
        public DbSet<TblDetailSuratPerbaikan> DetailSuratPerbaikans { get; set; }
        public DbSet<TblSuratPerbaikanLog> SuratPerbaikanLogs { get; set; }
        public DbSet<BatasInventaris> BatasInventaris { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Prevent EF from pluralizing table names
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            // Composite keys are already defined via data annotations on the entity classes.

            base.OnModelCreating(modelBuilder);
        }
    }
}