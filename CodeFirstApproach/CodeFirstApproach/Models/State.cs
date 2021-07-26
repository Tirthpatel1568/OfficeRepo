using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirstApproach.Models
{
    public class State
    {
        public  int StateID { get; set; }
        public string StateName { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}