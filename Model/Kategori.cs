using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventaris.Model
{
    public class Kategori
    {
        #region properties

        public string KodeKategori { get; set; }
        public string NamaKategori { get; set; }

        #endregion

        #region constructor

        public Kategori(string KodeKategori, string NamaKategori)
        {
            this.KodeKategori = KodeKategori;
            this.NamaKategori = NamaKategori;
        }

        #endregion
    }
}
