using System.ComponentModel.DataAnnotations;

namespace LoginApp.ViewModels
{
    public class VerifyEmailViewModel
    {
        [EmailAddress]
        [Required(ErrorMessage = "E-posta girilmesi zorunludur.")]
        public string Email { get; set; }
    }
}
