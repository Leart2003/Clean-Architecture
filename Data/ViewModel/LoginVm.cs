using System.ComponentModel.DataAnnotations;

namespace ShortUrl.Data.ViewModel
{
    public class LoginVm
    {
        [Required(ErrorMessage ="Email adress is required")]
        [EmailAddress(ErrorMessage ="Invalid email adress")]
        public string EmailAddress { get; set; }

        [Required(ErrorMessage ="Password is requried")]
        [MinLength(8, ErrorMessage =("Password must be atleast 8 characters"))]
        public string Password { get; set; } = string.Empty;
    }
}
