using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCmini.Models;

namespace MVCmini.ViewModel
{   
    
    public class AddPreStuRelVM
    {
        private ClassListEntities2 entities = new ClassListEntities2();

        public PreStuRel preStuRel { get; set; }
        public Dictionary<int, string> preNamesList { get; set; }
        public Dictionary<int, string> stuNamesList { get; set; }

        public AddPreStuRelVM() { }
        public AddPreStuRelVM(int id)
        {
            preStuRel = new PreStuRel();
            foreach (var presences in entities.Presences)
            {
                preNamesList.Add(presences.PresenceID, presences.Name);
            }
            foreach (var student in entities.Students)
            {
                stuNamesList.Add(student.StudentID, student.Surname);
            }
        }

    }
}