using EMS.DataAccess.Repository.IRepository;
using EMS.Models;
using EMS.Models.ViewModels;
using EMS.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EMS.Web.Areas.User.Controllers
{
    [Area("User")]
    [Authorize]
    public class ProductController : Controller
    {
        private readonly IUnitOfWorks _unitOfWorks;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public ProductController(IUnitOfWorks unitOfWorks, IWebHostEnvironment webHostEnvironment)
        {
            _unitOfWorks = unitOfWorks;
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index()
        {
            ProductVM productVM = new()
            {
                BrandList = _unitOfWorks.Brand.GetAll().Select(u => new SelectListItem
                {
                    Text = u.Brand_Name,
                    Value = u.Id.ToString()
                }),
                SizeList = _unitOfWorks.Size.GetAll().Select(u => new SelectListItem
                {
                    Text = u.Size_Name,
                    Value = u.Id.ToString()
                }),
                ColorList = _unitOfWorks.Color.GetAll().Select(u => new SelectListItem
                {
                    Text = u.Color_Name,
                    Value = u.Id.ToString()
                }),
                Product = new Product()
            };
            return View(productVM);
        }
        [HttpPost]
        public IActionResult Upsert(ProductVM productVM)
        {
            if (ModelState.IsValid)
            {
                if (productVM.Product.Id == 0)
                {
                    _unitOfWorks.Product.Add(productVM.Product);
                }
                else
                {
                    _unitOfWorks.Product.Update(productVM.Product);
                }

                _unitOfWorks.Save();
                TempData["success"] = "Update Successfully";
                return RedirectToAction("Index");
            }
            else
            {
                productVM.BrandList = _unitOfWorks.Brand.GetAll().Select(u => new SelectListItem
                {
                    Text = u.Brand_Name,
                    Value = u.Id.ToString()
                });
                productVM.ColorList = _unitOfWorks.Color.GetAll().Select(u => new SelectListItem
                {
                    Text = u.Color_Name,
                    Value = u.Id.ToString()
                });
                productVM.SizeList = _unitOfWorks.Size.GetAll().Select(u => new SelectListItem
                {
                    Text = u.Size_Name,
                    Value = u.Id.ToString()
                });
                return View(productVM);
            }
        }
        #region APICALLS
        [HttpGet]
        public IActionResult GetAll()
        {
            List<Product> objProd = _unitOfWorks.Product.GetAll(includeProperties: "Brand,Color,Size").ToList();
            return Json(new { data = objProd });
        }
        [HttpGet]
        public IActionResult getByID(int id)
        {
            ProductVM productVM = new ProductVM();
            productVM.Product = _unitOfWorks.Product.Get(u => u.Id == id);
            return Json(new { data = productVM.Product });
        }
        [Authorize(Roles = SD.Role_Admin)]
        [HttpDelete]
        public IActionResult Delete(int? id)
        {
            var productToBeDeleted = _unitOfWorks.Product.Get(u => u.Id == id);
            if (productToBeDeleted == null)
            {
                return Json(new { success = false, message = "Error While Deleting" });
            }
            _unitOfWorks.Product.Remove(productToBeDeleted);
            _unitOfWorks.Save();
            List<Product> objProd = _unitOfWorks.Product.GetAll(includeProperties: "Brand,Color,Size").ToList();
            return Json(new { data = objProd, success = true, message = "Deleted Succesfully" });
        }
        #endregion
    }
}
