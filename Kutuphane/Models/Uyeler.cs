using System.ComponentModel.DataAnnotations;

namespace Kutuphane.Models
{
    public class Uyeler
    {
        [Key]
        public int UyeId { get; set; }

        public string ?Ad { get; set; }

        public string? Soyad { get; set; }

        public string? Email { get; set; }

        public string? Telefon { get; set; }

        public string? Adres { get; set; }

        public DateTime ? KayitTarihi { get; set; }

        public virtual ICollection<Odunc> ? Oduncler { get; set; }

    }
}
