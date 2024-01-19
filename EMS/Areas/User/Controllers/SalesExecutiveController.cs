using EMS.DataAccess.Repository.IRepository;
using EMS.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EMS.Web.Areas.User.Controllers
{
    [Area("User")]
    [Authorize]
    public class SalesExecutiveController : Controller
    {
        private readonly IUnitOfWorks _unitOfWorks;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public SalesExecutiveController(IUnitOfWorks unitOfWorks, IWebHostEnvironment webHostEnvironment)
        {
            _unitOfWorks = unitOfWorks;
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index()
        {
            return View();
        }
        #region API CALLS
        [HttpGet]
        public IActionResult getAll() 
        {
            List<SalesExecutive> objsalesexe = _unitOfWorks.SalesExecutive.GetAll(includeProperties:"Employee").ToList();
            return Json(new {data = objsalesexe});
        }
        #endregion
    }
}
