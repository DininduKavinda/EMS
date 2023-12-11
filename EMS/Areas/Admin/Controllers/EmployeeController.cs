using EMS.DataAccess.Repository.IRepository;
using EMS.Models;
using EMS.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Text.Json.Serialization;
using System.Text.Json;
using EMS.Utility;
using Microsoft.AspNetCore.Authorization;

namespace EMPSystemWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = SD.Role_Accountant + "," + SD.Role_Assistant_Accountant + "," + SD.Role_Admin)]
    public class EmployeeController : Controller
    {
        private readonly IUnitOfWorks _unitOfWorks;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public EmployeeController(IUnitOfWorks unitOfWorks, IWebHostEnvironment webHostEnvironment)
        {
            _unitOfWorks = unitOfWorks;
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index()
        {
            List<Employee> objEmployeeList = _unitOfWorks.Employee.GetAll(includeProperties:"JobTitle").ToList();
            return View(objEmployeeList);
        }
        [Authorize(Roles = SD.Role_Accountant + ", " + SD.Role_Admin)]
        public IActionResult Upsert(int? id)
        {
            EmployeeViewModel employeeVM = new()
            {
                JobTitleList = _unitOfWorks.JobTitle.GetAll().Select(u => new SelectListItem
                {
                    Text = u.jt_name,
                    Value = u.Id.ToString()
                }),
                DepartmentList = _unitOfWorks.Department.GetAll().Select(u => new SelectListItem
                {
                    Text = u.Department_Name,
                    Value = u.Id.ToString()
                }),
                GenderList = _unitOfWorks.Gender.GetAll().Select(u => new SelectListItem
                {
                    Text = u.GenderName,
                    Value = u.Id.ToString()
                }),
                Employee = new Employee()
            };
            if (id == null || id == 0)
            {
                return View(employeeVM);
            }
            else
            {
                employeeVM.Employee = _unitOfWorks.Employee.Get(u => u.Id == id);
                return View(employeeVM);
            }
            
        }
        [Authorize(Roles = SD.Role_Accountant + ", " + SD.Role_Admin)]
        [HttpPost]
        public IActionResult Upsert(EmployeeViewModel employeeVM, IFormFile? file)
        {
            if (ModelState.IsValid)
            {
                string wwwRootPath = _webHostEnvironment.WebRootPath;
                if(file != null)
                {
                    string fileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
                    string employeePath = Path.Combine(wwwRootPath, @"images\Employee");
                    if (!string.IsNullOrEmpty(employeeVM.Employee.Emp_dp))
                    {
                        //delete old image
                        var oldImagePath = Path.Combine(wwwRootPath, employeeVM.Employee.Emp_dp.TrimStart('\\'));
                        if(System.IO.File.Exists(oldImagePath))
                        {
                            System.IO.File.Delete(oldImagePath);
                        }
                    }
                    using (var fileStream = new FileStream(Path.Combine(employeePath,fileName),FileMode.Create))
                    {
                        file.CopyTo(fileStream);
                    }
                    employeeVM.Employee.Emp_dp = @"\images\Employee\" + fileName;
                }
                if (employeeVM.Employee.Id == 0)
                {
                    _unitOfWorks.Employee.Add(employeeVM.Employee);
                }
                else
                {
                    _unitOfWorks.Employee.Update(employeeVM.Employee);
                }
                _unitOfWorks.Save();
                TempData["success"] = "Update Successfully";
                return RedirectToAction("Index");
            }
            else
            {
                employeeVM.JobTitleList = _unitOfWorks.JobTitle.GetAll().Select(u => new SelectListItem
                {
                    Text = u.jt_name,
                    Value = u.Id.ToString()
                });
                employeeVM.DepartmentList = _unitOfWorks.Department.GetAll().Select(u => new SelectListItem
                {
                    Text = u.Department_Name,
                    Value = u.Id.ToString()
                });
                 employeeVM.GenderList = _unitOfWorks.Gender.GetAll().Select(u => new SelectListItem
                 {
                     Text = u.GenderName,
                     Value = u.Id.ToString()
                 });
                return View(employeeVM);
            } 
        }
        #region API CALLS
        [HttpGet]
        public IActionResult GetAll()
        {
            List<Employee> objEmployeeList = _unitOfWorks.Employee.GetAll(includeProperties: "JobTitle,Department,Gender,JobTitle.SalaryType").ToList();
            return Json(new { data = objEmployeeList });
        }
        [Authorize(Roles = SD.Role_Admin)]
        [HttpDelete]
        public IActionResult Delete(int? id)
        {
            var employeeToBeDeleted = _unitOfWorks.Employee.Get(u => u.Id == id);
            if (employeeToBeDeleted == null)
            {
                return Json(new { success = false, message = "Error While Deleting" });
            }
            var oldImagePath = Path.Combine(_webHostEnvironment.WebRootPath, employeeToBeDeleted.Emp_dp.TrimStart('\\'));
            if (System.IO.File.Exists(oldImagePath))
            {
                System.IO.File.Delete(oldImagePath);
            }
            _unitOfWorks.Employee.Remove(employeeToBeDeleted);
            _unitOfWorks.Save();
            List<Employee> objEmployeeList = _unitOfWorks.Employee.GetAll(includeProperties: "JobTitle").ToList();
            return Json(new { data = objEmployeeList, success = true, message = "Deleted Succesfully" });
        }
        #endregion
    }
}
