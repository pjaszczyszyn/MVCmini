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

        public Presence GetPresence(int id)
        {
            return entities.Presences.FirstOrDefault(d => d.PresenceID == id);
        }
    }
}