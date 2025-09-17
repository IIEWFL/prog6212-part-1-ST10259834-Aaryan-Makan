using Microsoft.AspNetCore.Mvc;

namespace prog_part_1.Controllers
{
    public class DocumentsController : Controller
    {
        public IActionResult Index() => View();     // uploads list (mock)
        public IActionResult Upload() => View();    // upload mock
    }
}
