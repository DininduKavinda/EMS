using EMS.DataAccess.Repository.IRepository;
using EMS.Models;
using Microsoft.AspNetCore.Mvc;

namespace EMSWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
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
