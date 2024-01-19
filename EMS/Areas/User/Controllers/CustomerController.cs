using EMS.DataAccess.Data;
using EMS.DataAccess.Repository.IRepository;
using EMS.Models;
using EMS.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EMS.Web.Areas.User.Controllers
{
    [Area("User")]
    [Authorize]
    public class CustomerController : Controller
    {
        private readonly IUnitOfWorks _unitOfWorks;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public CustomerController(IUnitOfWorks unitOfWorks, IWebHostEnvironment webHostEnvironment)
        {
            _unitOfWorks = unitOfWorks;
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index()
        {
            CustomerVM customerVM = new()
            {
                CityList = _unitOfWorks.City.GetAll().Select(u => new SelectListItem
                {
                    Text = u.NameEn,
                    Value = u.Id.ToString()
                }),
                Customer = new Customer()
            };           
            return View(customerVM);            
        }
        #region API CALLS
        [HttpGet]
        public IActionResult getAll() 
        {
            List<Customer> objcustomer = _unitOfWorks.Customer.GetAll(includeProperties: "City").ToList();
            return Json(new { data = objcustomer });
        }
        #endregion
    }
}
