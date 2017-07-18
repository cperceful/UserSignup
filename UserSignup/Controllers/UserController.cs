using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UserSignup.Models;
using UserSignup.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UserSignup.Controllers
{
    public class UserController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            List<User> users = UserData.GetAll();
            return View(users);
        }

        [HttpGet]
        public IActionResult Add()
        {
            AddUserViewModel addUserViewModel = new AddUserViewModel();
            return View(addUserViewModel);

        }

        [HttpPost]
        public IActionResult Add(AddUserViewModel addUserViewModel)
        {
            if (ModelState.IsValid)
            {
                addUserViewModel.AddUser();
                return Redirect("/");
            }

            return View(addUserViewModel);
        }

        [HttpGet]
        [Route("/user/detail/{userId}")]
        public IActionResult Detail(int userId)
        {
            User user = UserData.FindById(userId);
            return View(user);
        }
    }
}
