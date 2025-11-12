using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupportIT.Model
{
    public class DetailTandaTerima
    {
        #region properties

        public string IDTT { get; set; }
        public int NoUrutItem { get; set; }
        public string KodeInventris { get; set; }

        
        public string NamaBarang { get; set; }
        public decimal BiayaPerbaikan { get; set; }
        public DateTime TanggalSelesai { get; set; }
        public string Keterangan { get; set; }


        #endregion

        #region constructor

        public DetailTandaTerima()
        {

        }

        public DetailTandaTerima(string IDTT, string KodeInventaris , string NamaBarang, decimal BiayaPerbaikan, DateTime TanggalSelesai , string Keterangan)
        {
            this.IDTT = IDTT;
            this.KodeInventris = KodeInventaris;
            this.NamaBarang = NamaBarang;
            this.BiayaPerbaikan = BiayaPerbaikan;
            this.TanggalSelesai = TanggalSelesai;
            this.Keterangan = Keterangan;
        }

        public DetailTandaTerima(string IDTT, int NoUrutItem, string KodeInventaris, string NamaBarang, decimal BiayaPerbaikan, DateTime TanggalSelesai, string Keterangan)
        {
            this.IDTT = IDTT;
            this.NoUrutItem = NoUrutItem;
            this.KodeInventris = KodeInventaris;
            this.NamaBarang = NamaBarang;
            this.BiayaPerbaikan = BiayaPerbaikan;
            this.TanggalSelesai = TanggalSelesai;
            this.Keterangan = Keterangan;
        }

        #endregion

    }
}
