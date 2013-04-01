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
            return View();
        } 

        //
        // POST: /Classes/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
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
            return View();
        }

        //
        // POST: /Classes/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
 
                return RedirectToAction("Index");
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
            return View();
        }

        //
        // POST: /Classes/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
