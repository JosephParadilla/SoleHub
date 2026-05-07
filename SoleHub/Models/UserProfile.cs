using System.ComponentModel.DataAnnotations;

namespace SoleHub.Models
{
    public class UserProfile
    {
        public int Id { get; set; }

        [Required]
        public string FullName { get; set; } = "";

        [Required]
        public string Email { get; set; } = "";

        [Required]
        public string Address { get; set; } = "";

        public string ProfilePictureUrl { get; set; } = "";
    }
}