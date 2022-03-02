using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Viddz.Models;

namespace Viddz.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            Movie movie = new Movie("Shrek in Space!");
            //var movie = new Movie() { Name = "Shrek in Space!" };

            return View(movie);
        }
    }
}