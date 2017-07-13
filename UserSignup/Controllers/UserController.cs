using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UserSignup.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UserSignup.Controllers
{
    public class UserController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.title = "Add User";
            return View();

        }

        [HttpPost]
        public IActionResult Add(User user, string verify)
        {
            if (verify != user.Password)
            {
                ViewBag.error = "Passwords do not match";
                return View();
            }

            ViewBag.user = user;
            return View("Index");
        }
    }
}
