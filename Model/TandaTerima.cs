using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupportIT.Model
{
    public class TandaTerima
    {
        #region properties

        public string IDTT { get; set; }
        public string KodeSupp { get; set; }
        public string NamaSupp { get; set; }
        public DateTime TanggalPengajuan { get; set; }
        public decimal TotalBiaya { get; set; }
        public string Keterangan { get; set; }



        #endregion

        #region constructor

        public TandaTerima()
        {

        }

        public TandaTerima(string IDtt, string KodeSupp, string namasupp, DateTime TanggalPengajuan, decimal totalbiaya, string Keterangan)
        {
            this.IDTT = IDtt;
            this.KodeSupp = KodeSupp;
            this.NamaSupp = namasupp;
            this.TanggalPengajuan = TanggalPengajuan;
            this.TotalBiaya = totalbiaya;
            this.Keterangan = Keterangan;
        }

        #endregion
    }
}
