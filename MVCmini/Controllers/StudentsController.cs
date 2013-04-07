using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCmini.Models;
using MVCmini.ViewModel;

namespace MVCmini.Controllers
{
    public class StudentsController : Controller
    {
        //
        // GET: /ClassList/
        StudentsRepository studentsRepository = new StudentsRepository();
        PreStuRelRepository preStuRelRepository = new PreStuRelRepository();
        public ActionResult Index()
        {
            var students = studentsRepository.SelectAllStudents().ToList();
            return View("Index",students);
        }

        //
        // GET: /ClassList/Details/5

        public ActionResult Details(int id)
        {
            StudentsVM student = studentsRepository.GetStudentVM(id);
            if (student == null)
            {
                return View("NotFound");
            }
            else
            {
                return View("Details",student);
            }
        }

        public ActionResult Presences(int id)
        {
            var studentPresence = studentsRepository.GetStudentPresencesVM(id).ToList();
            return View("Presences", studentPresence);

        }
        //
        // GET: /ClassList/Create

        public ActionResult Create()
        {
            Student student = new Student()
            {
                ClassID = 4
            };
            return View(student);
        } 

        //
        // POST: /ClassList/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                Student student = new Student();
                if (TryUpdateModel(student))
                {
                    studentsRepository.AddStudent(student);
                    studentsRepository.Save();
                    return RedirectToAction("Details", new { id = student.StudentID });
                }
                return View(student);
            }
            catch
            {
                return View();
            }
        }


        [HttpPost]
        public ActionResult AddPresence(FormCollection collection)
        {
            try
            {
                PreStuRel preStuRel = new PreStuRel();
                if (TryUpdateModel(preStuRel))
                {
                    preStuRelRepository.AddPreStuRel(preStuRel);
                    preStuRelRepository.Save();
                    return RedirectToAction("Presences", new { id = preStuRel.StudentsID });
                }
                return View(preStuRel);
            }
            catch
            {
                return View();
            }
        }
        //
        // GET: /ClassList/Edit/5
 
        public ActionResult Edit(int id)
        {
            StudentsVM student = studentsRepository.GetStudentVM(id);
            return View(student);
        }

        //
        // POST: /ClassList/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
                Student student = studentsRepository.GetStudent(id);
                if (TryUpdateModel(student))
                {
                    studentsRepository.Save();
                    return RedirectToAction("Details", new { id = student.StudentID });
                }
                return View(student);
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /ClassList/Delete/5
 
        public ActionResult Delete(int id)
        {
            StudentsVM student = studentsRepository.GetStudentVM(id);
            if (student == null)
                return View("NotFound");
            else
                return View(student);
        }

        //
        // POST: /ClassList/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                Student student = studentsRepository.GetStudent(id);
                if (student == null)
                    return View("NotFound");
                studentsRepository.DeleteStudent(student);
                studentsRepository.Save();
                return View("Deleted");
            }
            catch
            {
                return View();
            }

        }


        public ActionResult DropStudentClass(int id)
        {
            StudentsVM student = studentsRepository.GetStudentVM(id);
            return View(student);
        }

        //
        // POST: /ClassList/Edit/5

        [HttpPost]
        public ActionResult DropStudentClass(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
                Student student = studentsRepository.GetStudent(id);
                student.ClassID = 8;

                if (TryUpdateModel(student))
                {
                    studentsRepository.Save();
                    return RedirectToAction("Details", new { id = student.StudentID });
                }
                return View(student);
            }
            catch
            {
                return View();
            }
        }

        public ActionResult About()
        {
            return View();
        }


    }
}
