using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Casgem_CodeFirstProject.DAL.Entities
{
    public class Holiday
    {
        public int HolidayID { get; set; }
        public string HolidayName { get; set; }
        public string HolidayDescription { get; set; }
        public string HolidayImageUrl { get; set; }
    }
}