using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace MVCSeguridadPersonalizada.Controllers
{
    public class ManagerControlelr : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            return View();
        }
        [HttpPost]
        Login(string username, string password)
        {
            if (username.ToLower() == "admin" && password.ToLower() == "admin")
            {
                ClaimsIdentity identity = new ClaimsIdentity(CookieAuthenticationDefaults.AuthenticationScheme, ClaimTypes.Name, ClaimTypes.Role);
                Claim userName = new Claim(ClaimTypes.Name, username);
                Claim role = new Claim(ClaimTypes.Role, "USUARIO");
                identity.AddClaim(userName);
                identity.AddClaim(role);
                ClaimsPrincipal userPrincipal =
                    new ClaimsPrincipal(identity);
                await HttpContext.SignInAsync
                    (CookieAuthenticationDefaults.AuthenticationScheme
                    , userPrincipal
                    , new AuthenticationProperties
                    {
                        ExpiresUtc = DateTime.Now.AddMinutes(15)
                    });
            }
        }
    }
}
