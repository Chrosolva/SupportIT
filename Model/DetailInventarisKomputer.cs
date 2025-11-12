using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventaris.Model
{
    public class DetailInventarisKomputer
    {
        #region properties

        public string KodeInventaris { get; set; }
        public DateTime Tgl { get; set; }

        public string Kebun { get; set; }

        public string KodeBagian { get; set; }

        public string Pengguna { get; set; }
        public string Spesifikasi { get; set; }
        public string Kebutuhan { get; set; }
        public string Keterangan { get; set; }
        public string MacAddress1 { get; set; }
        public string MacAddress2 { get; set; }
        public string MacAddress3 { get; set; }
        public string IP1 { get; set; }
        public string IP2 { get; set; }
        public string IP3 { get; set; }

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
