using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.RegisterDto
{
    public class CreateNewUserDto
    {
        [Required(ErrorMessage ="Ad alanı boş geçilemez")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Soyad alanı boş geçilemez")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Kullanıcı Adı alanı boş geçilemez")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Şehir alanı boş geçilemez")]
        public string City { get; set; }

        [Required(ErrorMessage = "Mail alanı boş geçilemez")]
        public string Mail { get; set; }

        [Required(ErrorMessage = "Şifre alanı boş geçilemez")]
        public string Password { get; set; }
        
        [Required(ErrorMessage = "Şifre Tekrar alanı boş geçilemez")]
        [Compare("Password",ErrorMessage ="Şifreler Uyuşmuyor")]
        public string ConfirmPassword { get; set; }
    }
}
