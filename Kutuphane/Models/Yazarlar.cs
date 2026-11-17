namespace Kutuphane.Models
{
    public class Yazarlar
    {
        public int YazarId { get; set; }

        public string Ad { get; set; }

        public string Soyad { get; set; }

        public string Ulke { get; set; }

        public virtual ICollection<Kitap> Kitaplar { get; set; }


    }
}
