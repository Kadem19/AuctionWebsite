using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace AuctionProject.Models
{
    public class Auction
    {
        //    F i e l d s  &  P r o p e r t i e s
        public int AuctionId { get; set; }

        public int SellerId { get; set; }

        public int ProductId { get; set; }
        
        public string ProductName { get; set; }
        public string ProductConsole { get; set; }
        
        public string ImgUrl { get; set; }

        public double BuyNowPrice { get; set; }

        public string Category { get; set; }
        

        [JsonIgnore]
        [System.Runtime.Serialization.IgnoreDataMember]
        public IEnumerable<AuctionBid> AuctionBid { get; set; }
        //   C o n s t r u c t o r s

        //   M e t h o d s 

    }
}