using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SupportIT.Model
{
    /// <summary>
    /// Entity Framework model for the Master.TblInventarisKomputer table.  This class
    /// is optional – if you choose to query inventory via EF instead of your
    /// legacy DBConnectionClass library then this mapping lets you project
    /// inventory data using LINQ.  None of your existing manual queries are
    /// touched, so older code will continue to work unchanged.  If you
    /// eventually migrate everything to EF, simply add a DbSet for this
    /// entity in your DbContext.
    /// </summary>
    [Table("TblInventarisKomputer", Schema = "Master")]
    public class TblInventarisKomputer
    {
        #region properties

        [Key]
        [MaxLength(20)]
        public string KodeInventaris { get; set; }

        [MaxLength(2)]
        public string KodeKategori { get; set; }

        [MaxLength(2)]
        public string KodeKebun { get; set; }

        public bool Aktif { get; set; }

        [MaxLength(100)]
        public string NoPO { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? TglBeli { get; set; }

        [MaxLength(500)]
        public string NamaBarang { get; set; }

        [MaxLength(20)]
        public string Status { get; set; }

        [MaxLength(20)]
        public string KodeInvLama { get; set; }

        [MaxLength(10)]
        public string KodePT { get; set; }

        [MaxLength(50)]
        public string KeteranganAfkir { get; set; }

        #endregion

        #region Constructor

        public TblInventarisKomputer()
        {

        }

        public TblInventarisKomputer(string KodeInventaris, string KodeKategori, string KodeKebun, bool Aktif, string NoPO, DateTime TglBeli,string NamaBarang, string Status, string KodeInvLama)
        {
            this.KodeInventaris = KodeInventaris;
            this.KodeKebun = KodeKebun;
            this.KodeKategori = KodeKategori;
            this.Aktif = Aktif;
            this.NoPO = NoPO;
            this.TglBeli = TglBeli;
            this.NamaBarang = NamaBarang;
            this.Status = Status;
            this.KodeInvLama = KodeInvLama;
        }

        public TblInventarisKomputer(string KodeInventaris, string KodeKategori, string KodeKebun, bool Aktif, string NoPO, DateTime TglBeli, string NamaBarang, string Status, string KodeInvLama, string KodePT, string KeteranganAfkir)
        {
            this.KodeInventaris = KodeInventaris;
            this.KodeKebun = KodeKebun;
            this.KodeKategori = KodeKategori;
            this.Aktif = Aktif;
            this.NoPO = NoPO;
            this.TglBeli = TglBeli;
            this.NamaBarang = NamaBarang;
            this.Status = Status;
            this.KodeInvLama = KodeInvLama;
            this.KodePT = KodePT;
            this.KeteranganAfkir = KeteranganAfkir;
        }

        #endregion
    }
}
