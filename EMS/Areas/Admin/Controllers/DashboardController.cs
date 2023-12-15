using EMS.DataAccess.Repository.IRepository;
using EMS.Models;
using EMS.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace EMSWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class DashboardController : Controller
    {
        private readonly IUnitOfWorks _unitOfWorks;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly UserManager<IdentityUser> _userManager;
        public DashboardController(IUnitOfWorks unitOfWorks, IWebHostEnvironment webHostEnvironment, UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
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
