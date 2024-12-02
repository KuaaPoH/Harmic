using Microsoft.AspNetCore.Mvc;

namespace Harmic.Areas.Admin.Controllers
{
    public class FileManagerController : Controller
    {
        [Area("Admin")]
        [Route("/Admin/FileManager/Index")]
        public IActionResult Index()
        {
            return View();
        }
    }
}