using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using AuctionProject.Models;
using AuctionProject.Models.ViewModels;

namespace AuctionProject.Controllers
{
    public class CartController : Controller
    {//   F i e l d s   &   P r o p e r t i e s

        private IAuctionRepository repository;

        //   C o n s t r u c t o r s

        public CartController(IAuctionRepository repository)
        {
            this.repository = repository;
        }

        //   M e t h o d s

        public RedirectToActionResult AddToCart(int auctionId,
                                                string returnUrl)
        {
            Auction auction = repository.GetAuctionsId(auctionId);
            if (auction != null)
            {
                Cart cart = GetCart();
                cart.AddItem(auction);
                SaveCart(cart);
            }
            return RedirectToAction("Index", new { returnUrl });
        }

        public IActionResult Index(string returnUrl)
        {
            CartIndexViewModel model = new CartIndexViewModel();
            model.Cart = GetCart();
            model.ReturnUrl = returnUrl;
            return View(model);
        }

        private Cart GetCart()
        {
            string cartJsonString =
               HttpContext.Session.GetString("_CartJson");
            if (cartJsonString != null)
            {
                return JsonConvert.DeserializeObject<Cart>
                   (cartJsonString);
            }
            return new Cart();
        }

        private void SaveCart(Cart cart)
        {
            string cartJsonString =
               JsonConvert.SerializeObject(cart);
            HttpContext.Session.SetString
               ("_CartJson", cartJsonString);
        }
    }    
}
