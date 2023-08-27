using Microsoft.AspNetCore.Mvc;

namespace WebApp1.Controllers
{
    public class NewsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
