using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HastaneTakipSistemi.Models
{
    public class HastaYapilanIslemler
    {
        [Key]
        public int Id { get; set; }

        [Display(Name ="Giriş Saati")]
        public DateTime giris { get; set; }
        [Display(Name = "Çıkış Saati")]

        public DateTime cikis { get; set; }

        [Display(Name ="Tedavi Açıklaması")]
        public string tedaviAciklamasi { get; set; }

        [ForeignKey("BarkodOlustur")]
        public int barkodOlusturId { get; set; }
        public BarkodOlustur barkodOlustur { get; set; }
    }
}
