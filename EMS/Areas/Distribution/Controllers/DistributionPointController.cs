using EMS.DataAccess.Repository.IRepository;
using EMS.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EMS.Web.Areas.Distribution.Controllers
{
    [Area("Distribution")]
    [Authorize]
    public class DistributionPointController : Controller
    {
        public readonly IUnitOfWorks _unitOfWorks;
        public readonly IWebHostEnvironment _webHostEnvironment;
        public DistributionPointController(IUnitOfWorks unitOfWorks, IWebHostEnvironment webHostEnvironment)
        {
            _unitOfWorks = unitOfWorks;
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index()
        {
            return View();
        }
        #region API CALLS
        [HttpGet]
        public IActionResult GetAll()
        {
            List<DistributionPoint> distributionPointsList = _unitOfWorks.DistributionPoint.GetAll().ToList();
            return Json(new { data = distributionPointsList });
        }
        #endregion
    }
}
