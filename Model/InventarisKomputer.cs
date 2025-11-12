using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventaris.Model
{
    public class InventarisKomputer
    {
        #region properties

        public string KodeInventaris { get; set; }
        public string KodeKategori { get; set; }
        public string KodeKebun { get; set; }
        public bool Aktif { get; set; }
        public string NoPO { get; set; }
        public DateTime TglBeli { get; set; }

        public string NamaBarang { get; set; }
        public string Status { get; set; }
        public string KodeInvLama { get; set; }
        public string KodePT { get; set; }
        public string KeteranganAfkir { get; set; }


        #endregion

        #region Constructor

        public InventarisKomputer(string KodeInventaris, string KodeKategori, string KodeKebun, bool Aktif, string NoPO, DateTime TglBeli,string NamaBarang, string Status, string KodeInvLama)
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

        public InventarisKomputer(string KodeInventaris, string KodeKategori, string KodeKebun, bool Aktif, string NoPO, DateTime TglBeli, string NamaBarang, string Status, string KodeInvLama, string KodePT, string KeteranganAfkir)
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
