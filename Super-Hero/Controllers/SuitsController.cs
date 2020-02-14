using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Super_Hero.Data;
using Super_Hero.Models;

namespace Super_Hero.Controllers
{
    public class SuitsController : Controller
    {
        private ApplicationDbContext db;

        public SuitsController(ApplicationDbContext db)
        {
            this.db = db;
        }

        // GET: Suits
        public ActionResult Index()
        {
            return View();
        }

        // GET: Suits/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Suits/Create
        public ActionResult Create()
        {
            Suit suit = new Suit();
            return View();
        }

        // POST: Suits/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Suit suit)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Suits/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Suits/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Suits/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Suits/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}