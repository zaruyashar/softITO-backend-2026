using System.ComponentModel.DataAnnotations;

namespace LoginApp.ViewModels
{
    public class ChangePasswordViewModel
    {
        [EmailAddress]
        [Required(ErrorMessage = "E-posta girilmesi zorunludur.")]
        public string Email { get; set; }


        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Kullanmak istediğiniz yeni parolayı girin.")]
        [StringLength(40, MinimumLength = 8, ErrorMessage = "Min. 8 karakterden oluşan bir parola girin.")]
        [Compare("ConfirmNewPassword", ErrorMessage = "Girdiğiniz parolalar eşleşmiyor.")]
        public string NewPassword { get; set; }


        [Required(ErrorMessage = "Parola  girilmesi zorunludur.")]
        [DataType(DataType.Password)]
        [Display(Name = "Yeni parola - eşleşme")]
        public string ConfirmNewPassword { get; set; }
    }
}
