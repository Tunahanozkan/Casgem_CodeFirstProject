using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Casgem_CodeFirstProject.DAL.Entities
{
    public class Message
    {
        public int MessageID { get; set; }
        public string MessageName { get; set; }
        public string MessageMail { get; set; }
        public string MessageSubject { get; set; }
        public string MessageDescription { get; set; }
    }
}