using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RegistrationMVC.WebApp.Models;
using RegistrationMVC.WebApp.Repository;

namespace RegistrationMVC.WebApp.Controllers
{
    public class RegistrationController : Controller
    {
        private IUserData _userData;

        public RegistrationController(IUserData userdata)
        {
            _userData = userdata;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult UserRegistration(User model)
        {
            if (!ModelState.IsValid)
            {
                return View("~/Views/Registration/Index.cshtml");
            }
            _userData.AddUser(model);
           
            return RedirectToAction("Details", "Registration");            
        }

        public IActionResult Details()
        {
            return View(_userData.GetUser());
        }
    }
}
