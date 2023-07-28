using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Casgem_CodeFirstProject.DAL.Entities
{
    public class Travel
    {
        public int TravelID { get; set; }
        public string TravelName { get; set; }
        public string TravelIcon { get; set; }
        public string TravelDescription { get; set; }
    }
}