﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuctionProject.Models
{
    public class EfAuctionRepository : IAuctionRepository
    {
        //   F i e l d s  &  P r o p e r t i e s

        private AppDbContext context;

        //   C o n s t r u c t o r s

        public EfAuctionRepository(AppDbContext context)
        {
            this.context = context;
        }

        //   M e t h o d s

        public IQueryable<Auction> GetAllAuctions()
        {
            return context.Auctions;
        }

        public IQueryable<Auction> GetAuctionsByKeyword(string keyword)
        {
            throw new NotImplementedException();
        }

        public Auction GetAuctionsId(int auctionsId)
        {
            return context.Auctions
                .Include("AuctionBid")
                .FirstOrDefault(a => a.AuctionId == auctionsId);
            return context.Auctions
                .Include(a => a.AuctionBid)
                .FirstOrDefault(a => a.AuctionId == auctionsId);
            return context.Auctions
                .Where(a => a.AuctionId == auctionsId)
                .FirstOrDefault();
        }

        public Auction UpdateAuctions(Auction auction)
        {
            Auction auctionToUpdate =
               context.Auctions
               .SingleOrDefault(a => a.AuctionId == auction.AuctionId);
            if (auctionToUpdate != null)
            {
                auctionToUpdate.SellerId = auction.SellerId;
                auctionToUpdate.ProductId = auction.ProductId;
                context.SaveChanges();
            }
            return auctionToUpdate;
        }

        public Auction Create(Auction auction)
        {
            context.Auctions.Add(auction);
            context.SaveChanges();
            return auction;
        }       

        public bool DeleteAuction(int id)
        {
            Auction auctionToDelete =
               context.Auctions.FirstOrDefault(a => a.AuctionId == id);
            if (auctionToDelete == null)
            {
                return false;
            }
            context.Auctions.Remove(auctionToDelete);
            context.SaveChanges();
            return true;
        }

        //public IQueryable<Employees> GetAllEmployees()
        //{
        //    return context.Employees;
        //}

        //public IQueryable<Inventory> GetAllInventory()
        //{
        //    return context.Inventory;
        //}

        //public IQueryable<Sales> GetAllSales()
        //{
        //    return context.Sales;
        //}

        //public IQueryable<Sellers> GetAllSellers()
        //{
        //    return context.Sellers;
        //}

        //public IQueryable<Users> GetAllUsers()
        //{
        //    return context.Users;
        //}
    }
}
