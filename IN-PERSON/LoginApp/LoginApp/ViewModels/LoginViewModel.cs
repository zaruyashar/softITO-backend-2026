using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LoginApp.ViewModels
{
    public class LoginViewModel
    {
        [EmailAddress]
        [Required(ErrorMessage = "E-posta girilmesi zorunludur.")]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Parola girilmesi zorunludur.")]
        public string Password { get; set; }

        [Display(Name = "Hatırla")]
        public bool RememberMe { get; set; }
    }
}
