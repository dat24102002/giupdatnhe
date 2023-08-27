using Microsoft.AspNetCore.Mvc;

namespace WebApp1.Controllers
{
    public class OurController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
