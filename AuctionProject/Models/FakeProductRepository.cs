//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace AuctionProject.Models
//{
//    public class FakeProductRepository : IAuctionRepository
//    {

//        private AppDbContext context;

//        public FakeProductRepository(AppDbContext context)
//        {
//            this.context = context;
//        }
//        public Auction Create(Auction auction)
//        {
//            context.Auctions.Add(auction);
//            context.SaveChanges();
//            return auction;
//        }

//        public bool DeleteAuction(int id)
//        {

//            Auction auctionToDelete =
//               context.Auctions.FirstOrDefault(a => a.AuctionId == id);
//            if (auctionToDelete == null)
//            {
//                return false;
//            }
//            context.Auctions.Remove(auctionToDelete);
//            context.SaveChanges();
//            return true;
//        }

//        public IQueryable<Auction> GetAllAuctions()
//        {
//            Auction[] auctions = new Auction[2];

//            auctions[0] = new Auction
//            {
//                AuctionId = 1,
//                SellerId = 1,
//                ProductId = 1
//            };

//            auctions[1] = new Auction
//            {
//                AuctionId = 2,
//                SellerId = 2,
//                ProductId = 2
//            };

//            return auctions.AsQueryable<Auction>();

//        }

//        public IQueryable<Auction> GetAuctionsByKeyword(string keyword)
//        {
//            throw new NotImplementedException();
//        }

//        public Auction GetAuctionsId(int auctionsId)
//        {
//            return context.Auctions
//                 .Where(a => a.AuctionId == auctionsId)
//                 .FirstOrDefault();
//        }

//        public Auction UpdateAuctions(Auction auction)
//        {
//            Auction auctionToUpdate =
//               context.Auctions
//               .SingleOrDefault(a => a.AuctionId == auction.AuctionId);
//            if (auctionToUpdate != null)
//            {
//                auctionToUpdate.SellerId = auction.SellerId;
//                auctionToUpdate.ProductId = auction.ProductId;
//                context.SaveChanges();
//            }
//            return auctionToUpdate;
//        }

//        //public IQueryable<Employees> GetAllEmployees()
//        //{
//        //    Employees[] employees = new Employees[2];

//        //    employees[0] = new Employees
//        //    {
//        //        empid = 1,
//        //        fname = "Kade",
//        //        lname = "McCammon"
//        //    };

//        //    employees[1] = new Employees
//        //    {
//        //        empid = 2,
//        //        fname = "John",
//        //        lname = "Smith"
//        //    };

//        //    return employees.AsQueryable<Employees>();
//        //}

//        //public IQueryable<Inventory> GetAllInventory()
//        //{
//        //    Inventory[] inventories = new Inventory[2];

//        //    inventories[0] = new Inventory
//        //    {
//        //        productid = 1,
//        //        productName = "Madden 21",
//        //        productQty = 1,
//        //        auctionid = 1
//        //    };

//        //    inventories[1] = new Inventory
//        //    {
//        //        productid = 2,
//        //        productName = "Red Dead Redemption 2",
//        //        productQty = 2,
//        //        auctionid = 2
//        //    };

//        //    return inventories.AsQueryable<Inventory>();
//        //}

//        //public IQueryable<Sales> GetAllSales()
//        //{
//        //    Sales[] sales = new Sales[2];

//        //    sales[0] = new Sales
//        //    {
//        //        orderid = 1,
//        //        userid = 1,
//        //        productid = 1,
//        //        auctionid = 1,
//        //        productQty = 1
//        //    };

//        //    sales[1] = new Sales
//        //    {
//        //        orderid = 2,
//        //        userid = 2,
//        //        productid = 2,
//        //        auctionid = 2,
//        //        productQty = 1
//        //    };

//        //    return sales.AsQueryable<Sales>();
//        //}

//        //public IQueryable<Sellers> GetAllSellers()
//        //{
//        //    Sellers[] sellers = new Sellers[2];

//        //    sellers[0] = new Sellers
//        //    {
//        //        sellerid = 1,
//        //        userid = 1
//        //    };

//        //    sellers[1] = new Sellers
//        //    {
//        //        sellerid = 2,
//        //        userid = 2
//        //    };

//        //    return sellers.AsQueryable<Sellers>();
//        //}

//        //public IQueryable<Users> GetAllUsers()
//        //{
//        //    Users[] users = new Users[2];

//        //    users[0] = new Users
//        //    {
//        //        userid = 1,
//        //        fName = "Jerry",
//        //        lName = "Jones",
//        //        email = "jerruhjones@aol.com",
//        //        password = "GoCowboys",
//        //        userAddress = "1 Cowboys Way Irvine, TX",
//        //        userPhone = "(555) 423-1345"
//        //    };

//        //    users[1] = new Users
//        //    {
//        //        userid = 2,
//        //        fName = "Lebron",
//        //        lName = "James",
//        //        email = "kingjames@aol.com",
//        //        password = "LakeShow",
//        //        userAddress = "1 Hollywood Blvd Hollwood, CA",
//        //        userPhone = "(555) 421-1346"
//        //    };

//        //    return users.AsQueryable<Users>();
//        //}
//    }
//}
