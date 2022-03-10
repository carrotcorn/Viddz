using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Viddz.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }


        //displays name of the label when referenced in the view
        [Display(Name = "Date of Birth")] //
        public DateTime? Birthday { get; set; }
        public bool IsSubscribedToNewsLetter { get; set; }


        ////navigation property
        public MembershipType MembershipType { get; set; }
        [Display(Name = "Membership Type")]
        public byte MembershipTypeId { get; set; }

    }
}