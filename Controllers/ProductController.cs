using Microsoft.AspNetCore.Mvc;

namespace za_ocenka.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
