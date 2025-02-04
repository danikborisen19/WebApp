using Microsoft.AspNetCore.Mvc;

namespace WebsiteApp.Controllers
{
    public class ClubController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
