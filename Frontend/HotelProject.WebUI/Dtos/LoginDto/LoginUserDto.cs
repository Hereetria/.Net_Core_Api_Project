using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.LoginDto
{
    public class LoginUserDto
    {
        [Required(ErrorMessage = "Lütfen kullanıcı adı girin")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Lütfen şifre girin")]
        public string Password { get; set; }
    }
}
