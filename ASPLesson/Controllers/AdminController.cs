using System.Collections.Generic;
using System.Threading.Tasks;
using ASPLesson.Domain.Dto;
using ASPLesson.Domain.Interfaces.Services;
using ASPLesson.Domain.Services.Services;
using Microsoft.AspNetCore.Mvc;

namespace ASPLesson.Controllers
{
    public class AdminController : Controller
    {
        private readonly IUserService _userService;
        private readonly IModelService _modelService;
        
        public AdminController(IUserService userService,
            IModelService modelService)
        {
            _userService = userService;
            _modelService = modelService;
        }

        [HttpGet]
        public IActionResult CreateUser()
        {
            return View();
        }
        
        #region #1

        [HttpPost]
        public async Task<IActionResult> CreateUser([FromForm] CreateUserViewModel userModel)
        {
            if (userModel.Age > 0 && userModel.Age < 130 &&
                userModel.Password == userModel.PasswordConfrim)
            {
                await _userService.AddUser(userModel);
                return Ok($"Пользователь {userModel.Name} добавлен");
            }
            return View();
        }
        
        #endregion
        
        #region #2

        // [HttpPost]
        // public async Task<IActionResult> CreateUser([FromForm] CreateUserViewModel userModel)
        // {
        //     var isValidModel = _modelService.CheckModel(ExpressionModel.NotNull, userModel.Name);
        //     if (ModelState.IsValid)
        //     {
        //         await _userService.AddUser(userModel);
        //         return Ok($"Пользователь {userModel.Name} добавлен");
        //     }
        //     return Ok("Валидация модель прошла проверку");
        // }

        #endregion
        
        #region #3

        // [HttpPost]
        // public async Task<IActionResult> CreateUser([FromForm] CreateUserViewModel userModel)
        // {
        //     var isValidModel = _modelService.CheckModel<CreateUserViewModel>(new Dictionary<string, ExpressionModel>()
        //     {
        //         { userModel.Name, ExpressionModel.NotNull },
        //         { userModel.Age.ToString(), ExpressionModel.Range }
        //     });
        //
        //     if (isValidModel)
        //     {
        //         await _userService.AddUser(userModel);
        //         return Ok($"Пользователь {userModel.Name} добавлен");
        //     }
        //     return BadRequest(false);
        // }

        #endregion

        #region 4

        // [HttpPost]
        // public async Task<IActionResult> CreateUser([FromForm] CreateUserViewModel userModel)
        // {
        //     if (ModelState.IsValid)
        //     {
        //         await _userService.AddUser(userModel);
        //         return Ok($"Пользователь {userModel.Name} добавлен");
        //     }
        //     return View();
        // }

        #endregion
    }
}