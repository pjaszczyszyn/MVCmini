using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCmini.ViewModel
{
    public class StudentsVM
    {
        public int StudentID { get; set; }
        public int ClassID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int? Mark { get; set; }
        public string ClassName { get; set; }
    }
}