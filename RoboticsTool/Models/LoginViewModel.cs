using System.ComponentModel.DataAnnotations;

namespace RoboticsTool.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage ="Email Id is required")]
        [Display(Name = "Email")]
        [EmailAddress(ErrorMessage ="Enter valid Email Id")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }

}