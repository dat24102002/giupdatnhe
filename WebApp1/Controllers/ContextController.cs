using Microsoft.AspNetCore.Mvc;

namespace WebApp1.Controllers
{
    public class ContextController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
