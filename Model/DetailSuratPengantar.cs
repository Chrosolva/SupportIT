using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Master.Master;
using Inventaris.Model;
using System.Data;
using Master.Controller;
using SupportIT.Model;

namespace SupportIT.Model
{
    public class DetailSuratPengantar
    {
        #region properties

        public string NoSP { get; set; }
        public int NoUrut { get; set; }
        public string KodeInventaris { get; set; }
        public string Uraian { get; set; }
        public int Jumlah { get; set; }
        public string Satuan { get; set; }
        public string Keterangan { get; set; }

        #endregion

        #region constructor

        public DetailSuratPengantar(string NoSP, int NoUrut, string KodeInventaris, string Uraian, int Jumlah, string Satuan, string Keterangan)
        {
            this.NoSP = NoSP;
            this.NoUrut = NoUrut;
            this.KodeInventaris = KodeInventaris;
            this.Uraian = Uraian;
            this.Jumlah = Jumlah;
            this.Satuan = Satuan;
            this.Keterangan = Keterangan;
        }

        #endregion
    }
}
