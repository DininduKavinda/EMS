using EMS.DataAccess.Repository.IRepository;
using EMS.Models.ViewModels;
using EMS.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EMS.Web.Areas.User.Controllers
{
    [Area("User")]
    [Authorize]
    public class OrderFormController : Controller
    {
        private readonly IUnitOfWorks _unitOfWorks;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public OrderFormController(IUnitOfWorks unitOfWorks, IWebHostEnvironment webHostEnvironment)
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
            OrderFormVM orderFormVM = new()
            {
                CustomerList = _unitOfWorks.Customer.GetAll().Select(u => new SelectListItem
                {
                    Text = u.Customer_Shop_Name + " - " + u.Customer_Address,
                    Value = u.Id.ToString()
                }),
                SalesExecutiveList = _unitOfWorks.SalesExecutive.GetAll().Select(u => new SelectListItem
                {
                    Text = u.Employee?.Emp_full_name,
                    Value = u.Id.ToString()
                }),
                StatusList = _unitOfWorks.Status.GetAll().Select(u => new SelectListItem
                {
                    Text = u.StatusName,
                    Value = u.Id.ToString()
                }),
                OrderForm = new OrderForm()
            };
            if (id == null || id == 0)
            {
                return View(orderFormVM);
            }
            else
            {
                orderFormVM.OrderForm = _unitOfWorks.OrderForm.Get(u => u.Id == id);
                return View(orderFormVM);
            }
        }
        #region APICALLS
        [HttpGet]
        public IActionResult GetAll()
        {
            List<OrderForm> orderFormList = _unitOfWorks.OrderForm.GetAll(includeProperties: "Customer,SalesExecutive.Employee,Status").ToList();        
            return Json(new { data = orderFormList });
        }
        #endregion
    }
}
