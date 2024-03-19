using EMS.DataAccess.Repository.IRepository;
using EMS.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EMS.Web.Areas.Distribution.Controllers
{
    [Area("Distribution")]
    [Authorize]
    public class VehicleMaintainController : Controller
    {
        private readonly IUnitOfWorks _unitOfWorks;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public VehicleMaintainController(IUnitOfWorks unitOfWorks, IWebHostEnvironment webHostEnvironment)
        {
            _unitOfWorks = unitOfWorks;
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult VehicelMaintain(VehicleMaintain vehicleMaintain)
        {
            if (ModelState.IsValid)
            {
                if (vehicleMaintain.Id == 0)
                {
                    _unitOfWorks.VehicleMaintain.Add(vehicleMaintain);
                }
                else
                {
                    _unitOfWorks.VehicleMaintain.Update(vehicleMaintain);
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
        public IActionResult GetAllVehicleMaintain()
        {
            List<VehicleMaintain> objVehicleMaintainList = _unitOfWorks.VehicleMaintain.GetAll(includeProperties: "Vehicle").ToList();
            return Json(new { data = objVehicleMaintainList });
        }
        [HttpGet]
        public IActionResult getByID(int id)
        {
            VehicleMaintain vm = new VehicleMaintain();
            vm = _unitOfWorks.VehicleMaintain.Get(u => u.Id == id, includeProperties: "Vehicle");
            return Json(new { data = vm });
        }
        #endregion
    }
}
