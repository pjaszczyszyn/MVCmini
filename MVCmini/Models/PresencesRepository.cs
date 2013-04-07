using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCmini.ViewModel;

namespace MVCmini.Models
{
    public class PresencesRepository
    {


        private ClassListEntities2 entities = new ClassListEntities2();

        public IQueryable<Presence> GetPresences()
        {
            return entities.Presences;
        }

        public IQueryable<PresencesVM> GetPresencesDates()
        {
                   return from s in entities.Presences
                   orderby s.Date
                   group s by s.Date into g
                   select new PresencesVM() {Date = g.Key };
        }

        public IQueryable<StudentPresenceVM> GetStudentPresencesVMList(int id)
        {

            return (from p in entities.Presences
                    join sp in entities.PreStuRels on p.PresenceID equals sp.PresencesID
                    join s in entities.Students on sp.StudentsID equals s.StudentID
                    orderby p.Date
                    where p.PresenceID == id
                    select new StudentPresenceVM() { StudentID = s.StudentID, Date = p.Date, PresenceID = p.PresenceID, StudentName = s.Name, StudentSurname = s.Surname, Value = p.Value });

        }

        public Presence GetPresence(int id)
        {
            return entities.Presences.FirstOrDefault(d => d.PresenceID == id);
        }
    }
}