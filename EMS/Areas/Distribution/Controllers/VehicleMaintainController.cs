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
        public IActionResult VehicelMaintainUpsert(int id)
        {
            VehicleMaintainVM vmVM = new()
            {
                Vehicles = _unitOfWorks.Vehicle.Get(u => u.Id == id,includeProperties: "VehicleType"),
                VehicleMaintain = new VehicleMaintain()
            };
            return View(vmVM);
        }
        [HttpPost]
        public IActionResult VehicelMaintainUpsert(VehicleMaintain vehicleMaintain, IFormFile? file)
        {
            if (ModelState.IsValid)
            {
                string wwwRootPath = _webHostEnvironment.WebRootPath;
                if (file != null)
                {
                    string fileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
                    string vehicleMaintainPath = Path.Combine(wwwRootPath, @"images\VehicleMaintain");
                    if (!string.IsNullOrEmpty(vehicleMaintain.MaintainImage))
                    {
                        //delete old image
                        var oldImagePath = Path.Combine(wwwRootPath, vehicleMaintain.MaintainImage.TrimStart('\\'));
                        if (System.IO.File.Exists(oldImagePath))
                        {
                            System.IO.File.Delete(oldImagePath);
                        }
                    }
                    using (var fileStream = new FileStream(Path.Combine(vehicleMaintainPath, fileName), FileMode.Create))
                    {
                        file.CopyTo(fileStream);
                    }
                    vehicleMaintain.MaintainImage = @"\images\VehicleMaintain\" + fileName;
                }
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
        public IActionResult GetAll()
        {
            List<Vehicle> objVehicleMaintainList = _unitOfWorks.Vehicle.GetAll(includeProperties: "VehicleType").ToList();
            return Json(new { data = objVehicleMaintainList });
        }
        [HttpGet]
        public IActionResult GetVehiclelMaintain()
        {
            List<VehicleMaintain> vehicleMaintain = _unitOfWorks.VehicleMaintain.GetAll()
                //(filter: a => a.VehicleId == id,
                //    includeProperties: "Vehicle"
                //)
                .ToList();
            return Json(new { data = vehicleMaintain });
        }
        #endregion
    }
}
