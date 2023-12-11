using Microsoft.AspNetCore.Mvc;

namespace EMSWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class PhotoController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
