using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuctionProject.Models
{
    public class Cart
    {
        //   F i e l d s   &   P r o p e r t i e s

        private List<CartItem> items = new List<CartItem>();

        public virtual IEnumerable<CartItem> Items
        {
            get { return items; }
        }

        public double TotalValue
        {
            get { return items.Sum(i => i.SubTotal); }
        }

        //   C o n s t r u c t o r s

        //   M e t h o d s

        public virtual void AddItem(Auction auction)
        {
            CartItem item =
               items.Where
                  (i => i.Auction.AuctionId == auction.AuctionId)
                    .FirstOrDefault();
            if (item == null)
            {
                item = new CartItem
                {
                    Auction = auction,
                };
                items.Add(item);
            }
        }

        public virtual void Clear()
        {
            items.Clear();
        }

        public virtual void RemoveItem(Auction auction)
        {
            items.RemoveAll
               (i => i.Auction.AuctionId == auction.AuctionId);
        }
    }
}
