using System.ComponentModel.DataAnnotations;

namespace SoleHub.Models
{
    public class UserAccount
    {
        public int Id { get; set; }

        [Required]
        public string FullName { get; set; } = "";

        [Required]
        public string Username { get; set; } = "";

        [Required]
        public string Password { get; set; } = "";

        [Required]
        public string Role { get; set; } = "";
    }
}