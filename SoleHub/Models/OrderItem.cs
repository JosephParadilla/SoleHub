using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SoleHub.Models
{
    public class OrderItem
    {
        public int Id { get; set; }

        public int OrderId { get; set; }

        public Order? Order { get; set; }

        [Required]
        public string ProductName { get; set; } = "";

        [Required]
        public string Brand { get; set; } = "";

        public decimal Price { get; set; }

        public int Quantity { get; set; }

        public string Size { get; set; } = "";

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