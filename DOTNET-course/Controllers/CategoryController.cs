using Microsoft.AspNetCore.Mvc;

namespace DOTNET_course.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
