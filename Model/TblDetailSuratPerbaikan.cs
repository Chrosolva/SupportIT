using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SupportIT.Model
{
    [Table("TblDetailSuratPerbaikan", Schema = "Master")]
    public class TblDetailSuratPerbaikan
    {
        [Key, Column(Order = 0)]
        public int SPId { get; set; }

        [Key, Column(Order = 1)]
        public int NoUrut { get; set; }  // 1..N

        [MaxLength(20)]
        public string KodeInventaris { get; set; }

        [MaxLength(500)]
        public string NamaBarang { get; set; }

        public int Jumlah { get; set; }

        [MaxLength(20)]
        public string Satuan { get; set; }

        [MaxLength(200)]
        public string Keterangan { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime CreatedAt { get; set; }

        [MaxLength(50)]
        public string CreatedBy { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime UpdatedAt { get; set; }

        [MaxLength(50)]
        public string UpdatedBy { get; set; }

        [Timestamp]
        public byte[] RowVer { get; set; }

        // nav
        [ForeignKey(nameof(SPId))]
        public virtual TblSuratPerbaikan Surat { get; set; }
    }
}
