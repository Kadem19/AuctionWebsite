using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuctionProject.Models
{
    public interface IAuctionRepository
    {
        //   C r e a t e

        Auction Create(Auction auction);

        //   R e a d
        IQueryable<Auction> GetAllAuctions();
        IQueryable<string> GetAllCategories();
        Auction GetAuctionsId(int auctionsId);
        //IQueryable<Auctions> GetAuctionsByKeyword(string keyword);

        //public IQueryable<Employees> GetAllEmployees();
        //public IQueryable<Inventory> GetAllInventory();
        //public IQueryable<Sales> GetAllSales();
        //public IQueryable<Sellers> GetAllSellers();
        //public IQueryable<Users> GetAllUsers();

        //  U p d a t e

        Auction UpdateAuctions(Auction auction);

        //  D e l e t e 

        bool DeleteAuction(int id);
    }
}
