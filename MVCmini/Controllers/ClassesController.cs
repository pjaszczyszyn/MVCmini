using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCmini.Models;

namespace MVCmini.Controllers
{
    public class ClassesController : Controller
    {
        //
        // GET: /Classes/
        ClassesRepository classesRepository = new ClassesRepository();
        StudentsRepository StudentsRepository = new StudentsRepository();
        public ActionResult Index()
        {
            var classes = classesRepository.GetClasses().ToList();
            return View("Index", classes);
        }


        //
        // GET: /Classes/Details/5

        public ActionResult Details(int id)
        {
            var students = classesRepository.GetStudentsFromCLass(id).ToList();
            return View("Details", students);

        }

        //
        // GET: /Classes/Create

        public ActionResult Create()
        {
            Class klasa = new Class();
            return View(klasa);
        } 

        //
        // POST: /Classes/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                Class klasa = new Class();
                if (TryUpdateModel(klasa))
                {
                    classesRepository.AddClass(klasa);
                    classesRepository.Save();
                    return RedirectToAction("Details", new { id = klasa.ClassID });
                }
                return View(klasa);
            }
            catch
            {
                return View();
            }
        }
        
        //
        // GET: /Classes/Edit/5
 
        public ActionResult Edit(int id)
        {
            // TODO: Add insert logic here
            Class klasa = classesRepository.GetClass(id);
            return View(klasa);
        }

        //
        // POST: /Classes/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
                Class klasa = classesRepository.GetClass(id);
                if (TryUpdateModel(klasa))
                {
                    classesRepository.Save();
                    return RedirectToAction("Details", new { id = klasa.ClassID });
                }
                return View(klasa);
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Classes/Delete/5
 
        public ActionResult Delete(int id)
        {
            Class klasa = classesRepository.GetClass(id);
            if (klasa == null)
                return View("NotFound");
            else
                return View(klasa);
        }

        //
        // POST: /Classes/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                Class klasa = classesRepository.GetClass(id);
                if (klasa == null)
                    return View("NotFound");
                classesRepository.DeleteClass(klasa);
                classesRepository.Save();
                return View("Deleted");
            }
            catch
            {
                return View();
            }
        }

    }
}
