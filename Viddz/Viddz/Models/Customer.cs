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
        //public List<Customer> Customers { get; set; }
        public bool IsSubscribedToNewsLetter { get; set; }
        //navigation property
        public MembershipType MembershipType { get; set; }
        public byte MembershipTypeId { get; set; }

        public Customer()
        {
            
        }
        public Customer(string name)
        {
            this.Name = name;
        }
    }
}