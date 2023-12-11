using EMS.DataAccess.Repository.IRepository;
using EMS.Models;
using EMS.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EMSWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class JobTitleController : Controller
    {
        private readonly IUnitOfWorks _unitOfWorks;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public JobTitleController(IUnitOfWorks unitOfWorks, IWebHostEnvironment webHostEnvironment)
        {
            _unitOfWorks = unitOfWorks;
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Upsert(int? id)
        {
            JobTitleVM jobTitleVM = new()
            {
                SalaryTypeList = _unitOfWorks.SalaryType.GetAll().Select(u => new SelectListItem
                {
                    Text = u.st_name,
                    Value = u.Id.ToString()
                }),
                JobTitle = new JobTitle()
            };
            if (id == null || id == 0)
            {
                return View(jobTitleVM);
            }
            else
            {
                jobTitleVM.JobTitle = _unitOfWorks.JobTitle.Get(u => u.Id == id);
                return View(jobTitleVM);
            }
        }
        [HttpPost]
        public IActionResult Upsert(JobTitleVM jobTitleVM)
        {
            if (ModelState.IsValid)
            {
                // Check if SalaryTypeID is 1
                if (jobTitleVM.JobTitle.SalaryTypeID == 1)
                {
                    // Set EmpoyeerETF, EmpoyeerEPF, and EmpoyeeEPF to 0
                    jobTitleVM.JobTitle.EmpoyeerETF = 0;
                    jobTitleVM.JobTitle.EmpoyeerEPF = 0;
                    jobTitleVM.JobTitle.EmpoyeeEPF = 0;
                }

                if (jobTitleVM.JobTitle.Id == 0)
                {
                    _unitOfWorks.JobTitle.Add(jobTitleVM.JobTitle);
                }
                else
                {
                    _unitOfWorks.JobTitle.Update(jobTitleVM.JobTitle);
                }

                _unitOfWorks.Save();
                TempData["success"] = "Update Successfully";
                return RedirectToAction("Index");
            }
            else
            {
                jobTitleVM.SalaryTypeList = _unitOfWorks.SalaryType.GetAll().Select(u => new SelectListItem
                {
                    Text = u.st_name,
                    Value = u.Id.ToString()
                });
                return View(jobTitleVM);
            }
        }
        #region API CALLS
        [HttpGet]
        public IActionResult GetAll()
        {
            List<JobTitle> objList = _unitOfWorks.JobTitle.GetAll(includeProperties: "SalaryType").ToList();
            return Json(new { data = objList });
        }
        [HttpDelete]
        public IActionResult Delete(int? id)
        {
            var jobtitleToBeDeleted = _unitOfWorks.JobTitle.Get(u => u.Id == id);
            if (jobtitleToBeDeleted == null)
            {
                return Json(new { success = false, message = "Error While Deleting" });
            }
            _unitOfWorks.JobTitle.Remove(jobtitleToBeDeleted);
            _unitOfWorks.Save();
            List<JobTitle> objList = _unitOfWorks.JobTitle.GetAll(includeProperties: "SalaryType").ToList();
            return Json(new { data = objList, success = true, message = "Deleted Succesfully" });
        }
        #endregion
    }
}
