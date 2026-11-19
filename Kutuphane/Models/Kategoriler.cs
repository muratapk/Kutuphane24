using System.ComponentModel.DataAnnotations;

namespace Kutuphane.Models
{
    public class Kategoriler
    {
        [Key]
        public int KategoriId { get; set; }

        public string ? KategoriAdi { get; set; }

        public string ? Aciklama { get; set; }

        public virtual ICollection<Kitap> ? Kitaplar { get; set; }
    }
}
