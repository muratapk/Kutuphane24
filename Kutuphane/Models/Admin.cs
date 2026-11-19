using System.ComponentModel.DataAnnotations;

namespace Kutuphane.Models
{
    public class Admin
    {
        [Key]
        public int AdminId { get; set; }

        [Required(ErrorMessage = "Kullanıcı adı zorunludur.")]
        [Display(Name = "Kullanıcı Adı")]
        public string KullaniciAdi { get; set; }
        
        [Required(ErrorMessage = "Şifre zorunludur.")]
        [Display(Name = "Şifre")]
        public string SifreHash { get; set; }
        [Required(ErrorMessage = "Ad ve soyad zorunludur.")]
        [Display(Name = "Ad ve Soyad")]
        public string AdSoyad { get; set; }
    }
}
