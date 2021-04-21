using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TheFootballFanClub.Models;

namespace TheFootballFanClub.Controllers
{
    public class LeagueTablesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: LeagueTables
        public ActionResult Index()
        {
            return View(db.LeagueTablesModels.ToList());
        }

        // GET: LeagueTables/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LeagueTablesModel leagueTablesModel = db.LeagueTablesModels.Find(id);
            if (leagueTablesModel == null)
            {
                return HttpNotFound();
            }
            return View(leagueTablesModel);
        }

        // GET: LeagueTables/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LeagueTables/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "LeagueId,Name")] LeagueTablesModel leagueTablesModel)
        {
            if (ModelState.IsValid)
            {
                db.LeagueTablesModels.Add(leagueTablesModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(leagueTablesModel);
        }

        // GET: LeagueTables/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LeagueTablesModel leagueTablesModel = db.LeagueTablesModels.Find(id);
            if (leagueTablesModel == null)
            {
                return HttpNotFound();
            }
            return View(leagueTablesModel);
        }

        // POST: LeagueTables/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "LeagueId,Name")] LeagueTablesModel leagueTablesModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(leagueTablesModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(leagueTablesModel);
        }

        // GET: LeagueTables/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LeagueTablesModel leagueTablesModel = db.LeagueTablesModels.Find(id);
            if (leagueTablesModel == null)
            {
                return HttpNotFound();
            }
            return View(leagueTablesModel);
        }

        // POST: LeagueTables/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            LeagueTablesModel leagueTablesModel = db.LeagueTablesModels.Find(id);
            db.LeagueTablesModels.Remove(leagueTablesModel);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
