using EMS.DataAccess.Repository.IRepository;
using EMS.Models;
using EMS.Models.ViewModels;
using EMS.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EMSWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = SD.Role_Accountant + "," + SD.Role_Assistant_Accountant + "," + SD.Role_Admin)]
    public class SalaryController : Controller
    {
        private readonly IUnitOfWorks _unitOfWorks;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public SalaryController(IUnitOfWorks unitOfWorks, IWebHostEnvironment webHostEnvironment)
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
            EmployeeViewModel empVM = new()
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
                Employee = new Employee(),
            };
            if (id == null || id == 0)
            {
                return View(empVM);
            }
            else
            {
                empVM.Employee = _unitOfWorks.Employee.Get(u => u.Id == id);
                empVM.Attendance = _unitOfWorks.Attendance.GetAll().ToList();
                return View(empVM);
            }
        }
        [Authorize(Roles = SD.Role_Accountant +", " + SD.Role_Admin)]
        [HttpPost]
        public IActionResult Upsert(PayRollVM payRollVM)
        {
            if (ModelState.IsValid)
            {             
                if (payRollVM.PayRoll.Id == 0)
                {
                    _unitOfWorks.PayRoll.Add(payRollVM.PayRoll);
                }
                else
                {
                    _unitOfWorks.PayRoll.Update(payRollVM.PayRoll);
                }
                _unitOfWorks.Save();
                TempData["success"] = "Update Successfully";
                return RedirectToAction("Index");
            }
            else
            {
                payRollVM.EmployeeList = _unitOfWorks.Employee.GetAll().Select(u => new SelectListItem
                {
                    Text = u.Emp_full_name,
                    Value = u.Id.ToString()
                });
                return View(payRollVM);
            }
        }
        #region API CALLS
        [HttpGet]
        public IActionResult GetAll()
        {
            DateTime currentMonthStart = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            DateTime currentMonthEnd = currentMonthStart.AddMonths(1).AddDays(-1);

            List<Attendance> attendanceList = _unitOfWorks.Attendance.GetAll(includeProperties: "Employee").ToList();
            List<PayRoll> payRollList = _unitOfWorks.PayRoll.GetAll().ToList();
            List<Employee> empList = _unitOfWorks.Employee.GetAll(includeProperties: "JobTitle,Department,Gender,JobTitle.SalaryType").ToList();

            var combinedDataList = new List<object>();

            foreach (var employee in empList)
            {
                bool hasPayrollData = payRollList.Any(a => a.EmployeeID == employee.Id &&
                                                           a.PraperedDate >= currentMonthStart &&
                                                           a.PraperedDate <= currentMonthEnd);
                if (!hasPayrollData)
                {
                    var combinedData = new
                    {
                        Employee = employee,
                        AttendanceList = attendanceList.Where(a => a.attendance_e_id == employee.Id).ToList(),
                    };

                    combinedDataList.Add(combinedData);
                }
            }

            return Json(new { data = combinedDataList });
        }

        #endregion
    }
}
