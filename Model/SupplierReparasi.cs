using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Master.Controller;

namespace SupportIT.Model
{
    public class SupplierReparasi
    {
        #region properties

        public string KodeSupp { get; set; }
        public string NamaSupp { get; set; }
        public string Alamat { get; set; }
        public string Telp { get; set; }
        public string CP { get; set; }
        public string email { get;set;}

        #endregion

        #region constructor

        public SupplierReparasi(string KodeSupp, string NamaSupp, string Alamat, string Telp, string CP, string email )
        {
            this.KodeSupp = KodeSupp;
            this.NamaSupp = NamaSupp;
            this.Alamat = Alamat;
            this.Telp = Telp;
            this.CP = CP;
            this.email = email;
        }

        #endregion

    }
}
