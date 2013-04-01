using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCmini.Models
{
    public class StudentsRepository
    {
        private ClassListEntities entities = new ClassListEntities();
        //
        // Query Methods

        public IQueryable<Student> SelectAllStudents()
        {
            return entities.Students;
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