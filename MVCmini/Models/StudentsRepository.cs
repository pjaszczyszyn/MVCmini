using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCmini.ViewModel;

namespace MVCmini.Models
{
    public class StudentsRepository
    {
        private ClassListEntities2 entities = new ClassListEntities2();
        //
        // Query Methods

        public IQueryable<StudentsVM> SelectAllStudents()
        {
            return from s in entities.Students
                   orderby s.Surname
                   select new StudentsVM() {StudentID = s.StudentID,ClassID = s.ClassID, ClassName = s.Class.ClassName, Name = s.Name,Surname = s.Surname, Mark = s.mark};
        }

        public StudentsVM GetStudentVM(int id)
        {
            return (from s in entities.Students
                   orderby s.Surname
                   where s.StudentID == id
                    select new StudentsVM() { StudentID = s.StudentID, ClassID = s.ClassID, ClassName = s.Class.ClassName, Name = s.Name, Surname = s.Surname, Mark = s.mark }).FirstOrDefault();
       
        }

        public  IQueryable<StudentPresenceVM> GetStudentPresencesVM(int id)
        {

            return (from p in entities.Presences
                    join sp in entities.PreStuRels on p.PresenceID equals sp.PresencesID
                    join s in entities.Students on sp.StudentsID equals s.StudentID
                    orderby s.ClassID
                    where s.StudentID == id
                    select new StudentPresenceVM() { StudentID = s.StudentID, Date = p.Date, PresenceID = p.PresenceID,StudentName = s.Name, StudentSurname = s.Surname, Value = p.Value  });

        }

        public Student GetStudent(int id)
        {
            return entities.Students.FirstOrDefault(d => d.StudentID == id);

        }
        //
        // Insert/Delete Methods
        public void AddStudent(Student student)
        {
            entities.Students.AddObject(student);
        }

        public void DeleteStudent(Student student)
        {
            foreach (var presence in student.PreStuRels)
            {
                entities.PreStuRels.DeleteObject(presence);
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