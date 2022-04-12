using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SessionProject.Entities;
using SessionProject.Extentions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SessionProject.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //HttpContext.Session.SetInt32("age", 23);
            //HttpContext.Session.SetString("name", "Elvin");

            HttpContext.Session.SetObject("user",new User { Id = 1, Name = "Rafiq", Surname = "Eliyev" });

            ViewBag.SessionContent = "Session created successfully";
            return View();
        }

        public string Sessions()
        {
            var age = HttpContext.Session.GetInt32("age");
            var name = HttpContext.Session.GetString("name");
            return "You are " + age.ToString() + "years old " + name;
        }

        public string User()
        {
            var user = HttpContext.Session.GetObject<User>("user");
            return $"Id : {user.Id}  Name : {user.Name}  Surname : {user.Surname}";
        }
    }
}
