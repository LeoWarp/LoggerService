using Microsoft.AspNetCore.Mvc;

namespace ASPLesson.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
