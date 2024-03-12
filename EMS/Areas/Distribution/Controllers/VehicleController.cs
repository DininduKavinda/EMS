using EMS.DataAccess.Repository.IRepository;
using EMS.Models;
using EMS.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EMS.Web.Areas.Distribution.Controllers
{
    [Area("Distribution")]
    [Authorize]
    public class VehicleController : Controller
    {
        private readonly IUnitOfWorks _unitOfWorks;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public VehicleController(IUnitOfWorks unitOfWorks, IWebHostEnvironment webHostEnvironment)
        {
            _unitOfWorks = unitOfWorks;
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index()
        {
            VehicleVM vehicleVM = new()
            {
                VehicleTypeList = _unitOfWorks.VehicleType.GetAll().Select(u => new SelectListItem
                {
                    Text = u.Name,
                    Value = u.Id.ToString()
                }),
                Vehicle = new Vehicle(),
            };
            return View(vehicleVM);
        }
        public IActionResult Upsert(VehicleVM vehicleVM)
        {
            if (ModelState.IsValid)
            {
                if (vehicleVM.Vehicle.Id == 0)
                {
                    _unitOfWorks.Vehicle.Add(vehicleVM.Vehicle);
                }
                else
                {
                    _unitOfWorks.Vehicle.Update(vehicleVM.Vehicle);
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
            List<Vehicle> objVehicleList = _unitOfWorks.Vehicle.GetAll(includeProperties: "VehicleType").ToList();
            return Json(new { data = objVehicleList });
        }
        [HttpGet]
        public IActionResult getByID(int id)
        {
            Vehicle vehicle  = new Vehicle();
            vehicle = _unitOfWorks.Vehicle.Get(u => u.Id == id , includeProperties: "VehicleType");
            return Json(new { data = vehicle });
        }
        [HttpDelete]
        public IActionResult Delete(int? id)
        {
            var VehicleToBeDeleted = _unitOfWorks.Vehicle.Get(u => u.Id == id);
            if (VehicleToBeDeleted == null)
            {
                return Json(new { success = false, message = "Error While Deleting" });
            }
            _unitOfWorks.Vehicle.Remove(VehicleToBeDeleted);
            _unitOfWorks.Save();
            List<Vehicle> objVehicleList = _unitOfWorks.Vehicle.GetAll(includeProperties: "VehicleType").ToList();
            return Json(new { data = objVehicleList, success = true, message = "Deleted Succesfully" });
        }
        #endregion
    }
}
