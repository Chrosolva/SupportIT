using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SupportIT.Model
{
    [Table("BatasInventaris", Schema = "Master")]
    public class BatasInventaris
    {
        #region properties

        // Composite PK: KodeBagian + KodeKategori + KodeKebun
        [Key]
        [Column(Order = 0)]
        [MaxLength(10)]
        public string KodeBagian { get; set; }

        [Key]
        [Column(Order = 1)]
        [MaxLength(2)]
        public string KodeKategori { get; set; }

        [Key]
        [Column(Order = 2)]
        [MaxLength(2)]
        public string KodeKebun { get; set; }

        // Other columns
        public int? JumlahMax { get; set; }

        [MaxLength(50)]
        public string Keterangan { get; set; }

        #endregion

        #region Constructor

        public BatasInventaris(string KodeBagian, string KodeKategori, string KodeKebun, int JumlahMax, string Keterangan)
        {
            this.KodeBagian = KodeBagian;
            this.KodeKategori = KodeKategori;
            this.KodeKebun = KodeKebun;
            this.JumlahMax = JumlahMax;
            this.Keterangan = Keterangan;
        }

        #endregion
    }
}
