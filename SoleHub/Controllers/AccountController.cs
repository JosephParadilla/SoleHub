using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SoleHub.Data;
using SoleHub.Models;

namespace SoleHub.Controllers
{
    public class AccountController : Controller
    {
        private readonly SoleHubDbContext _context;

        public AccountController(SoleHubDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Profile()
        {
            int? userId = HttpContext.Session.GetInt32("UserId");

            if (userId == null)
            {
                return RedirectToAction("Login", "Auth");
            }

            var user = await GetCurrentProfileAsync(userId.Value);

            return View(user);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateProfile(UserProfile updatedProfile)
        {
            int? userId = HttpContext.Session.GetInt32("UserId");

            if (userId == null)
            {
                return RedirectToAction("Login", "Auth");
            }

            var user = await GetCurrentProfileAsync(userId.Value);

            user.FullName = updatedProfile.FullName;
            user.Email = updatedProfile.Email;
            user.Address = updatedProfile.Address;

            var account = await _context.UserAccounts.FindAsync(userId.Value);

            if (account != null)
            {
                account.FullName = updatedProfile.FullName;
                HttpContext.Session.SetString("FullName", updatedProfile.FullName);
            }

            await _context.SaveChangesAsync();

            TempData["Success"] = "Profile updated successfully.";

            return RedirectToAction("Profile");
        }

        [HttpPost]
        public async Task<IActionResult> UploadAvatar(IFormFile photo)
        {
            int? userId = HttpContext.Session.GetInt32("UserId");

            if (userId == null)
            {
                return RedirectToAction("Login", "Auth");
            }

            var user = await GetCurrentProfileAsync(userId.Value);

            if (photo != null && photo.Length > 0)
            {
                string[] allowedExtensions =
                {
                    ".jpg",
                    ".jpeg",
                    ".png",
                    ".gif"
                };

                string extension = Path.GetExtension(photo.FileName).ToLower();

                if (!allowedExtensions.Contains(extension))
                {
                    TempData["Error"] = "Only JPG, JPEG, PNG, and GIF files are allowed.";
                    return RedirectToAction("Profile");
                }

                string uploadsFolder = Path.Combine(
                    Directory.GetCurrentDirectory(),
                    "wwwroot",
                    "uploads");

                if (!Directory.Exists(uploadsFolder))
                {
                    Directory.CreateDirectory(uploadsFolder);
                }

                string fileName = Guid.NewGuid().ToString() + extension;
                string filePath = Path.Combine(uploadsFolder, fileName);

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await photo.CopyToAsync(stream);
                }

                user.ProfilePictureUrl = "/uploads/" + fileName;

                await _context.SaveChangesAsync();

                TempData["Success"] = "Profile picture uploaded successfully.";
            }

            return RedirectToAction("Profile");
        }

        private async Task<UserProfile> GetCurrentProfileAsync(int userId)
        {
            var user = await _context.UserProfiles
                .FirstOrDefaultAsync(profile => profile.Id == userId);

            if (user == null)
            {
                user = new UserProfile
                {
                    Id = userId,
                    FullName = HttpContext.Session.GetString("FullName") ?? "SoleHub User",
                    Email = "customer@solehub.com",
                    Address = "Cebu City, Philippines",
                    ProfilePictureUrl = ""
                };

                _context.UserProfiles.Add(user);

                await _context.SaveChangesAsync();
            }

            return user;
        }
    }
}