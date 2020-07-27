using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AuctionProject.Models
{
    [Table("Inventory")]
    public class Inventory
    {
        //   F i e l d s 
        [Key]
        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public int ProductQty { get; set; }

        public int AuctionId { get; set; }

        //   C o n s t r u c t o r s

        //   M e t h o d s
    }
}
