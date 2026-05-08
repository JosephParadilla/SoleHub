using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SoleHub.Data;
using SoleHub.Models;

namespace SoleHub.Controllers
{
    public class WishlistController : Controller
    {
        private readonly SoleHubDbContext _context;

        public WishlistController(SoleHubDbContext context)
        {
            _context = context;
        }

        // GET: /Wishlist
        public async Task<IActionResult> Index()
        {
            string? username = HttpContext.Session.GetString("Username");
            if (string.IsNullOrEmpty(username))
                return RedirectToAction("Login", "Auth");

            var wishlistItems = await _context.WishlistItems
                .Include(w => w.Product)
                .Where(w => w.Username == username)
                .OrderByDescending(w => w.AddedAt)
                .ToListAsync();

            return View(wishlistItems);
        }

        // POST: /Wishlist/Toggle
        [HttpPost]
        public async Task<IActionResult> Toggle(int id)
        {
            string? username = HttpContext.Session.GetString("Username");
            if (string.IsNullOrEmpty(username))
                return Json(new { success = false, message = "Not logged in" });

            var existing = await _context.WishlistItems
                .FirstOrDefaultAsync(w => w.Username == username && w.ProductId == id);

            bool isWishlisted;

            if (existing != null)
            {
                _context.WishlistItems.Remove(existing);
                isWishlisted = false;
            }
            else
            {
                _context.WishlistItems.Add(new WishlistItem
                {
                    Username = username,
                    ProductId = id,
                    AddedAt = DateTime.Now
                });
                isWishlisted = true;
            }

            await _context.SaveChangesAsync();
            return Json(new { success = true, isWishlisted });
        }

        // POST: /Wishlist/Remove
        [HttpPost]
        public async Task<IActionResult> Remove(int id)
        {
            string? username = HttpContext.Session.GetString("Username");
            if (string.IsNullOrEmpty(username))
                return RedirectToAction("Login", "Auth");

            var item = await _context.WishlistItems
                .FirstOrDefaultAsync(w => w.WishlistItemId == id && w.Username == username);

            if (item != null)
            {
                _context.WishlistItems.Remove(item);
                await _context.SaveChangesAsync();
            }

            return RedirectToAction("Index");
        }

        // POST: /Wishlist/ClearHistory
        [HttpPost]
        public async Task<IActionResult> ClearHistory()
        {
            string? username = HttpContext.Session.GetString("Username");
            if (string.IsNullOrEmpty(username))
                return RedirectToAction("Login", "Auth");

            var items = _context.WishlistItems
                .Where(w => w.Username == username);

            _context.WishlistItems.RemoveRange(items);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }
    }
}