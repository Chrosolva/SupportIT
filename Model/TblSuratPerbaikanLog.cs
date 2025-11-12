using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SupportIT.Model
{
    [Table("TblSuratPerbaikanLog", Schema = "Log")]
    public class TblSuratPerbaikanLog
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long LogId { get; set; }

        public int SPId { get; set; }

        [Required, MaxLength(40)]
        public string EventType { get; set; }   // CREATED/ASSIGNED/IN_PROGRESS/COMPLETED/CANCELED/STATUS_CHANGED

        [Column(TypeName = "datetime2")]
        public DateTime EventAt { get; set; }

        [MaxLength(50)]
        public string EventBy { get; set; }

        [MaxLength(200)]
        public string Note { get; set; }

        [ForeignKey(nameof(SPId))]
        public virtual TblSuratPerbaikan Surat { get; set; }
    }
}
