using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuctionProject.Models
{
    public interface IAuctionBidRepository
    {
        //   C r e a t e

        AuctionBid CreateBid(AuctionBid auctionBid);

        //   R e a d
        AuctionBid GetAuctionBid(int auctionbidId);

        AuctionBid GetHighestBid(int auctionId);

        //   U p d a t e

        AuctionBid UpdateAuctionBid(AuctionBid auctionBid);

        //   D e l e t e

        bool DeleteAuctionBid(int id);
    }
}
