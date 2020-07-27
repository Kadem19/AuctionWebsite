using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace AuctionProject.Models
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        //   F i e l d s  &  P r o p e r t i e s
        
        public DbSet<AuctionBid> AuctionBids { get; set; }
        public DbSet<IdentityUser>       Users       { get; set; }
        public DbSet<Auction>    Auctions    { get; set; }
        public DbSet<Inventory>  Inventories { get; set; }
        //public DbSet<Employees> Employees { get; set; }
        //public DbSet<Inventory> Inventory { get; set; }
        //public DbSet<Sales> Sales { get; set; }
        //public DbSet<Sellers> Sellers { get; set; }
        //public DbSet<Users> Users { get; set; }

        //   C o n s t r u c t o r s

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {

        }

        //   M e t h o d s

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Auction>().HasData
                (new Auction
                {
                    AuctionId = 1, 
                    SellerId = 1,
                    ProductId = 1
                });

            modelBuilder.Entity<Auction>().HasData
               (new Auction
               {
                   AuctionId = 2,
                   SellerId = 2,
                   ProductId = 2
               });

            modelBuilder.Entity<AuctionBid>().HasData
               (new AuctionBid
               {
                   AuctionBidId = 1,
                   UserId = 1,
                   BidAmount = 18.50,
                   AuctionId = 1
               });
            
            modelBuilder.Entity<AuctionBid>().HasData
               (new AuctionBid
               {
                   AuctionBidId = 3,
                   UserId = 2,
                   BidAmount = 20.30,
                   AuctionId = 1
               });


            modelBuilder.Entity<AuctionBid>().HasData
               (new AuctionBid
               {
                   AuctionBidId = 2,
                   UserId = 2,
                   BidAmount = 20,
                   AuctionId = 2
               });

            modelBuilder.Entity<AuctionBid>().HasData
              (new AuctionBid
              {
                  AuctionBidId = 4,
                  UserId = 1,
                  BidAmount = 23.50,
                  AuctionId = 2
              });

            // modelBuilder.Entity<Employees>().HasData
            //   (new Employees
            //   {
            //       empId = 1,
            //       fname= "Kade",
            //       lname = "McCammon"
            //   });

            // modelBuilder.Entity<Employees>().HasData
            //  (new Employees
            //  {
            //      empId = 2,
            //      fname = "John",
            //      lname = "Smith"
            //  });

            // modelBuilder.Entity<Inventory>().HasData
            //  (new Inventory
            //  {
            //      productid= 1,
            //      productName = "Madden 21",
            //      productQty = 1,
            //      auctionid = 1
            //  });

            // modelBuilder.Entity<Inventory>().HasData
            //  (new Inventory
            //  {
            //      productid = 2,
            //      productName = "Red Dead Redemption 2",
            //      productQty = 2,
            //      auctionid = 2
            //  });

            // modelBuilder.Entity<Sales>().HasData
            //  (new Sales
            //  {
            //      orderid = 1,
            //      userid = 1,
            //      productid = 1,
            //      auctionid = 1,
            //      productQty = 1
            //  });

            // modelBuilder.Entity<Sales>().HasData
            // (new Sales
            // {
            //     orderid = 2,
            //     userid = 2,
            //     productid = 2,
            //     auctionid = 2,
            //     productQty = 1
            // });

            // modelBuilder.Entity<Sellers>().HasData
            // (new Sellers
            // {
            //     sellerid = 1, 
            //     userid = 1
            // });

            // modelBuilder.Entity<Sellers>().HasData
            // (new Sellers
            // {
            //     sellerid = 2,
            //     userid = 2
            // });

            // modelBuilder.Entity<Users>().HasData
            // (new Users
            // {
            //    userid =1,
            //    fName = "Jerry",
            //    lName = "Jones",
            //    email = "jerruhjones@aol.com",
            //    password = "GoCowboys",
            //    userAddress = "1 Cowboys Way Irvine, TX",
            //    userPhone = "(555) 423-1345"
            // });

            // modelBuilder.Entity<Users>().HasData
            //(new Users
            //{
            //    userid = 2,
            //    fName = "Lebron",
            //    lName = "James",
            //    email = "kingjames@aol.com",
            //    password = "LakeShow",
            //    userAddress = "1 Hollywood Blvd Hollwood, CA",
            //    userPhone = "(555) 421-1346"
            //});
        }
    }
}
