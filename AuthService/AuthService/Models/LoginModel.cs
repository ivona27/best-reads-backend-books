using System.ComponentModel.DataAnnotations;

namespace AuthService.Models
{
    public class LoginModel
    {
        /// <summary>
        /// login fields
        /// </summary>
        [Required(ErrorMessage = "User Name is required")]
        public string? Username { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string? Password { get; set; }
    }
}
