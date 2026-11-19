using System.ComponentModel.DataAnnotations;

namespace Kutuphane.Models
{
    public class Yazarlar
    {
        [Key]
        public int YazarId { get; set; }

        public string ? Ad  { get; set; }

        public string Soyad { get; set; } = string.Empty;

        public string? Ulke { get; set; }

        public virtual ICollection<Kitap>? Kitaplar { get; set; }


    }
}
