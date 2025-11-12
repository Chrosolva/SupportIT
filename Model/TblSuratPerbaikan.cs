using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SupportIT.Model
{
    [Table("TblSuratPerbaikan", Schema = "Master")]
    public class TblSuratPerbaikan
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SPId { get; set; }

        [Required, MaxLength(15)]
        [Index("UQ_NoSP", IsUnique = true)]
        public string NoSP { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime TglSP { get; set; }

        [MaxLength(50)]
        public string Kepada { get; set; }

        [MaxLength(200)]
        public string Lokasi { get; set; }

        [Required, MaxLength(50)]
        public string Status { get; set; }

        [MaxLength(40)]
        public string PIC { get; set; }

        [MaxLength(10)]
        public string KodePT { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime CreatedAt { get; set; }

        [MaxLength(50)]
        public string CreatedBy { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime UpdatedAt { get; set; }

        [MaxLength(50)]
        public string UpdatedBy { get; set; }

        // rowversion for optimistic concurrency
        [Timestamp]
        public byte[] RowVer { get; set; }
    }
}
