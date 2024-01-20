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
    public class SalesExecutiveController : Controller
    {
        private readonly IUnitOfWorks _unitOfWorks;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public SalesExecutiveController(IUnitOfWorks unitOfWorks, IWebHostEnvironment webHostEnvironment)
        {
            _unitOfWorks = unitOfWorks;
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index()
        {
            SalesExecutiveVM salesExecutiveVM = new()
            {
                EmployeeList = _unitOfWorks.Employee.GetAll().Where(u => u.Emp_Department_id == 5).Select(u => new SelectListItem
                {
                    Text = u.Emp_full_name,
                    Value = u.Id.ToString()
                }),
                SalesExecutive = new SalesExecutive()
            };
            return View(salesExecutiveVM);
        }
        [HttpPost]
        public IActionResult Upsert(SalesExecutiveVM salesExecutiveVM)
        {
            if (ModelState.IsValid)
            {
                if (salesExecutiveVM.SalesExecutive.Id == 0)
                {
                    _unitOfWorks.SalesExecutive.Add(salesExecutiveVM.SalesExecutive);
                }
                else
                {
                    _unitOfWorks.SalesExecutive.Update(salesExecutiveVM.SalesExecutive);
                }

                _unitOfWorks.Save();
                TempData["success"] = "Update Successfully";
                return RedirectToAction("Index");
            }
            else
            {
                salesExecutiveVM.EmployeeList = _unitOfWorks.Employee.GetAll().Where(u => u.Emp_Department_id == 5).Select(u => new SelectListItem
                {
                    Text = u.Emp_full_name,
                    Value = u.Id.ToString()
                });
              
                return View(salesExecutiveVM);
            }
        }
        #region API CALLS
        [HttpGet]
        public IActionResult getAll() 
        {
            List<SalesExecutive> objsalesexe = _unitOfWorks.SalesExecutive.GetAll(includeProperties:"Employee").ToList();
            return Json(new {data = objsalesexe});
        }
        [HttpGet]
        public IActionResult getByID(int id)
        {
            SalesExecutiveVM salesExecutiveVM = new SalesExecutiveVM();
            salesExecutiveVM.SalesExecutive = _unitOfWorks.SalesExecutive.Get(u => u.Id == id);
            return Json(new { data = salesExecutiveVM.SalesExecutive });
        }
        [HttpDelete]
        public IActionResult Delete(int? id)
        {
            var salesExeToBeDeleted = _unitOfWorks.SalesExecutive.Get(u => u.Id == id);
            if (salesExeToBeDeleted == null)
            {
                return Json(new { success = false, message = "Error While Deleting" });
            }
            _unitOfWorks.SalesExecutive.Remove(salesExeToBeDeleted);
            _unitOfWorks.Save();
            List<SalesExecutive> objProd = _unitOfWorks.SalesExecutive.GetAll(includeProperties: "Employee").ToList();
            return Json(new { data = objProd, success = true, message = "Deleted Succesfully" });
        }
        #endregion
    }
}
