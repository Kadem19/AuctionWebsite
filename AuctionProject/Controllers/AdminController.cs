using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AuctionProject.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace AuctionProject.Controllers
{
    //[Authorize(Roles = "ADMINISTRATOR")]
    public class AdminController : Controller
    {
        //   F i e l d s  &  P r o p e r t i e s

        private IAuctionRepository repository;
        private UserManager<IdentityUser> userManager;
        private SignInManager<IdentityUser> signInManager;

        //   C o n s t r u c t o r s

        public AdminController(IAuctionRepository repository, UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            this.repository = repository;
            this.userManager = userManager;
            this.signInManager = signInManager;
        }
        public IActionResult Index()
        {
            if (userManager.GetUserName(User) == "mccammon96@gmail.com")
            {
                IQueryable<Auction> someAuctions =
                    repository.GetAllAuctions()
                              .OrderBy(a => a.AuctionId);
                return View(someAuctions);
            }

            else
            {
                return RedirectToAction("UnauthorizedUser", "Auction");
            }
        }

        public IActionResult Detail(int id)
        {
            Auction auction = repository.GetAuctionsId(id);
            if (auction != null)
            {
                return View(auction);
            }

            return RedirectToAction("Index");
        }


        //  A u c t i o n   M e t h o d s
        [HttpGet]
        public IActionResult Update(int id)
        {
            Auction auction = repository.GetAuctionsId(id);
            if (auction != null)
            {
                return View(auction);
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Update(Auction auction, int id)
        {
            auction.AuctionId = id;
            Auction auction2 = repository.UpdateAuctions(auction);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Create()
        {
            Auction newAuction = new Auction();
            return View(newAuction);
        }

        [HttpPost]
        public IActionResult Create(Auction auctions)
        {
            repository.Create(auctions);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            Auction auction = repository.GetAuctionsId(id);
            if (auction != null)
            {
                return View();
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Delete(Auction auction, int id)
        {
            repository.DeleteAuction(id);
            return RedirectToAction("Index");
        }
    }
}
    
