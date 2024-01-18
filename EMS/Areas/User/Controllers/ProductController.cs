using EMS.DataAccess.Repository.IRepository;
using EMS.Models;
using Microsoft.AspNetCore.Mvc;

namespace EMS.Web.Areas.User.Controllers
{
    [Area("User")]
    public class ProductController : Controller
    {
        private readonly IUnitOfWorks _unitOfWorks;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public ProductController(IUnitOfWorks unitOfWorks, IWebHostEnvironment webHostEnvironment)
        {
            _unitOfWorks = unitOfWorks;
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index()
        {
            return View();
        }
        #region APICALLS
        [HttpGet]
        public IActionResult GetAll()
        {
            List<Product> objProd = _unitOfWorks.Product.GetAll(includeProperties: "Brand, Size, Color").ToList();
            return Json(new { data = objProd });
        }
        #endregion
    }
}
