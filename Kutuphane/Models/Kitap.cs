using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kutuphane.Models
{
    public class Kitap
    {
        [Key]
        public int KitapId { get; set; }

        public string ?KitapAdi { get; set; }

        public string ISBN { get; set; } = string.Empty;

        public int ? SayfaSayisi { get; set; }

        public int StokAdedi { get; set; }
        [ForeignKey("Yazarlar")]
        public int YazarId { get; set; }
        [ForeignKey("Kategoriler")]
        public int KategoriId { get; set; }

        public virtual Yazarlar? Yazar { get; set; }

        public virtual Kategoriler? Kategori { get; set; }

        public virtual ICollection<Odunc>? Oduncler { get; set; }


    }
}
