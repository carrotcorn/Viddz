using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Viddz.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Movie() { }
        public Movie(string name)
        {
            this.Name = name;
        }
    }
}