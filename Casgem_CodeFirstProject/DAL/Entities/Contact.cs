using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Casgem_CodeFirstProject.DAL.Entities
{
    public class Contact
    {
        public int ContactID { get; set; }

         public string ContactNameSurname { get; set; }

         public string Mail { get; set; }

         public string Subject { get; set; }

         public string Message { get; set; }

         public string MessageDate { get; set; }
    }
}