using EMS.DataAccess.Repository.IRepository;
using EMS.Models;
using EMS.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EMSWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AttendanceController : Controller
    {
        private readonly IUnitOfWorks _unitOfWorks;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public AttendanceController(IUnitOfWorks unitOfWorks, IWebHostEnvironment webHostEnvironment)
        {
            _unitOfWorks = unitOfWorks;
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index()
        {
            List<Attendance> objAttendenceList = _unitOfWorks.Attendance.GetAll(includeProperties: "Employee").ToList();
            return View(objAttendenceList);
        }
        public IActionResult MonthlyAttendance()
        {
            List<Attendance> objAttendenceList = _unitOfWorks.Attendance.GetAll(includeProperties: "Employee").ToList();
            return View(objAttendenceList);
        }
        public IActionResult Create(int? id)
        {
            AttendanceVM attendanceVM = new()
            {
                EmployeeList = _unitOfWorks.Employee.GetAll().Select(u => new SelectListItem
                {
                    Text = u.Emp_full_name,
                    Value = u.Id.ToString()
                }),
               Attendance = new Attendance()
            };
            if (id == null || id == 0)
            {
                return View(attendanceVM);
            }
            else
            {
                attendanceVM.Attendance = _unitOfWorks.Attendance.Get(u => u.Id == id);
                return View(attendanceVM);
            }
          
        }
        [HttpPost]
        public IActionResult Create(AttendanceVM attendanceVM,IFormFile? file, int? id)
        {
            if (ModelState.IsValid)
            {
                if (attendanceVM.Attendance.Id == 0)
                {
                    _unitOfWorks.Attendance.Add(attendanceVM.Attendance);
                }
                else
                {
                    _unitOfWorks.Attendance.Update(attendanceVM.Attendance);
                }
                _unitOfWorks.Save();
                TempData["success"] = "Update Successfully";
                return RedirectToAction("Index");
            }
            else
            {
                attendanceVM.EmployeeList = _unitOfWorks.Employee.GetAll().Select(u => new SelectListItem
                {
                    Text = u.Emp_full_name,
                    Value = u.Id.ToString()
                });

                return View(attendanceVM);
            }
        }
        public IActionResult TodayAttendance()
        {
            List<Attendance> objAttendenceList = _unitOfWorks.Attendance.GetAll(includeProperties: "Employee").ToList();
            return View(objAttendenceList);
        }
        #region API CALLS
        [HttpGet]
        public IActionResult GetAll()
        {
            List<Attendance> objAttendanceList = _unitOfWorks.Attendance.GetAll(includeProperties: "Employee").ToList();
            return Json(new { data = objAttendanceList });
        }
        [HttpGet]
        public IActionResult GetToday()
        {
            // Get today's date
            DateTime today = DateTime.Today;

            // Assuming _unitOfWorks.Attendance.GetAll returns a collection of objects with 'attendance_date' property
            List<Attendance> objAttendanceList = _unitOfWorks.Attendance
                .GetAll(includeProperties: "Employee")
                .Where(a => a?.GetType()?.GetProperty("attendance_date")?.GetValue(a, null) is DateTime attendanceDate &&
                            attendanceDate.Date == today)
                .ToList();

            return Json(new { data = objAttendanceList });
        }
        #endregion
    }
}
