using System.ComponentModel.DataAnnotations;

namespace Kutuphane.Models
{
    public class Odunc
    {
        [Key]
        public int OduncId { get; set; }

        
        public int ? KitapId { get; set; }

        public int ? UyeId { get; set; }

        public DateTime ? OduncTarihi { get; set; }

        public DateTime ? SonTeslimTarihi { get; set; }

        public DateTime? IadeTarihi { get; set; }

        public bool ?IadeEdildiMi { get; set; }

        public virtual Kitap ? Kitap { get; set; }

        public virtual Uyeler ?Uyeler { get; set; }
    }
}
