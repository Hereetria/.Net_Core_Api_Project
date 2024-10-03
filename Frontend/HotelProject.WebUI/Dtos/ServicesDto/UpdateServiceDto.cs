using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.ServicesDto
{
    public class UpdateServiceDto
    {
        public int ServiceID { get; set; }

        [Required(ErrorMessage = "Hizmet ikon linki giriniz")]
        public string ServiceIcon { get; set; }

        [Required(ErrorMessage = "Servis başlığı giriniz")]
        [StringLength(100, ErrorMessage = "Servis uzunluğu en fazla 100 karakter olabilir")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Servis açıklaması giriniz")]
        [StringLength(500, ErrorMessage = "Açıklama uzunluğu en fazla 500 karakter olabilir")]
        public string Description { get; set; }
    }
}
