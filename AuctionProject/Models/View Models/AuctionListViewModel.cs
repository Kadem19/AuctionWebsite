using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuctionProject.Models.ViewModels
{
    public class AuctionListViewModel
    {
        public IQueryable<Auction> Auctions { get; set; }
        public string              CurrentCategory { get; set; }
    }
}
