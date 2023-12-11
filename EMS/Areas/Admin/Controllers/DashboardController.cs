using EMS.DataAccess.Repository.IRepository;
using EMS.Models;
using EMS.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EMSWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = SD.Role_Accountant + "," + SD.Role_Assistant_Accountant + "," + SD.Role_Admin)]
    public class DashboardController : Controller
    {
        private readonly IUnitOfWorks _unitOfWorks;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public DashboardController(IUnitOfWorks unitOfWorks, IWebHostEnvironment webHostEnvironment)
        {
            _unitOfWorks = unitOfWorks;
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index()
        {
            //List<Attendance> objAttendenceList = _unitOfWorks.Attendance.GetAll(includeProperties: "Employee").ToList();
            //return View(objAttendenceList);
            return View();
        }
    }
}
