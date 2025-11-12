using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using SupportIT.Model;

namespace SupportIT.Data
{
    public class DBMISPEUKDContext : DbContext
    {
        public DBMISPEUKDContext() : base("name=DBMISPEUKD_Prod")
        {
            Configuration.LazyLoadingEnabled = false;   // to avoid accidental deep loads
            Configuration.ProxyCreationEnabled = false; // simpler with WinForms binding
        }

        // Live tables
        public DbSet<TblSuratPerbaikan> SuratPerbaikans { get; set; }
        public DbSet<TblDetailSuratPerbaikan> DetailSuratPerbaikans { get; set; }
        public DbSet<TblSuratPerbaikanLog> SuratPerbaikanLogs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Keep your singular names; skip pluralizing conv to stay close to DB
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            // Composite key for detail is defined via [Key, Column(Order=..)] attributes.

            // FK: Detail -> Header with cascade delete (DB already has it; be explicit too)
            modelBuilder.Entity<TblDetailSuratPerbaikan>()
                .HasRequired(d => d.Surat)
                .WithMany() // we don't need a navigation collection in TblSuratPerbaikan
                .HasForeignKey(d => d.SPId)
                .WillCascadeOnDelete(true);

            // Index attributes (like UQ_NoSP) are honored in Code First Migrations,
            // but since we already created tables, we’re not running migrations.
            base.OnModelCreating(modelBuilder);
        }
    }
}
