using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventaris.Model
{
    public class Kebun
    {

        #region properties

        public string KodeKebun { get; set; }
        public string NamaKebun { get; set; }
        public string Alamat { get; set; }
        public string NamaSingkat { get; set; }
        public string Kota { get; set; }
        public string KodePos { get; set; }
        public string Telp { get; set; }
        public string Fax { get; set; }
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
