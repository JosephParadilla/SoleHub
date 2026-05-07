using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SoleHub.Models
{
    public class Order
    {
        public int Id { get; set; }

        public int UserProfileId { get; set; }

        public UserProfile? UserProfile { get; set; }

        [Required]
        public string OrderNumber { get; set; } = "";

        public DateTime OrderDate { get; set; }

        [Required]
        public string CustomerName { get; set; } = "";

        [Required]
        public string ContactNumber { get; set; } = "";

        [Required]
        public string Email { get; set; } = "";

        [Required]
        public string Courier { get; set; } = "";

        [Required]
        public string Province { get; set; } = "";

        [Required]
        public string City { get; set; } = "";

        [Required]
        public string Barangay { get; set; } = "";

        [Required]
        public string StreetAddress { get; set; } = "";

        [Required]
        public string PaymentMethod { get; set; } = "";

        public string Status { get; set; } = "Processing";

        public decimal ShippingFee { get; set; }

        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        [NotMapped]
        public string FullAddress
        {
            get
            {
                return $"{StreetAddress}, {Barangay}, {City}, {Province}, Philippines";
            }
        }

        [NotMapped]
        public decimal Subtotal
        {
            get
            {
                return Items.Sum(item => item.LineTotal);
            }
        }

        [NotMapped]
        public decimal Total
        {
            get
            {
                return Subtotal + ShippingFee;
            }
        }
    }
}