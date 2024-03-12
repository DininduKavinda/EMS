using EMS.DataAccess.Repository.IRepository;
using EMS.Models;
using EMS.Models.ViewModels;
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
        [HttpPost]
        public IActionResult Upsert(DistributionPoint distributionPoint)
        {
            if (ModelState.IsValid)
            {
                if (distributionPoint.Id == 0)
                {
                    _unitOfWorks.DistributionPoint.Add(distributionPoint);
                }
                else
                {
                    _unitOfWorks.DistributionPoint.Update(distributionPoint);
                }
                _unitOfWorks.Save();
                TempData["success"] = "Update Successfully";
                return RedirectToAction("Index");
            }
            else
            {
                return View("Index");
            }
        }
        #region API CALLS
        [HttpGet]
        public IActionResult GetAll()
        {
            List<DistributionPoint> distributionPointsList = _unitOfWorks.DistributionPoint.GetAll().ToList();
            return Json(new { data = distributionPointsList });
        }
        [HttpGet]
        public IActionResult getByID(int id)
        {
            DistributionPoint dbpoint = new DistributionPoint();
            dbpoint = _unitOfWorks.DistributionPoint.Get(u => u.Id == id);
            return Json(new { data = dbpoint });
        }
        [HttpDelete]
        public IActionResult Delete(int? id)
        {
            var DistributionPointToBeDeleted = _unitOfWorks.DistributionPoint.Get(u => u.Id == id);
            if (DistributionPointToBeDeleted == null)
            {
                return Json(new { success = false, message = "Error While Deleting" });
            }
            _unitOfWorks.DistributionPoint.Remove(DistributionPointToBeDeleted);
            _unitOfWorks.Save();
            List<DistributionPoint> objDBPList = _unitOfWorks.DistributionPoint.GetAll().ToList();
            return Json(new { data = objDBPList, success = true, message = "Deleted Succesfully" });
        }
        #endregion
    }
}
