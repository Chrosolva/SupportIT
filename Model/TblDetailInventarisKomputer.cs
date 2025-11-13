using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SupportIT.Model
{
    [Table("TblDetailInventarisKomputer", Schema = "Master")]
    public class DetailInventarisKomputer
    {
        #region properties

        // Composite key: KodeInventaris + Tgl
        [Key, Column(Order = 0)]
        [MaxLength(20)]
        public string KodeInventaris { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "datetime2")]
        public DateTime Tgl { get; set; }

        [MaxLength(2)]
        public string Kebun { get; set; }

        [MaxLength(10)]
        public string KodeBagian { get; set; }

        [MaxLength(150)]
        public string Pengguna { get; set; }

        [MaxLength(1000)]
        public string Spesifikasi { get; set; }

        [MaxLength(1000)]
        public string Kebutuhan { get; set; }

        [MaxLength(200)]
        public string Keterangan { get; set; }

        [MaxLength(50)]
        public string MacAddress1 { get; set; }

        [MaxLength(50)]
        public string MacAddress2 { get; set; }

        [MaxLength(50)]
        public string MacAddress3 { get; set; }

        [MaxLength(50)]
        public string IP1 { get; set; }

        [MaxLength(50)]
        public string IP2 { get; set; }

        [MaxLength(50)]
        public string IP3 { get; set; }

        [MaxLength(50)]
        public string ActiveUser { get; set; }

        #endregion

        #region Constructor 

        public DetailInventarisKomputer(string KodeInventaris, DateTime Tgl,string Kebun, string KodeBagian, string Pengguna, string Spesifikasi, string Kebutuhan, string Keterangan, string MacAddress1, string MacAddress2, string MacAddress3, string IP1, string IP2,string IP3, string ActiveUser)
        {
            this.KodeInventaris = KodeInventaris;
            this.Tgl = Tgl;
            this.Kebun = Kebun;
            this.KodeBagian = KodeBagian;
            this.Pengguna = Pengguna;
            this.Spesifikasi = Spesifikasi;
            this.Kebutuhan = Kebutuhan;
            this.Keterangan = Keterangan;
            this.MacAddress1 = MacAddress1;
            this.MacAddress2 = MacAddress2;
            this.MacAddress3 = MacAddress3;
            this.IP1 = IP1;
            this.IP2 = IP2;
            this.IP3 = IP3;
            this.ActiveUser = ActiveUser;
        }

        #endregion
    }
}
