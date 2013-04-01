using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCmini.Models
{
    public class ClassListRepository
    {
        private ClassListEntities entities = new ClassListEntities();
        //
        // Query Methods
        public IQueryable<Student> SelectAllStudents()
        {
            return entities.Students;
        }
        public IQueryable<Student> SelectStudentFromCLass(int id)
        {
            return from student in entities.Students
                   where student.ClassID == id
                   orderby student.StudentID
                   select student;
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