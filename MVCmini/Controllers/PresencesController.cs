using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCmini.Models;

namespace MVCmini.Controllers
{
    public class PresencesController : Controller
    {

        PresencesRepository presencesRepository = new PresencesRepository();
        //
        // GET: /Presences/

        public ActionResult Index()
        {
            var presences = presencesRepository.GetPresences().ToList();
            return View("Index", presences);
        }

        //
        // GET: /Presences/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Presences/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Presences/Create

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
        // GET: /Presences/Edit/5
 
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Presences/Edit/5

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
        // GET: /Presences/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Presences/Delete/5

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
