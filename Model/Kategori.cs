using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace SupportIT.Model
{
    [Table("TblKategori", Schema = "Master")]
    public class Kategori
    {
        #region properties

        [Key]
        [MaxLength(2)]
        public string KodeKategori { get; set; }

        [MaxLength(50)]
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
