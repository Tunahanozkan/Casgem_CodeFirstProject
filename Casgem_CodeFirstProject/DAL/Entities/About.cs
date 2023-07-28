using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Casgem_CodeFirstProject.DAL.Entities
{
    public class About
    {
        public int AboutID { get; set; }
        public string AboutName { get; set; }
        public string AboutSurname { get; set; }
        public string AboutPhone { get; set; }
        public string AboutMail { get; set; }
        public string AboutSubject { get; set; }
        public string AboutAddress { get; set;}
    }
}