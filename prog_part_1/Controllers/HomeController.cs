using Microsoft.AspNetCore.Mvc;

namespace prog_part_1.Controllers
{
    public class HomeController : Controller
    {
        // NEW: Landing page
        public IActionResult Home() => View();

        // Existing: Dashboard
        public IActionResult Index() => View();

        public IActionResult About() => View();
    }
}
