using Microsoft.AspNetCore.Mvc;

namespace prog_part_1.Controllers
{
    public class ApprovalsController : Controller
    {
        public IActionResult Index() => View();     // queue view (mock)
        public IActionResult Review() => View();    // approve/reject mock
    }
}
