using System.ComponentModel.DataAnnotations;

namespace Support.DTOs
{
    public class LoginRequest
    {
        [Required(ErrorMessage = "Username is required")]
        public string username { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Format email invalid")]
        public string email { get; set; }
    }
}
