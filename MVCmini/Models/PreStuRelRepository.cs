using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCmini.ViewModel;

namespace MVCmini.Models
{
    public class PreStuRelRepository
    {
        private ClassListEntities2 entities = new ClassListEntities2();


        public void AddPreStuRel(PreStuRel preStuRel)
        {
            entities.PreStuRels.AddObject(preStuRel);
        }
        public void Save()
        {
            entities.SaveChanges();
        }
    }

}