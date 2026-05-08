using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SoleHub.Data;
using SoleHub.Models;

namespace SoleHub.Controllers
{
    public class CartController : Controller
    {
        public async Task<IActionResult> CompleteGCashOrder()
        {
            TempData["Success"] = "GCash payment successful!";
            return RedirectToAction("OrderHistory");
        }

        [HttpPost]
        public async Task<IActionResult> CompleteCardOrder()
        {
            TempData["Success"] = "Card payment successful!";
            return RedirectToAction("OrderHistory");
        }
        public IActionResult GCashPayment()
        {
            return View();
        }

        public IActionResult CardPayment()
        {
            return View();
        }

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

            HttpContext.Session.SetString("FullName", fullName);
            HttpContext.Session.SetString("ContactNumber", contactNumber);
            HttpContext.Session.SetString("Email", email);
            HttpContext.Session.SetString("Courier", courier);
            HttpContext.Session.SetString("Province", province);
            HttpContext.Session.SetString("City", city);
            HttpContext.Session.SetString("Barangay", barangay);
            HttpContext.Session.SetString("StreetAddress", streetAddress);
            HttpContext.Session.SetString("PaymentMethod", paymentMethod);

            if (paymentMethod == "GCash")
            {
                return RedirectToAction("GCashPayment");
            }

            if (paymentMethod == "Credit/Debit Card")
            {
                return RedirectToAction("CardPayment");
            }

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

        [HttpPost]
        public async Task<IActionResult> CancelOrder(int id)
        {
            int? userId = HttpContext.Session.GetInt32("UserId");

            if (userId == null)
            {
                return RedirectToAction("Login", "Auth");
            }

            string role = HttpContext.Session.GetString("Role") ?? "";

            var order = await _context.Orders
                .FirstOrDefaultAsync(o => o.Id == id);

            if (order == null)
            {
                TempData["Error"] = "Order not found.";
                return RedirectToAction("OrderHistory");
            }

            // Prevent cancelling other users' orders
            if (role != "Admin" && order.UserProfileId != userId.Value)
            {
                TempData["Error"] = "Unauthorized action.";
                return RedirectToAction("OrderHistory");
            }

            // Only Processing orders can be cancelled
            if (order.Status != "Processing")
            {
                TempData["Error"] = "Only processing orders can be cancelled.";
                return RedirectToAction("OrderHistory");
            }

            order.Status = "Cancelled";

            await _context.SaveChangesAsync();

            TempData["Success"] = "Order cancelled successfully.";

            return RedirectToAction("OrderHistory");
        }

        [HttpPost]
        public async Task<IActionResult> ClearOrderHistory()
        {
            int? userId = HttpContext.Session.GetInt32("UserId");

            if (userId == null)
            {
                return RedirectToAction("Login", "Auth");
            }

            string role = HttpContext.Session.GetString("Role") ?? "";

            // Admin clears all orders
            if (role == "Admin")
            {
                var allOrders = await _context.Orders
                    .Include(o => o.Items)
                    .ToListAsync();

                _context.OrderItems.RemoveRange(
                    allOrders.SelectMany(o => o.Items)
                );

                _context.Orders.RemoveRange(allOrders);
            }
            else
            {
                // User clears only their own orders
                var userOrders = await _context.Orders
                    .Include(o => o.Items)
                    .Where(o => o.UserProfileId == userId.Value)
                    .ToListAsync();

                _context.OrderItems.RemoveRange(
                    userOrders.SelectMany(o => o.Items)
                );

                _context.Orders.RemoveRange(userOrders);
            }

            await _context.SaveChangesAsync();

            TempData["Success"] = "Order history cleared successfully.";

            return RedirectToAction("OrderHistory");
        }

        [HttpPost]
        public async Task<IActionResult> UpdateQuantity(int cartItemId, int quantity)
        {
            int? userId = HttpContext.Session.GetInt32("UserId");

            if (userId == null)
            {
                return RedirectToAction("Login", "Auth");
            }

            var cartItem = await _context.CartItems
                .FirstOrDefaultAsync(c =>
                    c.Id == cartItemId &&
                    c.UserProfileId == userId.Value);

            if (cartItem == null)
            {
                return RedirectToAction("Index");
            }

            // Limit quantity from 1 to 10
            if (quantity < 1)
            {
                quantity = 1;
            }

            if (quantity > 10)
            {
                quantity = 10;
            }

            cartItem.Quantity = quantity;

            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }
    }
}