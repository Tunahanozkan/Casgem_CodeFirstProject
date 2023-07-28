using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Casgem_CodeFirstProject.DAL.Entities
{
    public class Trip
    {
        public int TripID { get; set; }
        public string TripName { get; set; }
        public string TripDescription { get; set; }
        public string TripImageUrl { get; set; }
    }
}