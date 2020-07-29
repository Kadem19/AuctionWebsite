using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AuctionProject.Models;

namespace AuctionProject.Controllers
{
    public class AuctionBidController : Controller
    {
        //   F i e l d s  &  P r o p e r t i e s

        private IAuctionBidRepository repository;

        //   C o n s t r u c t o r s

        public AuctionBidController(IAuctionBidRepository repository)
        {
            this.repository = repository;
        }

        //   M e t h o d s


        //[HttpGet]
        //public IActionResult CreateBid()
        //{
        //    AuctionBid newAuctionBid = new AuctionBid();
        //    return View(newAuctionBid);
        //}

        [HttpGet]
        public IActionResult ThankYou()
        {
            return View();
        }
        [HttpGet]
        public IActionResult CreateBid(int auctionId)
        {
            AuctionBid newAuctionBid = new AuctionBid();
            newAuctionBid.AuctionId = auctionId;
            ViewBag.HighestBid = repository.GetHighestBid(auctionId); 
            return View(newAuctionBid);
        }

        [HttpPost]
        public IActionResult CreateBid(AuctionBid auctionBid)
        {
            repository.CreateBid(auctionBid);
            return RedirectToAction("ThankYou", "AuctionBid");
        }

        [HttpGet]
        public IActionResult DeleteBid(int id)
        {
            AuctionBid auctionBid = repository.GetAuctionBid(id);
            if (auctionBid != null)
            {
                return View();
            }
            return RedirectToPage("Index", "Auction");
        }

        [HttpPost]
        public IActionResult DeleteBid(AuctionBid auctionBid, int id)
        {
            repository.DeleteAuctionBid(id);
            return RedirectToAction("Index", "Auction");
        }

        [HttpGet]
        public IActionResult UpdateBid(int id)
        {
            AuctionBid auctionBid = repository.GetAuctionBid(id);
            if (auctionBid != null)
            {
                return View();
            }
            return RedirectToAction("Index", "Auction");
        }

        [HttpPost]
        public IActionResult UpdateBid(AuctionBid auctionBid, int id)
        {
            auctionBid.AuctionBidId = id;
            AuctionBid auctionBid2 = repository.UpdateAuctionBid(auctionBid);
            return RedirectToAction("Index", "Auction");
        }
    }
}
