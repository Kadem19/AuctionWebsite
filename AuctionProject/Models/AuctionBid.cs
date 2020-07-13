using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AuctionProject.Models
{
    public class AuctionBid
    {
        //   F i e l d s  &  P r o p e r t i e s
        public int AuctionBidId { get; set; }
        public int UserId { get; set; }
        public double BidAmount { get; set; } 

        [ForeignKey("Auction")]
        public int AuctionId { get; set; }
        public Auction Auction { get; set; }
    }
}
