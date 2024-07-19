using Academy_App.Models;
using Logic.IHelpers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Academy_App.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUserHelper _userHelper;

        public HomeController(ILogger<HomeController> logger, IUserHelper userHelper)
        {
            _logger = logger;
            _userHelper = userHelper;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Index1()
        {
            return View();
        }

        public IActionResult FAQ()
        {
            return View();
        }        
        public IActionResult BadRequests()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        [HttpGet]
        public JsonResult GetUserFullName()
        {
            try
            {
                var userName = User.Identity.Name;
                if (userName != null)
                {
                    var fullName = _userHelper.GetFullNameByUserNameAsync(userName);
                    return Json(fullName);
                }
                return Json(new { isError = true, msg = "Failed" });
            }
            catch (Exception ex)
            {

                return Json(new { isError = true, msg = "An unexpected error occured " + ex.Message });
            }
        }
    }
}
