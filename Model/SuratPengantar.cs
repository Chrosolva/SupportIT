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
    public class SuratPengantar
    {
        #region properties

        public string NoSP { get; set; }
        public DateTime TglSP { get; set; }
        public string Bagian { get; set; }
        public string Kepada { get; set; }
        public string Lokasi { get; set; }



        #endregion

        #region constructor

        public SuratPengantar (string NoSP, DateTime TglSP, string Bagian , string Kepada , string Lokasi)
        {
            this.NoSP = NoSP;
            this.TglSP = TglSP;
            this.Bagian = Bagian;
            this.Kepada = Kepada;
            this.Lokasi = Lokasi;
        }

        #endregion
    }
}
