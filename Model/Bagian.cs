using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventaris.Model
{
    public class Bagian
    {
        #region properties

        public string KodeBagian { get; set; }
        public string NamaBagian { get; set; }
        public string Asisten { get; set; }
        public string Grup { get; set; }

        #endregion

        #region Constructor

        public Bagian(string KodeBagian, string NamaBagian, string Asisten, string Grup)
        {
            this.KodeBagian = KodeBagian;
            this.NamaBagian = NamaBagian;
            this.Asisten = Asisten;
            this.Grup = Grup;
        }

        #endregion
    }
}
