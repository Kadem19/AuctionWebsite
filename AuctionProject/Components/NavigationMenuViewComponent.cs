using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AuctionProject.Models;

namespace AuctionProject.Components
{
    public class NavigationMenuViewComponent : ViewComponent
    {
        //   F i e l d s  &  P r o p e r t i e s

        private IAuctionRepository repository;
        //   C o n s t r u c t o r s

        public NavigationMenuViewComponent
           (IAuctionRepository repository) // IOC / DI
        {
            this.repository = repository;
        }

        //   M e t h o d s

        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedCategory =
            RouteData?.Values["category"];
            IQueryable<string> allCategories =
               repository.GetAllCategories();
            return View(allCategories);
        }

    }
}
