using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SoleHub.Data;
using SoleHub.Models;

namespace SoleHub.Controllers
{
    public class AuthController : Controller
    {
        private readonly SoleHubDbContext _context;

        public AuthController(SoleHubDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Login()
        {
            if (HttpContext.Session.GetInt32("UserId") != null)
            {
                return RedirectToAction("Index", "Product");
            }

            return View(new LoginViewModel());
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var user = await _context.UserAccounts
                .FirstOrDefaultAsync(account =>
                    account.Username == model.Username &&
                    account.Password == model.Password);

            if (user == null)
            {
                ViewBag.Error = "Invalid username or password.";
                return View(model);
            }

            HttpContext.Session.SetInt32("UserId", user.Id);
            HttpContext.Session.SetString("FullName", user.FullName);
            HttpContext.Session.SetString("Username", user.Username);
            HttpContext.Session.SetString("Role", user.Role);

            return RedirectToAction("Index", "Product");
        }

        [HttpGet]
        public IActionResult Register()
        {
            if (HttpContext.Session.GetInt32("UserId") != null)
            {
                return RedirectToAction("Index", "Product");
            }

            return View(new RegisterViewModel());
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            bool usernameExists = await _context.UserAccounts
                .AnyAsync(u => u.Username == model.Username);

            if (usernameExists)
            {
                ViewBag.Error = "Username already exists.";
                return View(model);
            }

            bool emailExists = await _context.UserProfiles
                .AnyAsync(u => u.Email == model.Email);

            if (emailExists)
            {
                ViewBag.Error = "Email already exists.";
                return View(model);
            }

            var userAccount = new UserAccount
            {
                FullName = model.FullName,
                Username = model.Username,
                Password = model.Password,
                Role = "Customer"
            };

            _context.UserAccounts.Add(userAccount);
            await _context.SaveChangesAsync();

            var userProfile = new UserProfile
            {
                FullName = model.FullName,
                Email = model.Email,
                Address = "Philippines",
                ProfilePictureUrl = ""
            };

            _context.UserProfiles.Add(userProfile);
            await _context.SaveChangesAsync();

            HttpContext.Session.SetInt32("UserId", userProfile.Id);
            HttpContext.Session.SetString("FullName", userProfile.FullName);
            HttpContext.Session.SetString("Username", userAccount.Username);
            HttpContext.Session.SetString("Role", userAccount.Role);

            TempData["Success"] = "Registration successful!";

            return RedirectToAction("Index", "Product");
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }
    }
}