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
    [Authorize(Roles = SD.Role_Accountant  + "," + SD.Role_Admin)]
    public class PayRollController : Controller
    {
        private readonly IUnitOfWorks _unitOfWorks;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public PayRollController(IUnitOfWorks unitOfWorks, IWebHostEnvironment webHostEnvironment)
        {
            _unitOfWorks = unitOfWorks;
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index()
        {
            return View();
        }
       
        #region API CALLS
        [HttpGet]
        public IActionResult GetAll()
        {
            List<Attendance> attendanceList = _unitOfWorks.Attendance.GetAll(includeProperties: "Employee").ToList();
            List<PayRoll> payRollList = _unitOfWorks.PayRoll.GetAll().ToList();
            List<Employee> employeeList = _unitOfWorks.Employee.GetAll(includeProperties: "JobTitle,Department,Gender,JobTitle.SalaryType").ToList();

            var combinedDataList = new List<object>();

            foreach (var payroll in payRollList)
            {
                // Find the corresponding employee for the payroll
                var employee = employeeList.FirstOrDefault(e => e.Id == payroll.EmployeeID);

                if (employee != null)
                {
                    // Find attendance records for the employee
                    var attendanceListForEmployee = attendanceList.Where(a => a.attendance_e_id == employee.Id).ToList();

                    // Combine data for the response
                    var combinedData = new
                    {
                        PayRoll = payroll,
                        Employee = employee,
                        AttendanceList = attendanceListForEmployee
                    };

                    combinedDataList.Add(combinedData);
                }
            }

            return Json(new { data = combinedDataList });
        }

        #endregion
    }
}
