using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SupportIT.Model
{
    [Table("TblBagian", Schema = "Master")]
    public class Bagian
    {
        #region properties

        [Key]
        [MaxLength(10)]
        public string KodeBagian { get; set; }

        [MaxLength(50)]
        public string NamaBagian { get; set; }

        [MaxLength(50)]
        public string Asisten { get; set; }

        [MaxLength(10)]
        public string Grup { get; set; }

        [MaxLength(10)]
        public string Status { get; set; }

        #endregion

        #region Constructor

        public Bagian(string KodeBagian, string NamaBagian, string Asisten, string Grup)
        {
            this.KodeBagian = KodeBagian;
            this.NamaBagian = NamaBagian;
            this.Asisten = Asisten;
            this.Grup = Grup;
        }

        #endregion
    }
}
