using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Microsoft.AspNet;
using Microsoft.AspNet.Identity.EntityFramework;

namespace BookClone.Models
{
    public class ApplicationDbContext  : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
           : base("Dbconnection", throwIfV1Schema: false)
        {

        }
        public DbSet<Movie> movies { get; set; }
        public DbSet<Customer> customers { get; set; }
        public DbSet<MemberShipType> memberShipType { get; set; }
        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}