using System.ComponentModel.DataAnnotations;

namespace AuthPractice.Models
{
    public class User
    {
        public string Id { get; set; }
        [Required, MinLength(2, ErrorMessage = "MinLength is 2")]
        [Display(Name = "Username")]
        public string UserName { get; set; }
        [Required, EmailAddress]
        public string Email { get; set; }
        [DataType(DataType.Password), Required, MinLength(4, ErrorMessage = "MinLength is 4")]
        public string Password { get; set; }
    }
}
