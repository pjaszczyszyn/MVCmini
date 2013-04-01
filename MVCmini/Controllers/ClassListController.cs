using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCmini.Models;

namespace MVCmini.Controllers
{
    public class ClassListController : Controller
    {
        //
        // GET: /ClassList/
        ClassListRepository classListRepository = new ClassListRepository();
        public ActionResult Index()
        {
            var students = classListRepository.SelectAllStudents().ToList();
            return View("Index",students);
        }

        //
        // GET: /ClassList/Details/5

        public ActionResult Details(int id)
        {
            Student student = classListRepository.GetStudent(id);
            if (student == null)
            {
                return View("NotFound");
            }
            else
            {
                return View("Details",student);
            }
        }

        //
        // GET: /ClassList/Create

        public ActionResult Create()
        {
            Student student = new Student()
            {
                ClassID = 1
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
                    classListRepository.AddStudent(student);
                    classListRepository.Save();
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
        // GET: /ClassList/Edit/5
 
        public ActionResult Edit(int id)
        {
            Student student = classListRepository.GetStudent(id);
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
                Student student = classListRepository.GetStudent(id);
                if (TryUpdateModel(student))
                {
                    classListRepository.Save();
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
            Student student = classListRepository.GetStudent(id);
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

                Student student = classListRepository.GetStudent(id);
                if (student == null)
                    return View("NotFound");
                classListRepository.DeleteStudent(student);
                classListRepository.Save();
                return View("Deleted");
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
