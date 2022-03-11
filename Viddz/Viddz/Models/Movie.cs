using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace Viddz.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Genre Genre { get; set; }
        [Required]
        [Display(Name = "Genre")]
        public byte GenreId { get; set; }

        [Display(Name = "Release Date:")]
        public DateTime? DateAdded { get; set; }
        [Display(Name = "Date Added:")]
        public DateTime? ReleaseDate { get; set; }
        [Display(Name = "Number in Stock:")]
        public byte NumberInStock { get; set; }



    }
}