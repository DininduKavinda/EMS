using EMS.DataAccess.Repository.IRepository;
using EMS.Models;
using EMS.Models.ViewModels;
using EMS.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Security.Permissions;

namespace EMS.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = SD.Role_Accountant + "," + SD.Role_Admin)]
    public class PrepareWagesController : Controller
    {    
        private readonly IUnitOfWorks _unitOfWorks;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public PrepareWagesController(IUnitOfWorks unitOfWorks, IWebHostEnvironment webHostEnvironment)
        {
            _unitOfWorks = unitOfWorks;
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Upsert(int id)
        {
            PayRollVM payRollVM = new()
            {
                EmployeeList = _unitOfWorks.Employee.GetAll().Select(u => new SelectListItem
                {
                    Text = u.Emp_full_name,
                    Value = u.Id.ToString()
                }),
                PayRoll = new PayRoll(),
            };
            payRollVM.PayRoll = _unitOfWorks.PayRoll.Get(u => u.Id == id , includeProperties: "Employee,Employee.Department,Employee.Gender,Employee.JobTitle.SalaryType");
            payRollVM.Employee = _unitOfWorks.Employee.Get(u => u.Id == payRollVM.PayRoll.CreatedBy);
            return View(payRollVM);
        }
        [Authorize(Roles = SD.Role_Accountant + ", " + SD.Role_Admin)]
        [HttpPost]
        public IActionResult Upsert(PayRollVM payRollVM)
        {
            if (ModelState.IsValid)
            {
                var existingPayRoll = _unitOfWorks.PayRoll
                    .Get(u => u.Id == payRollVM.PayRoll.Id, includeProperties: "Employee.JobTitle");
                existingPayRoll.Allowances = payRollVM.PayRoll.Allowances;
                existingPayRoll.Advanced = payRollVM.PayRoll.Advanced;
                _unitOfWorks.PayRoll.Update(existingPayRoll);
                _unitOfWorks.Save();

                TempData["success"] = "Update Successfully";
                return RedirectToAction("Index");
            }
            else
            {
                TempData["error"] = "Update Failed";
                return RedirectToAction("Index");
            }
        }

        #region API CALLS
        [HttpGet]
        public IActionResult GetAll()
        {
            DateTime currentMonthStart = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            DateTime currentMonthEnd = currentMonthStart.AddMonths(1).AddDays(-1);

            List<PayRoll> objPayRollList = _unitOfWorks.PayRoll
                .GetAll(
                    filter: a => a.PraperedDate >= currentMonthStart && a.PraperedDate <= currentMonthEnd && a.ApprovedBy == 0,
                    includeProperties: "Employee,Employee.JobTitle,Employee.Department,Employee.Gender,Employee.JobTitle.SalaryType"
                )
                .ToList();

            return Json(new { data = objPayRollList });
        }
        #endregion
    }
}
