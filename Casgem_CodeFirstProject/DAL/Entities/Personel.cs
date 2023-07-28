using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Casgem_CodeFirstProject.DAL.Entities
{
    public class Personel
    {
        public int PersonelID { get; set; }
        public string PersonelName { get; set; }
        public string PersonelJob { get; set; }
        public string PersonelImageUrl { get; set; }
    }
}