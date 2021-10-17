using System.Net;
using System.Security.Claims;
using System.Threading.Tasks;
using ASPLesson.Domain.Dto;
using ASPLesson.Domain.Entity;
using ASPLesson.Domain.Enum;
using ASPLesson.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace ASPLesson.Controllers
{
    public class LoginController : Controller
    {
        private readonly ILoginService _loginService;

        public LoginController(ILoginService loginService)
        {
            _loginService = loginService;
        }

        [HttpGet]
        public IActionResult Register() => View();
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterViewModel userModel)
        {
            if (ModelState.IsValid)
            {
                var response = await _loginService.Register(userModel);
                if (response.StatusCode == ErrorCode.OK)
                {
                    return RedirectToAction("SuccessRegistration");
                }
            }
            return View();
        }

        public async Task<IActionResult> Login(LoginViewModel userModel)
        {
            if (ModelState.IsValid)
            {
                var response = await _loginService.Login(userModel);
                if (response.StatusCode == ErrorCode.OK)
                {
                    return View();
                }
            }
            return View();
        }
        
        public async Task Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
        }

        public IActionResult SuccessRegistration() => View();
    }
}