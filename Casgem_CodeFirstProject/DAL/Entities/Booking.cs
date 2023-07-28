using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace Casgem_CodeFirstProject.DAL.Entities
{
    public class Booking
    {
        public int BookingID { get; set; }

        public string CustomerName { get; set; }

        public string Destination { get; set; }
        
        public string Duration { get; set; }

        public string Mail { get; set; }

        public DateTime BokingDate { get; set; }

        public string BokingStatus { get; set; }
    }
}