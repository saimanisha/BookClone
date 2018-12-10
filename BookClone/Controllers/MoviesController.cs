using BookClone.Models;
using BookClone.viewmodels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookClone.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie()
            {
                Name = "Kedarnath"
            };
            var customers = new List<Customer> {
                new Customer { Name ="saimanisha 1"},
                new Customer{  Name="saimanisha 2"},
            };
            //ViewData["Movie"] = movie;
            //ViewBag.Movierandom = movie;
            var viewmodel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers

            };
            return View(viewmodel);
        }
        //public ActionResult Index(int? PageIndex,String Sortby)
        //{
        //    if (!PageIndex.HasValue)
        //        PageIndex = 1;

        //    if (string.IsNullOrWhiteSpace(Sortby))
        //        Sortby = "Name";

        //    return Content(string.Format("PageIndex={0}&Sortby={1}", PageIndex, Sortby));

        //}
        //public ActionResult ByReleaseDate(int year, int month)
        //{

        //    return Content(year + "this is year" + "  " + month + "this is month");
        //}
    }
    
}