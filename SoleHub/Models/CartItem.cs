using System.ComponentModel.DataAnnotations.Schema;

namespace SoleHub.Models
{
    public class CartItem
    {
        public int Id { get; set; }

        public int UserProfileId { get; set; }

        public UserProfile? UserProfile { get; set; }

        public int ProductId { get; set; }

        public Product? Product { get; set; }

        public int Quantity { get; set; }
        public string Size { get; set; } = "";

        [NotMapped]
        public string Name
        {
            get
            {
                return Product?.Name ?? "";
            }
        }

        [NotMapped]
        public string Brand
        {
            get
            {
                return Product?.Brand ?? "";
            }
        }

        [NotMapped]
        public decimal Price
        {
            get
            {
                return Product?.Price ?? 0;
            }
        }

        [NotMapped]
        public string ImageUrl
        {
            get
            {
                return Product?.ImageUrl ?? "";
            }
        }

        [NotMapped]
        public decimal LineTotal
        {
            get
            {
                return Price * Quantity;
            }
        }
    }
}