using System.ComponentModel.DataAnnotations;

namespace Login.ModelView
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "You must accept the Remember Me checkbox.")]
        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }
}
