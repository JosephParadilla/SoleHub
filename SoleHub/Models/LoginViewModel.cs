using System.ComponentModel.DataAnnotations;

namespace SoleHub.Models
{
    public class LoginViewModel
    {
        [Required]
        public string Username { get; set; } = "";

        [Required]
        public string Password { get; set; } = "";
    }
}