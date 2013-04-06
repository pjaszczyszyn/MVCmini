using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCmini.ViewModel;

namespace MVCmini.Models
{
    public class StudentsRepository
    {
        private ClassListEntities entities = new ClassListEntities();
        //
        // Query Methods

        public IQueryable<StudentsVM> SelectAllStudents()
        {
            return from s in entities.Students
                   orderby s.Surname
                   select new StudentsVM() {StudentID = s.StudentID,ClassID = s.ClassID, ClassName = s.Class.ClassName, Name = s.Name,Surname = s.Surname, Mark = s.mark};
        }

        public StudentsVM GetStudent(int id)
        {
            return (from s in entities.Students
                   orderby s.Surname
                   where s.StudentID == id
                    select new StudentsVM() { StudentID = s.StudentID, ClassID = s.ClassID, ClassName = s.Class.ClassName, Name = s.Name, Surname = s.Surname, Mark = s.mark }).FirstOrDefault();
       
        }

        //
        // Insert/Delete Methods
        public void AddStudent(Student student)
        {
            entities.Students.AddObject(student);
        }

        public void DeleteStudent(Student student)
        {
            foreach (var presence in student.Presences)
            {
                entities.Presences.DeleteObject(presence);
            }
            entities.Students.DeleteObject(student);
        }
        //
        // Persistence
        public void Save()
        {
            entities.SaveChanges();
        }
    }
}