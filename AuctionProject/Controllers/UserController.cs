//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Mvc;
//using AuctionProject.Controllers;
//using AuctionProject.Models;
//using Microsoft.AspNetCore.Authorization;
//using Microsoft.AspNetCore.Authentication;
//using Microsoft.AspNetCore.Identity;
//using Microsoft.AspNetCore.Identity.UI.Services;

//namespace AuctionProject.Controllers
//{
//    public class UserController : Controller
//    {
//        //   F i e l d s  &  P r o p e r t i e s

//        private IUserRepository repository;
//        //   C o n s t r u c t o r s

//        public UserController(IUserRepository repository)
//        {
//            this.repository = repository;
//        }

//        //   M e t h o d s

//        //   C r e a t e

//        [HttpGet]
//        public IActionResult Register()
//        {
//            return View();
//        }

//        [HttpPost]
//        public IActionResult Register(IdentityUser user)
//        {
//            repository.AddUser(user);
//            return RedirectToAction("Index");
//        }

//        //   R e a d

//        public IActionResult Index()
//        {
//            IQueryable<IdentityUser> allUsers = repository.GetAllUsers();
//            return View(allUsers);
//        }

//        [HttpGet]
//        public IActionResult Login()
//        {
//            return View();
//        }

//        [HttpPost]
//        public IActionResult Login(IdentityUser user)
//        {
//            IdentityUser dbUser = repository.GetUserByEmail(user.Username);
//            if (dbUser != null && dbUser.Password == user.Password)
//            {
//                // Successful Login
//                user.Id = dbUser.Id;
//                // A useless statement to put a breakpoint on.
//            }
//            else
//            {
//                // Failed Login
//                dbUser.Id = user.Id;
//                // A useless statement to put a breakpoint on.
//            }
//            return RedirectToAction("Index");
//        }

//        //   U p d a t e

//        //   D e l e t e

//    }
//}