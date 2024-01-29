using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;

namespace AspNetCoreIdentityApp.Web.ViewModels
{
    public class SignUpViewModel
    {
        public SignUpViewModel()
        {
                
        }
        public SignUpViewModel(string userName, string email, string password, string phone)
        {
            UserName = userName;
            Email = email;
            Password = password;
            Phone = phone;
        }
        [Required(ErrorMessage ="Kullanıcı adı alanı boş bırakılamaz")]
        [Display(Name ="Kullanıcı Adı:")]
        public string UserName { get; set; }

        [EmailAddress(ErrorMessage = "Mail formatı yanlıştır")]
        [Required(ErrorMessage = "Mail alanı boş bırakılamaz")]

        [Display(Name = "Email:")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Şifre alanı boş bırakılamaz")]

        [Display(Name = "Şifre:")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Şifre tekrar alanı boş bırakılamaz")]


        [Compare(nameof(Password),ErrorMessage ="Şifreler uyuşmamaktadır.")]
        [Display(Name = "Şifre Tekrar:")]
        public string PasswordConfirm { get; set; }
        [Required(ErrorMessage = "Telefon alanı boş bırakılamaz")]

        [Display(Name = "Telefon:")]
        public string Phone { get; set; }
    }
}
