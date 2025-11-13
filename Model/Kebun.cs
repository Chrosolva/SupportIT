using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SupportIT.Model
{
    [Table("TblKebun", Schema = "Umum")]
    public class Kebun
    {

        #region properties

        [Key]
        [MaxLength(2)]
        public string KodeKebun { get; set; }

        [MaxLength(50)]
        public string NamaKebun { get; set; }

        [MaxLength(500)]
        public string Alamat { get; set; }

        [MaxLength(20)]
        public string NamaSingkat { get; set; }

        [MaxLength(50)]
        public string Kota { get; set; }

        [MaxLength(10)]
        public string KodePos { get; set; }

        [MaxLength(20)]
        public string Telp { get; set; }

        [MaxLength(20)]
        public string Fax { get; set; }

        [MaxLength(10)]
        public string Status { get; set; }


        #endregion

        #region Constructor

        public Kebun(string KodeKebun, string NamaKebun, string Alamat, string NamaSingkat, string Kota, string Kodepos, string Telp, string Fax, string Status)
        {
            this.KodeKebun = KodeKebun;
            this.NamaKebun = NamaKebun;
            this.Alamat = Alamat;
            this.NamaSingkat = NamaSingkat;
            this.Kota = Kota;
            this.KodePos = Kodepos;
            this.Telp = Telp;
            this.Fax = Fax;
            this.Status = Status;
        }

        #endregion 

    }
}
