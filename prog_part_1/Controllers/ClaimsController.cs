using Microsoft.AspNetCore.Mvc;

namespace prog_part_1.Controllers
{
    public class ClaimsController : Controller
    {
        public IActionResult Index() => View();     // list + CTA
        public IActionResult Create() => View();    // submit claim form (mock)
        public IActionResult Details() => View();   // read-only mock
    }
}
