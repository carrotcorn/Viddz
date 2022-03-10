using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Viddz.Models;
using Viddz.ViewModels;

namespace Viddz.Controllers
{
    public class MoviesController : Controller

    {

        private ApplicationDbContext dbConnect;

        public MoviesController()
        {
            dbConnect = new ApplicationDbContext();

        }
        protected override void Dispose(bool disposing)
        {
            dbConnect.Dispose();
        }

        // GET: Movies/Random
        //CREATE GENRES TABLE
        public ViewResult AllMovies()
        {
            var movies = dbConnect.Movies.Include(m => m.Genre).ToList();
            return View(movies);
        }

        public ActionResult MovieInfo(int id)
        {
            var movie = dbConnect.Movies.Include(m => m.Genre).SingleOrDefault(m => m.Id == id);

            if (movie == null)
                return HttpNotFound();

            return View(movie);
        }


        [Route("movies/released/{year:regex(\\d{4})}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }
        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }

        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
            {
                pageIndex = 1;
            }
            if (String.IsNullOrWhiteSpace(sortBy))
            {
                sortBy = "Name";
            }
            return Content(String.Format($"pageIndex={pageIndex}&sortBy={sortBy}"));
        }

        //public ActionResult Random()
        //{
        //    Movie movie = new Movie("Shrek in Space!");
        //    List<Customer> customers = new List<Customer>
        //    {
        //        new Customer { Name = "Customer1"},
        //        new Customer { Name = "Customer2"},

        //    };
        //    var viewModel = new RandomMovieViewModel
        //    {
        //        Movie = movie,
        //        Customers = customers
        //    };


        //    return View(viewModel);
        //}
    }
}