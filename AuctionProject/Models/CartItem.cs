using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuctionProject.Models
{
    public class CartItem
    {
        public int CartItemId { get; set; } // Not Needed Yet
        public Auction Auction { get; set; }
        public double SubTotal
        {
            get { return Auction.BuyNowPrice; }
        }

    }
}
