using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

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

        public IQueryable<Student> GetStudentsFromCLass(int id)
        {
            return from student in entities.Students
                   where student.ClassID == id
                   orderby student.StudentID
                   select student;
        }
    }
}