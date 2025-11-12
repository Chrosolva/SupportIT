using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventaris.Model
{
    public class BatasInventaris
    {
        #region properties

        public string KodeBagian { get; set; }
        public string KodeKategori { get; set; }
        public string KodeKebun { get; set; }
        public int JumlahMax { get; set; }
        public string Keterangan { get; set; }

        #endregion

        #region Constructor

        public BatasInventaris(string KodeBagian, string KodeKategori, string KodeKebun, int JumlahMax, string Keterangan)
        {
            this.KodeBagian = KodeBagian;
            this.KodeKategori = KodeKategori;
            this.KodeKebun = KodeKebun;
            this.JumlahMax = JumlahMax;
            this.Keterangan = Keterangan;
        }

        #endregion
    }
}
