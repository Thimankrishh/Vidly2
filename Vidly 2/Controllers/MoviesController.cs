using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;
using Vidly_2.Models;
using Vidly_2.ViewModels;

namespace Vidly_2.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/random
        public ActionResult Random()
        {
            var movie = new Movie();
            return View(movie);
        }

           public ActionResult Random2()
            {
                var movie = new Movie() ;
                var customers = new List<Customer>
                {
                    new Customer{Name ="Customer 1"},
                    new Customer{Name ="Customer 2"}
                };
    
                var viewModel = new RandomMovieViewModel
                {
                   Movie = movie,
                   Customers = customers
                }; 
            return View(movie); 
        }
    
        public ActionResult Edit(int id)
        {
            
            return Content("movie" + id);
        }

        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
            pageIndex = 1;
            
            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";
            
            return Content(String.Format("pageIndex={0}&sortBy={1}",pageIndex,sortBy));
        }

        [Route("movies/released/{year}/{month}:regex(\\d{4})")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year +"/" + month);
        }

        

    }
}