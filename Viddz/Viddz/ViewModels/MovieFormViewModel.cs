using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Viddz.Models;

namespace Viddz.ViewModels
{
    public class MovieFormViewModel
    {
        public IEnumerable<Genre> GenreTypes { get; set; }
        public Movie Movie { get; set; }


    }
}