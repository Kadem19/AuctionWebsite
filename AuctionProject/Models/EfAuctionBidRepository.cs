using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuctionProject.Models
{
    public class EfAuctionBidRepository : IAuctionBidRepository
    {
        //   F i e l d s  &  P r o p e r t i e s

        private AppDbContext context;

        //   C o n s t r u c t o r s

        public EfAuctionBidRepository (AppDbContext context)
        {
            this.context = context;
        }

        //   M e t h o d s

        public AuctionBid GetAuctionBid(int auctionbidId)
        {
            return context.AuctionBids
                //.Include("AuctionBid")
                .FirstOrDefault(a => a.AuctionBidId == auctionbidId);
        }
        public AuctionBid CreateBid(AuctionBid auctionBid)
        {
            context.AuctionBids.Add(auctionBid);
            context.SaveChanges();
            return auctionBid;
        }

        public AuctionBid UpdateAuctionBid(AuctionBid auctionBid)
        {
            AuctionBid auctionbidToUpdate =
               context.AuctionBids
               .SingleOrDefault(a => a.AuctionBidId == auctionBid.AuctionBidId);
            if (auctionbidToUpdate != null)
            {
                auctionbidToUpdate.UserId = auctionBid.UserId;
                auctionbidToUpdate.BidAmount = auctionBid.BidAmount;
                context.SaveChanges();
            }
            return auctionbidToUpdate;
        }

        public bool DeleteAuctionBid(int id)
        {
            AuctionBid auctionbidToDelete =
                context.AuctionBids.FirstOrDefault(a => a.AuctionBidId == id);
            if (auctionbidToDelete == null)
            {
                return false;
            }
            context.AuctionBids.Remove(auctionbidToDelete);
            context.SaveChanges();
            return true;
        }
    }
}
