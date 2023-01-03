using Microsoft.AspNetCore.Mvc;

namespace A_MvcProje_UI.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
