//using Microsoft.AspNetCore.Authentication.Cookies;
//using Microsoft.AspNetCore.Authentication;
//using Microsoft.AspNetCore.Mvc;
//using System.Security.Claims;
//using TekInternsRecord.Models;

//namespace TekInternsRecord.Controllers
//{
//    public class AccountController : Controller
//    {
//        [HttpGet]
//        public IActionResult Login()
//        {
//            return View();
//        }

//        [HttpPost]
//        public async Task<IActionResult> Login(string username, string password)
//        {
//            var user = StaticUserData.ValidateUser(username, password);
//            if (user != null)
//            {
//                var claims = new List<Claim>
//                {
//                    new Claim(ClaimTypes.Name, user.Username),
//                    new Claim(ClaimTypes.Role, user.Role)
//                };

//                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
//                var authProperties = new AuthenticationProperties
//                {
//                    IsPersistent = true
//                };

//                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity), authProperties);

//                return RedirectToAction("Index", "Home");
//            }

//            ViewBag.Error = "Invalid login attempt.";
//            return View();
//        }

//        public async Task<IActionResult> Logout()
//        {
//            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
//            return RedirectToAction("Login");
//        }

//        public IActionResult AccessDenied()
//        {
//            return View();
//        }
//    }
//}
