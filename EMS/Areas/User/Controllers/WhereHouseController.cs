using EMS.DataAccess.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace EMS.Web.Areas.User.Controllers
{
    public class WhereHouseController : Controller
    {
        private readonly IUnitOfWorks _unitOfWorks;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public WhereHouseController(IUnitOfWorks unitOfWorks, IWebHostEnvironment webHostEnvironment)
        {
            _unitOfWorks = unitOfWorks;
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index()
        {
            return View();
        }
        #region API CALLS

        #endregion
    }
}
