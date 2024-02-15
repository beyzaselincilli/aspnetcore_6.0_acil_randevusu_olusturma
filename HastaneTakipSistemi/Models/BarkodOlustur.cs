    using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HastaneTakipSistemi.Models
{
    public class BarkodOlustur
    {
        
        public int Id { get; set; }

        [MaxLength(50)]
        public string HastaAdi { get; set; }

        [StringLength(11)]
        public string tcNo { get; set; }

        public bool EngelDurumu { get; set; }

        [Required(ErrorMessage ="Bos geçmeyiniz")]
        public int Yas { get; set; }

        public int? BarkodNumarasi { get; set; }

        public string Kod { get; set; }
        public ICollection<HastaYapilanIslemler> hastaYapilanIslemlers { get; set; }

    }
}
