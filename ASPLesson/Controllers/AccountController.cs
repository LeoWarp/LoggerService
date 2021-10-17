using System.Net;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using ASPLesson.Domain.Entity;
using ASPLesson.Domain.Enum;
using ASPLesson.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Authorization;

namespace ASPLesson.Controllers
{
    // [Authorize]
    public class AccountController : Controller
    {
        private readonly IUserService _userService;

        public AccountController(IUserService userService)
        {
            _userService = userService;
        }
        
        [HttpGet]
        public async Task<IActionResult> GetAllUsers()
        {
            var response = await _userService.GetAllUsers();
            if (response.StatusCode == ErrorCode.OK)
            {
                return View(response.Data);
            }
            return BadRequest(response);
        }

        [HttpGet]
        public async Task<IActionResult> GetUser(int id)
        {
            id = 10;
            var response = await _userService.GetUser(id);
            if (response.StatusCode == ErrorCode.OK)
            {
                return View(response.Data as User);
            }
            return BadRequest(response);
        }
    }
}
