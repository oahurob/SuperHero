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
            var Suits = db.Suits;
            return View(Suits);
        }

        // GET: Suits/Details/5
        public ActionResult Details(int id)
        {
            Suit suit = db.Suits.Find(id);
            return View(suit);
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
                db.Suits.Add(suit);
                db.SaveChanges();
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
        public ActionResult Edit(int id, Suit suit)
        {
            try
            {
                // TODO: Add update logic here
                Suit editSuit = db.Suits.Find(id);
                suit.SuitNumber = editSuit.SuitNumber;
                suit.SuitName = editSuit.SuitName;
                suit.Specialty = editSuit.Specialty;
                db.SaveChanges();
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
        public ActionResult Delete(int id, Suit suit)
        {
            try
            {
                // TODO: Add delete logic here
                Suit suitToRemove = db.Suits.Find(id); //?
                db.Suits.Remove(suitToRemove); //?
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}