using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using DepartmentProject.Entities;
using DepartmentProject.Entities.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace DepartmentProject.Controllers
{
    public class LoginController : Controller
    {   
        DepartmentContext departmentContext = new DepartmentContext();
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(User user)
        {
            var entity = departmentContext.Users.FirstOrDefault(p=>p.UserName == user.UserName && p.Password== user.Password);
            if (entity != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, user.UserName)
                };
                var userIdentity = new ClaimsIdentity(claims, "Login");
                ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
                await HttpContext.SignInAsync(principal);
                return RedirectToAction("Index", "Employee");
            }

            return View();
        }
    }
}
