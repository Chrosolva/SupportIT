using System;

namespace SupportIT.Model.ReadModels
{
    public class SuratPerbaikanHistoryRow
    {
        public int SPId { get; set; }
        public string NoSP { get; set; }
        public DateTime TglSP { get; set; }
        public string Kepada { get; set; }
        public string Lokasi { get; set; }
        public string Status { get; set; }
        public string PIC { get; set; }
        public string KodePT { get; set; }
        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }
    }
}
