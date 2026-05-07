using System.ComponentModel.DataAnnotations;

namespace SoleHub.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = "";

        [Required]
        public string Brand { get; set; } = "";

        [Required]
        public string Category { get; set; } = "";

        public decimal Price { get; set; }

        public string ImageUrl { get; set; } = "";
    }
}