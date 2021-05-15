using System.ComponentModel.DataAnnotations;

namespace Support.DTOs
{
    public class LoginRequest
    {
        [Required(ErrorMessage = "Username is required")]
        public string username { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [StringLength(10, ErrorMessage = "Must be between {0} and {1} characters", MinimumLength = 5)]
        [DataType(DataType.Password)]
        public string password { get; set; }
    }
}
