using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuctionProject.Models
{
    public class EfInventoryRepository : IInventoryRepository
    {
        //   F i e l d s  &  P r o p e r t i e s

        private AppDbContext context;

        //   C o n s t r u c t o r s

        public EfInventoryRepository(AppDbContext context)
        {
            this.context = context;
        }

        //   M e t h o d s

        //public Inventory GetInventory(int inventoryId)
        //{
        //    return context.Inventories
        //        .Include("AuctionBid")
        //        .FirstOrDefault(i => i.ProductId == inventoryId);
        //}
        public Inventory AddItem(Inventory product)
        {
            context.Inventories.Add(product);
            context.SaveChanges();
            return product;
        }

        public Inventory UpdateInventory(Inventory product)
        {
            Inventory productToUpdate =
               context.Inventories
               .SingleOrDefault(i => i.ProductId == product.ProductId);
            if (productToUpdate != null)
            {
                productToUpdate.ProductQty = product.ProductQty;
                productToUpdate.AuctionId = product.AuctionId;
                context.SaveChanges();
            }
            return productToUpdate;
        }

        public bool DeleteItem(int inventoryId)
        {
            Inventory productToDelete =
                context.Inventories.FirstOrDefault(i => i.ProductId == inventoryId);
            if (productToDelete == null)
            {
                return false;
            }
            context.Inventories.Remove(productToDelete);
            context.SaveChanges();
            return true;
        }
    }
}
