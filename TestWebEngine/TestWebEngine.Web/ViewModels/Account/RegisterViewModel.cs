using System.ComponentModel.DataAnnotations;

namespace TestWebEngine.Web.ViewModels.Account
{
    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        [Display(Name = "User Age")]
        public int? Age { get; set; }

        [Display(Name = "Organization")]
        [StringLength(50, ErrorMessage = "The {0} must be at least {2} characters long.")]
        public string Organization { get; set; }

        [Display(Name = "First Name")]
        [StringLength(25, ErrorMessage = "The {0} must be at least {2} characters long.")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [StringLength(35, ErrorMessage = "The {0} must be at least {2} characters long.")]
        public string LastName { get; set; }
    }
}