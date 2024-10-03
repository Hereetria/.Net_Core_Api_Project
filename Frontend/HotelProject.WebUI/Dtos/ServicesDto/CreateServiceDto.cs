using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.ServicesDto
{
    public class CreateServiceDto
    {
        [Required(ErrorMessage = "Hizmet ikon linki giriniz")]
        public string ServiceIcon { get; set; }

        [Required(ErrorMessage = "Servis başlığı giriniz")]
        [StringLength(100,ErrorMessage ="Servis uzunluğu en fazla 100 karakter olabilir")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Açıklama giriniz")]
        public string Description { get; set; }
    }
}
