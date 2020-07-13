using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace AuctionProject.Models
{
    [Table("User")]
    public class User
    {
        //   F i e l d s  &  P r o p e r t i e s
        public int Id { get; set; }

        public string Fname { get; set; }

        public string Lname { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string UserAddress { get; set; }

        public string UserPhone { get; set; }

        //   C o n s t r u c t o r s

        //   M e t h o d s
    }
}
