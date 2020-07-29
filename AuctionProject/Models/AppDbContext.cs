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
        
        public DbSet<AuctionBid>         AuctionBids { get; set; }
        public DbSet<IdentityUser>       Users       { get; set; }
        public DbSet<Auction>            Auctions    { get; set; }
        //   C o n s t r u c t o r s

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {

        }

        //   M e t h o d s

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = "04f1e43b-dbae-4d81-a6d2-17e145d2d2fd",
                Name = "Administrator",
                NormalizedName = "ADMINISTRATOR"
            });

            var hasher = new PasswordHasher<IdentityUser>();
            modelBuilder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = "cd5a92a1-3616-4d5f-9e01-f425f7be23c5",
                UserName = "mccammon96@gmail.com",
                NormalizedUserName = "MCCAMMON96@GMAIL.COM",
                Email = "mccammon96@gmail.com",
                NormalizedEmail = "MCCAMMON96@GMAIL.COM",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Secret123$"),
                SecurityStamp = string.Empty
            });

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = "04f1e43b-dbae-4d81-a6d2-17e145d2d2fd",
                UserId = "cd5a92a1-3616-4d5f-9e01-f425f7be23c5"
            });




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
        }
    }
}
