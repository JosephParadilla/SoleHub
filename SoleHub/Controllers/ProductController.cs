using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SoleHub.Data;
using SoleHub.Models;

namespace SoleHub.Controllers
{
    public class ProductController : Controller
    {
        private readonly SoleHubDbContext _context;

        public ProductController(SoleHubDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(string? searchString, string? category)
        {
            ViewData["CurrentFilter"] = searchString;
            ViewData["CurrentCategory"] = category;

            var products = _context.Products.AsNoTracking().AsQueryable();

            if (!string.IsNullOrWhiteSpace(searchString))
            {
                string search = searchString.ToLower();
                products = products.Where(product =>
                    product.Name.ToLower().Contains(search) ||
                    product.Brand.ToLower().Contains(search) ||
                    product.Category.ToLower().Contains(search));
            }

            if (!string.IsNullOrWhiteSpace(category))
            {
                string selectedCategory = category.ToLower();
                products = products.Where(product =>
                    product.Category.ToLower() == selectedCategory);
            }

            return View(await products.ToListAsync());
        }

        public async Task<IActionResult> Details(int id)
        {
            var product = await _context.Products
                .AsNoTracking()
                .FirstOrDefaultAsync(p => p.Id == id);

            if (product == null)
            {
                return NotFound();
            }

            var viewModel = new ProductDetailsViewModel
            {
                Product = product,
                AvailableSizes = new List<string>
                {
                    "6.0", "6.5", "7.0", "7.5", "8.0", "8.5",
                    "9.0", "9.5", "10.0", "10.5", "11.0", "12.0"
                },
                UnavailableSizes = new List<string>
                {
                    "11.5", "12.5", "13.0", "14.0"
                }
            };

            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> AddToCart(int id, string size)
        {
            int? userId = HttpContext.Session.GetInt32("UserId");

            if (userId == null)
            {
                TempData["Message"] = "Please login to add items to your cart.";
                return RedirectToAction("Login", "Auth");
            }

            if (string.IsNullOrWhiteSpace(size))
            {
                TempData["Message"] = "Please select a shoe size.";
                return RedirectToAction("Details", new { id = id });
            }

            var product = await _context.Products.FindAsync(id);

            if (product == null)
            {
                return NotFound();
            }

            var existingCartItem = await _context.CartItems
                .FirstOrDefaultAsync(cartItem =>
                    cartItem.UserProfileId == userId.Value &&
                    cartItem.ProductId == id &&
                    cartItem.Size == size);

            if (existingCartItem == null)
            {
                var cartItem = new CartItem
                {
                    UserProfileId = userId.Value,
                    ProductId = product.Id,
                    Quantity = 1,
                    Size = size
                };

                _context.CartItems.Add(cartItem);
            }
            else
            {
                existingCartItem.Quantity++;
            }

            await _context.SaveChangesAsync();

            TempData["Message"] = $"{product.Name} Size {size} added to cart.";

            return RedirectToAction("Index", "Cart");
        }
    }
}