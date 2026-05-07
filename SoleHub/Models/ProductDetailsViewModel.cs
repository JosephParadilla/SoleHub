namespace SoleHub.Models
{
    public class ProductDetailsViewModel
    {
        public Product Product { get; set; } = new Product();

        public List<string> AvailableSizes { get; set; } = new List<string>();

        public List<string> UnavailableSizes { get; set; } = new List<string>();
    }
}