using BookClone.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using BookClone.viewmodels;

namespace BookClone.Controllers
{
    public class CustomerController : Controller
    {

        private ApplicationDbContext _context;
        public CustomerController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult New()
        {
            var membershiptype = _context.memberShipType.ToList();
            // customers = _context.customers.Include(c => c.MemberShipType).ToList();
            var viewmodels = new NewCustomerViewModel
            {
                memeberShipTypes = membershiptype
            };
            
            return View();
        }

        [HttpPost]
        public ActionResult Create(NewCustomerViewModel newCustomerViewModel)
        {
            return View();
        }

        // GET: Customer
        public ActionResult Index()
        {
           
            var customers = GetCustomers();
              // customers = _context.customers.Include(c => c.MemberShipType).ToList();
           
            return View(customers);
        }
        public IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>
                {
                new Customer{  Id=1, Name="saimanisha"  ,MembershipTypeId=1},
               // new Customer{Id=2,Name="saicharan",MembershipTypeId=2}
                
                };

        }

        public ActionResult Deatils(int id)
        {

            //var customer = _context.customers.SingleOrDefault(c => c.Id == id);
            var customer = new Customer { Id = 1, Name = "saimanisha", MembershipTypeId = 1 };
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }
    }
}