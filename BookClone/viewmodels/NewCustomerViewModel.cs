using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BookClone.Models;

namespace BookClone.viewmodels
{
    public class NewCustomerViewModel
    {
        public IEnumerable<MemberShipType> memeberShipTypes { get; set; }
        public Customer Customer { get; set; }
    }
}