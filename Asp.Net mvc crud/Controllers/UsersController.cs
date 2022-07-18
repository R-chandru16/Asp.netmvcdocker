using Asp.net_student.Models;
using Asp.net_student.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.net_student.Controllers
{
    public class UsersController : Controller
    {
        private readonly CollegeContext _context;
        private readonly LoginRepo<Users> _service;

        public UsersController(CollegeContext context, LoginRepo<Users> service)
        {
            _context = context;
            _service = service;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Users user)
        {
            //TempData["Email"] = user.Email;
            //TempData.Keep("Email");
            //TempData["Name"] = user.Name;
            //TempData.Keep("Name");

            ViewBag.Message = null;
            if (string.IsNullOrEmpty(user.Name) ||
            string.IsNullOrWhiteSpace(user.Name))
            {
                ViewBag.Message = "Enter Valid Name";
                return View();
            }

          

            else if (
          string.IsNullOrEmpty(user.Password) ||
          string.IsNullOrWhiteSpace(user.Password))
            {
                ViewBag.Message = "Enter Valid password";
                return View();
            }
            else
            {
                bool result = _service.Validate(user);
                if (result)
                {
                   
                    TempData["name"] = user.Name;

                    return RedirectToAction("index" ,"Students");
                }
                else
                {
                    ViewBag.Message = "Invalid Name or Password";
                    return View();
                }
            }

        }

    }
}


