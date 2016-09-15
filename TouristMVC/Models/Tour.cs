using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TouristMVC.Models
{
    public class Tour
    {
        public int TourID { get; set; }
        public string Name { get; set; }
        public Cost Cost { get; set; }
        public ICollection<Country> Contries { get; set; }
    }
}