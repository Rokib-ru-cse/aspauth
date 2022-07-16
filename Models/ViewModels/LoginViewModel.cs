using System.ComponentModel.DataAnnotations;

namespace AuthPractice.Models.ViewModels
{
    public class LoginViewModel
    {
        [Required, MinLength(2, ErrorMessage = "MinLength is 2")]
        [Display(Name = "Username")]
        public string UserName { get; set; }
        [DataType(DataType.Password), Required, MinLength(4, ErrorMessage = "MinLength is 4")]
        public string Password { get; set; }

        public string? ReturnUrl { get; set; }
    }
}
