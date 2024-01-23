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
        [HttpPost]
        public IActionResult Upsert(CustomerVM customerVM)
        {
            if (ModelState.IsValid)
            {
                if (customerVM.Customer.Id == 0)
                {
                    _unitOfWorks.Customer.Add(customerVM.Customer);
                }
                else
                {
                    _unitOfWorks.Customer.Update(customerVM.Customer);
                }
                _unitOfWorks.Save();
                TempData["success"] = "Update Successfully";
                return RedirectToAction("Index");
            }
            else
            {
                customerVM.CityList = _unitOfWorks.City.GetAll().Select(u => new SelectListItem
                {
                    Text = u.NameEn,
                    Value = u.Id.ToString()
                });
                return View(customerVM);
            }
        }
        #region API CALLS
        [HttpGet]
        public IActionResult getAll() 
        {
            List<Customer> objcustomer = _unitOfWorks.Customer.GetAll(includeProperties: "City").ToList();
            return Json(new { data = objcustomer });
        }
        [HttpGet]
        public IActionResult getByID(int id)
        {
            CustomerVM customerVM = new CustomerVM();
            customerVM.Customer = _unitOfWorks.Customer.Get(u => u.Id == id);
            return Json(new { data = customerVM.Customer });
        }
        [HttpDelete]
        public IActionResult Delete(int? id)
        {
            var customerToBeDelete = _unitOfWorks.Customer.Get(u => u.Id == id);
            if (customerToBeDelete == null)
            {
                return Json(new { success = false, message = "Error While Deleting" });
            }
            _unitOfWorks.Customer.Remove(customerToBeDelete);
            _unitOfWorks.Save();
            List<Customer> objList = _unitOfWorks.Customer.GetAll(includeProperties: "City").ToList();
            return Json(new { data = objList, success = true, message = "Deleted Succesfully" });
        }
        #endregion
    }
}
