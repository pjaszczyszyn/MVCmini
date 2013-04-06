using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCmini.ViewModel;

namespace MVCmini.Models
{
    public class ClassesRepository
    {
        private ClassListEntities entities = new ClassListEntities();
        //
        // Query Methods

        public IQueryable<Class> GetClasses()
        {
            return entities.Classes;
        }

        public Class GetClass(int id)
        {
            return entities.Classes.FirstOrDefault(d => d.ClassID == id);
        }

        public IQueryable<StudentsVM> GetStudentsFromCLass(int id)
        {
            return from s in entities.Students
                   where s.ClassID == id
                   orderby s.StudentID
                   select new StudentsVM() {ClassName = s.Class.ClassName, ClassID = s.ClassID, Mark = s.mark, StudentID = s.StudentID, Name = s.Name, Surname = s.Surname };
        }

        public void AddClass(Class klasa)
        {
            entities.Classes.AddObject(klasa);
        }

        public void DeleteClass(Class klasa)
        {
            entities.Classes.DeleteObject(klasa);
        }

        public void Save()
        {
            entities.SaveChanges();
        }

    }
}