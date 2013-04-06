using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCmini.ViewModel
{
    public class PresencesVM
    {
        public DateTime Date { get; set; }
    }

    public class StudentPresenceVM
    {
        public int PresenceID { get; set; }
        public int StudentID { get; set; }
        public DateTime Date { get; set; }
        public int Value { get; set; }
        public string StudentName { get; set; }
        public string StudentSurname { get; set; }
    }
}