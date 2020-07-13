using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AuctionProject.Models;

namespace AuctionProject.Controllers
{
    public class AuctionController : Controller
    {
        //   F i e l d s  &  P r o p e r t i e s

        private IAuctionRepository repository;
        private int pageSize = 4;

        //   C o n s t r u c t o r s

        public AuctionController(IAuctionRepository repository)
        {
            this.repository = repository;
        }

        //   M e t h o d s

        //public IActionResult Index()
        //{
        //    IQueryable<Auctions> allAuctions =
        //        repository.GetAllAuctions();
        //    return View(allAuctions);

            //IQueryable<Employees> allEmployees =
            //    repository.GetAllEmployees();
            //return View(allEmployees);

            //IQueryable<Inventory> allInventory =
            //    repository.GetAllInventory();
            //return View(allInventory);

            //IQueryable<Sales> allSales =
            //    repository.GetAllSales();
            //return View(allSales);

            //IQueryable<Sellers> allSellers =
            //    repository.GetAllSellers();
            //return View(allSellers);

            //IQueryable<Users> allUsers =
            //    repository.GetAllUsers();
            //return View(allUsers);
        

        public IActionResult Index(int productPage = 1)
        {
            IQueryable<Auction> someAuctions =
                repository.GetAllAuctions()
                          .OrderBy(a => a.AuctionId)
                          .Skip((productPage - 1) * pageSize)
                          .Take(pageSize);
            return View(someAuctions);
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
                return View();
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