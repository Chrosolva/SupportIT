using System;

namespace SupportIT.Model.ReadModels
{
    public class DetailSuratPerbaikanAsOfRow
    {
        public int SPId { get; set; }
        public int NoUrut { get; set; }
        public string KodeInventaris { get; set; }
        public string NamaBarang { get; set; }
        public int Jumlah { get; set; }
        public string Satuan { get; set; }
        public string Keterangan { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }
    }
}
