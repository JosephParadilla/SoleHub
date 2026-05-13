using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SoleHub.Models
{
    public class Payment
    {
        [Key]
        public int PaymentId { get; set; }

        [Required]
        public int OrderId { get; set; }

        [Required]
        [StringLength(20)]
        public string PaymentMethod { get; set; } = string.Empty; // "GCash" or "Card"

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Amount { get; set; }

        [Required]
        [StringLength(30)]
        public string Status { get; set; } = "Pending"; // Pending, Completed, Failed

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        // Card-specific (nullable — only filled for card payments)
        [StringLength(100)]
        public string? CardHolderName { get; set; }

        [StringLength(4)] // Store only last 4 digits — never store full card number
        public string? CardLastFour { get; set; }

        [StringLength(10)]
        public string? CardExpiry { get; set; }

        // Navigation property
        [ForeignKey("OrderId")]
        public Order? Order { get; set; }
    }
}