using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Viddz.Models;

namespace Viddz.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }

        public RandomMovieViewModel() { }
        public RandomMovieViewModel(List<Customer> customers)
        {
            this.Customers = customers;
        }
    }
}