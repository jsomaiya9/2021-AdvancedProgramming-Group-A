using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FootbalManager.Models;
using TheFootballFanClub.Models;

namespace TheFootballFanClub.Controllers
{
    public class PersonalDetailsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: PersonalDetails
        public ActionResult Index()
        {
            var personalDetailsModels = db.PersonalDetailsModels.Include(p => p.User);
            return View(personalDetailsModels.ToList());
        }

        // GET: PersonalDetails/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PersonalDetailsModel personalDetailsModel = db.PersonalDetailsModels.Find(id);
            if (personalDetailsModel == null)
            {
                return HttpNotFound();
            }
            return View(personalDetailsModel);
        }

        // GET: PersonalDetails/Create
        public ActionResult Create()
        {
            ViewBag.UserId = new SelectList(db.UserModels, "UserId", "Username");
            return View();
        }

        // POST: PersonalDetails/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PersonalDetailsId,Name,LastName,AddressLine1,AddressLine2,City,PostCode,Email,UserId")] PersonalDetailsModel personalDetailsModel)
        {
            if (ModelState.IsValid)
            {
                db.PersonalDetailsModels.Add(personalDetailsModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.UserId = new SelectList(db.UserModels, "UserId", "Username", personalDetailsModel.UserId);
            return View(personalDetailsModel);
        }

        // GET: PersonalDetails/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PersonalDetailsModel personalDetailsModel = db.PersonalDetailsModels.Find(id);
            if (personalDetailsModel == null)
            {
                return HttpNotFound();
            }
            ViewBag.UserId = new SelectList(db.UserModels, "UserId", "Username", personalDetailsModel.UserId);
            return View(personalDetailsModel);
        }

        // POST: PersonalDetails/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PersonalDetailsId,Name,LastName,AddressLine1,AddressLine2,City,PostCode,Email,UserId")] PersonalDetailsModel personalDetailsModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(personalDetailsModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.UserId = new SelectList(db.UserModels, "UserId", "Username", personalDetailsModel.UserId);
            return View(personalDetailsModel);
        }

        // GET: PersonalDetails/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PersonalDetailsModel personalDetailsModel = db.PersonalDetailsModels.Find(id);
            if (personalDetailsModel == null)
            {
                return HttpNotFound();
            }
            return View(personalDetailsModel);
        }

        // POST: PersonalDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PersonalDetailsModel personalDetailsModel = db.PersonalDetailsModels.Find(id);
            db.PersonalDetailsModels.Remove(personalDetailsModel);
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
