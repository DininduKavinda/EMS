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
        public IActionResult Payments(int id)
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
            payRollVM.PayRoll = _unitOfWorks.PayRoll.Get(u => u.Id == id, includeProperties: "Employee,Employee.Department,Employee.Gender,Employee.JobTitle.SalaryType");
            payRollVM.Employee = _unitOfWorks.Employee.Get(u => u.Id == payRollVM.PayRoll.CreatedBy);
            return View(payRollVM);
        }
        #region API CALLS
        [HttpGet]
        public IActionResult GetAll()
        {
            {
                List<PayRoll> objPayRollList = _unitOfWorks.PayRoll
                    .GetAll(
                        filter: a => a.ApprovedBy != 0 ,
                        includeProperties: "Employee,Employee.JobTitle,Employee.Department,Employee.Gender,Employee.JobTitle.SalaryType"
                    )
                    .ToList();

                return Json(new { data = objPayRollList });
            }
        }

        #endregion
    }
}
