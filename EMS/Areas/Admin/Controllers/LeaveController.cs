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
    public class LeaveController : Controller
    {
        private readonly IUnitOfWorks _unitOfWorks;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public LeaveController(IUnitOfWorks unitOfWorks, IWebHostEnvironment webHostEnvironment)
        {
            _unitOfWorks = unitOfWorks;
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index()
        {
            List<Leave> objLeaveList = _unitOfWorks.Leave.GetAll(includeProperties: "Employee,LeaveType").ToList();
            return View(objLeaveList);
        }
        public IActionResult Upsert(int? id)
        {
            LeaveVM leaveVM = new()
            {
                EmployeeList = _unitOfWorks.Employee.GetAll().Select(u => new SelectListItem
                {
                    Text = u.Emp_full_name,
                    Value = u.Id.ToString()
                }),
                LeaveTypeList = _unitOfWorks.LeaveType.GetAll().Select(u => new SelectListItem
                {
                    Text = u.Leave_Type_Name,
                    Value = u.Id.ToString()
                }),
                Leave = new Leave()
            };
            if (id == null || id == 0)
            {
                return View(leaveVM);
            }
            else
            {
                leaveVM.Leave = _unitOfWorks.Leave.Get(u => u.Id == id);
                return View(leaveVM);
            }
        }
        [HttpPost]
        public IActionResult Upsert(LeaveVM leaveVM)
        {
            if (ModelState.IsValid)
            {
                if (leaveVM.Leave.Id == 0)
                {
                    _unitOfWorks.Leave.Add(leaveVM.Leave);
                }
                else
                {
                    _unitOfWorks.Leave.Update(leaveVM.Leave);
                }
                _unitOfWorks.Save();
                TempData["success"] = "Update Successfully";
                return RedirectToAction("Index");
            }
            else
            {
                leaveVM.EmployeeList = _unitOfWorks.Employee.GetAll().Select(u => new SelectListItem
                {
                    Text = u.Emp_full_name,
                    Value = u.Id.ToString()
                });
                leaveVM.LeaveTypeList = _unitOfWorks.LeaveType.GetAll().Select(u => new SelectListItem
                {
                    Text = u.Leave_Type_Name,
                    Value = u.Id.ToString()
                });
                return View(leaveVM);
            }
        }
        #region API CALLS
        [HttpGet]
        public IActionResult GetAll()
        {
            List<Leave> objLeaveList = _unitOfWorks.Leave.GetAll(includeProperties: "Employee,LeaveType").ToList();
            return Json(new { data = objLeaveList });
        }
        #endregion
    }
}
