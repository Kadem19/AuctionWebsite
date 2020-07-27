using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AuctionProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace AuctionProject.Controllers
{
    public class InventoryController : Controller
    {
        //   F i e l d s  &  P r o p e r t i e s

        private IInventoryRepository repository;
        private int pageSize = 4;

        //   C o n s t r u c t o r s

        public InventoryController(IInventoryRepository repository)
        {
            this.repository = repository;
        }

       // M e t h o d s

        //public IActionResult Index(int productPage = 1)
        //{
        //    IQueryable<Inventory> someProducts =
        //        repository.GetInventory()
        //        .OrderyBy(i => i.ProductId)
        //        .Skip(productPage - 1) * pageSize)
        //        .Take(pageSize);
        //    return View(someProducts);
        //}
    }
}