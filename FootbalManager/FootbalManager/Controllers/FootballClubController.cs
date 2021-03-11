using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FootbalManager.Models;

namespace FootbalManager.Controllers
{
    public class FootballClubController : Controller
    {
        private DBContext db = new DBContext();

        // GET: FootballClub
        public ActionResult Index()
        {
            return View(db.FootballClubModels.ToList());
        }

        // GET: FootballClub/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FootballClubModel footballClubModel = db.FootballClubModels.Find(id);
            if (footballClubModel == null)
            {
                return HttpNotFound();
            }
            return View(footballClubModel);
        }

        // GET: FootballClub/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FootballClub/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "FootballClubId,City,Name")] FootballClubModel footballClubModel)
        {
            if (ModelState.IsValid)
            {
                db.FootballClubModels.Add(footballClubModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(footballClubModel);
        }

        // GET: FootballClub/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FootballClubModel footballClubModel = db.FootballClubModels.Find(id);
            if (footballClubModel == null)
            {
                return HttpNotFound();
            }
            return View(footballClubModel);
        }

        // POST: FootballClub/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "FootballClubId,City,Name")] FootballClubModel footballClubModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(footballClubModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(footballClubModel);
        }

        // GET: FootballClub/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FootballClubModel footballClubModel = db.FootballClubModels.Find(id);
            if (footballClubModel == null)
            {
                return HttpNotFound();
            }
            return View(footballClubModel);
        }

        // POST: FootballClub/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            FootballClubModel footballClubModel = db.FootballClubModels.Find(id);
            db.FootballClubModels.Remove(footballClubModel);
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
