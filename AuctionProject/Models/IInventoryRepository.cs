using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuctionProject.Models
{
    public interface IInventoryRepository
    {
        //   C r e a t e
        
        Inventory AddItem(Inventory product);

        //   R e a d
        
       // Inventory GetInventory(Inventory product);

        //   U p d a t e

        Inventory UpdateInventory(Inventory product);

        //   D e l e t e

        // Inventory DeleteItem(Inventory product);
    }
}
