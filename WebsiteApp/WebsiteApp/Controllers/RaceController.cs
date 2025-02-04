using Microsoft.AspNetCore.Mvc;

namespace WebsiteApp.Controllers
{
    public class RaceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
