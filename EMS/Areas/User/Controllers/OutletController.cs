using EMS.DataAccess.Repository.IRepository;
using EMS.Models;
using EMS.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EMS.Web.Areas.User.Controllers
{
    [Area("User")]
    [Authorize]
    public class OutletController : Controller
    {
        private readonly IUnitOfWorks _unitOfWorks;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public OutletController(IUnitOfWorks unitOfWorks, IWebHostEnvironment webHostEnvironment)
        {
            _unitOfWorks = unitOfWorks;
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index()
        {
            Outlet outlet = new Outlet();
            return View(outlet);
        }
        [HttpPost]
        public IActionResult Upsert(Outlet outlet)
        {
            if (ModelState.IsValid)
            {
                if (outlet.Id == 0)
                {
                    _unitOfWorks.Outlet.Add(outlet);
                }
                else
                {
                    _unitOfWorks.Outlet.Update(outlet);
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
            List<Outlet> objProd = _unitOfWorks.Outlet.GetAll().ToList();
            return Json(new { data = objProd });
        }
        [HttpGet]
        public IActionResult getByID(int id)
        {
            Outlet outlet = new Outlet();
            outlet = _unitOfWorks.Outlet.Get(u => u.Id == id);
            return Json(new { data = outlet });
        }
        [HttpDelete]
        public IActionResult Delete(int? id)
        {
            var outlettobedelete = _unitOfWorks.Outlet.Get(u => u.Id == id);
            if (outlettobedelete == null)
            {
                return Json(new { success = false, message = "Error While Deleting" });
            }
            _unitOfWorks.Outlet.Remove(outlettobedelete);
            _unitOfWorks.Save();
            List<Outlet> objList = _unitOfWorks.Outlet.GetAll().ToList();
            return Json(new { data = objList, success = true, message = "Deleted Succesfully" });
        }
        #endregion
    }
}
