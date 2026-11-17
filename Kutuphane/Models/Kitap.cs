namespace Kutuphane.Models
{
    public class Kitap
    {
        public int KitapId { get; set; }

        public string KitapAdi { get; set; }

        public string ISBN { get; set; }

        public int SayfaSayisi { get; set; }

        public int StokAdedi { get; set; }

        public int YazarId { get; set; }

        public int KategoriId { get; set; }

        public virtual Yazar Yazar { get; set; }

        public virtual Kategori Kategori { get; set; }

        public virtual ICollection<Odunc> Oduncler { get; set; }


    }
}
