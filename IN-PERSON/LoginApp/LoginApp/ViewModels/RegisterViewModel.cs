using System.ComponentModel.DataAnnotations;

namespace LoginApp.ViewModels
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Ad girilmesi zorunludur.")]
        public string Name { get; set; }


        [EmailAddress]
        [Required(ErrorMessage = "E-posta girilmesi zorunludur.")]
        public string Email { get; set; }


        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Kullanmak istediğiniz yeni parolayı girin.")]
        [StringLength(40, MinimumLength = 8, ErrorMessage = "Min. 8 karakterden oluşan bir parola girin.")]
        [Compare("ConfirmPassword", ErrorMessage = "Girdiğiniz parolalar eşleşmiyor.")]
        public string Password { get; set; }


        [Required(ErrorMessage = "Parola  girilmesi zorunludur.")]
        [DataType(DataType.Password)]
        [Display(Name = "Yeni parola - eşleşme")]
        public string ConfirmPassword { get; set; }
    }
}
