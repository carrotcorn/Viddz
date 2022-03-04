using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Viddz.Models;

namespace Viddz.ViewModels
{
    public class CustomerViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Customer> Customers { get; set; }

        public CustomerViewModel()
        {

        }
        public CustomerViewModel(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

    }
}