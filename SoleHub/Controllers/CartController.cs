using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SoleHub.Data;
using SoleHub.Models;

namespace SoleHub.Controllers
{
    public class CartController : Controller
    {
        private readonly SoleHubDbContext _context;

        public CartController(SoleHubDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            int? userId = HttpContext.Session.GetInt32("UserId");

            if (userId == null)
            {
                return RedirectToAction("Login", "Auth");
            }

            var cart = await GetCartItemsAsync(userId.Value);

            return View(cart);
        }

        public async Task<IActionResult> Remove(int id)
        {
            int? userId = HttpContext.Session.GetInt32("UserId");

            if (userId == null)
            {
                return RedirectToAction("Login", "Auth");
            }

            var cartItem = await _context.CartItems
                .FirstOrDefaultAsync(item =>
                    item.UserProfileId == userId.Value &&
                    item.ProductId == id);

            if (cartItem != null)
            {
                _context.CartItems.Remove(cartItem);
                await _context.SaveChangesAsync();

                TempData["Message"] = "Item removed from cart.";
            }

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Clear()
        {
            int? userId = HttpContext.Session.GetInt32("UserId");

            if (userId == null)
            {
                return RedirectToAction("Login", "Auth");
            }

            var cartItems = await _context.CartItems
                .Where(item => item.UserProfileId == userId.Value)
                .ToListAsync();

            _context.CartItems.RemoveRange(cartItems);

            await _context.SaveChangesAsync();

            TempData["Message"] = "Cart cleared.";

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Checkout()
        {
            int? userId = HttpContext.Session.GetInt32("UserId");

            if (userId == null)
            {
                return RedirectToAction("Login", "Auth");
            }

            var cart = await GetCartItemsAsync(userId.Value);

            return View(cart);
        }

        [HttpPost]
        public async Task<IActionResult> ProcessPayment(
            string fullName,
            string contactNumber,
            string email,
            string courier,
            string province,
            string city,
            string barangay,
            string streetAddress,
            string paymentMethod)
        {
            int? userId = HttpContext.Session.GetInt32("UserId");

            if (userId == null)
            {
                return RedirectToAction("Login", "Auth");
            }

            var cart = await GetCartItemsAsync(userId.Value);

            if (cart.Count == 0)
            {
                TempData["Message"] = "Your cart is empty.";
                return RedirectToAction("Index", "Product");
            }

            decimal subtotal = cart.Sum(item => item.LineTotal);
            decimal shippingFee = subtotal >= 3000 ? 0 : 80;

            var order = new Order
            {
                UserProfileId = userId.Value,
                OrderNumber = "SH-" + DateTime.Now.ToString("yyyyMMddHHmmss"),
                OrderDate = DateTime.Now,
                CustomerName = fullName,
                ContactNumber = contactNumber,
                Email = email,
                Courier = courier,
                Province = province,
                City = city,
                Barangay = barangay,
                StreetAddress = streetAddress,
                PaymentMethod = paymentMethod,
                ShippingFee = shippingFee,
                Status = "Processing",
                Items = cart.Select(item => new OrderItem
                {
                    ProductName = item.Product?.Name ?? "",
                    Brand = item.Product?.Brand ?? "",
                    Size = item.Size,
                    Price = item.Product?.Price ?? 0,
                    Quantity = item.Quantity
                }).ToList()
            };

            _context.Orders.Add(order);
            _context.CartItems.RemoveRange(cart);

            await _context.SaveChangesAsync();

            TempData["Success"] = "Purchase successful! Your order has been saved.";

            return RedirectToAction("OrderHistory");
        }

        public async Task<IActionResult> OrderHistory()
        {
            int? userId = HttpContext.Session.GetInt32("UserId");

            if (userId == null)
            {
                return RedirectToAction("Login", "Auth");
            }

            string role = HttpContext.Session.GetString("Role") ?? "";

            var ordersQuery = _context.Orders
                .Include(order => order.Items)
                .Include(order => order.UserProfile)
                .AsQueryable();

            if (role != "Admin")
            {
                ordersQuery = ordersQuery.Where(order => order.UserProfileId == userId.Value);
            }

            var orders = await ordersQuery
                .OrderByDescending(order => order.OrderDate)
                .ToListAsync();

            return View(orders);
        }

        private async Task<List<CartItem>> GetCartItemsAsync(int userId)
        {
            return await _context.CartItems
                .Include(item => item.Product)
                .Where(item => item.UserProfileId == userId)
                .ToListAsync();
        }
    }
}