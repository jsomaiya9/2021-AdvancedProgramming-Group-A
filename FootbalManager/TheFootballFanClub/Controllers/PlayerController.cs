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
    public class PlayerController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Player
        public ActionResult Index(int? id)
        {
            if (id == null)
            {
                var playerModels = db.PlayerModels.Include(p => p.FootballClub);
                return View(playerModels.ToList());
            }
            else
            {
                return View(db.PlayerModels.Where(PlayerModel => PlayerModel.FootballClubId == id).ToList());
            }
           
        }

        // GET: Player/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PlayerModel playerModel = db.PlayerModels.Find(id);
            if (playerModel == null)
            {
                return HttpNotFound();
            }
            return View(playerModel);
        }

        // GET: Player/Create
        public ActionResult Create()
        {
            ViewBag.FootballClubId = new SelectList(db.FootballClubModels, "FootballClubId", "Name");
            return View();
        }

        // POST: Player/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PlayerId,FootballClubId,Name,Followers")] PlayerModel playerModel)
        {
            if (ModelState.IsValid)
            {
                db.PlayerModels.Add(playerModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.FootballClubId = new SelectList(db.FootballClubModels, "FootballClubId", "Name", playerModel.FootballClubId);
            return View(playerModel);
        }

        // GET: Player/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PlayerModel playerModel = db.PlayerModels.Find(id);
            if (playerModel == null)
            {
                return HttpNotFound();
            }
            ViewBag.FootballClubId = new SelectList(db.FootballClubModels, "FootballClubId", "Name", playerModel.FootballClubId);
            return View(playerModel);
        }

        // POST: Player/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PlayerId,FootballClubId,Name,Followers")] PlayerModel playerModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(playerModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.FootballClubId = new SelectList(db.FootballClubModels, "FootballClubId", "Name", playerModel.FootballClubId);
            return View(playerModel);
        }

        // GET: Player/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PlayerModel playerModel = db.PlayerModels.Find(id);
            if (playerModel == null)
            {
                return HttpNotFound();
            }
            return View(playerModel);
        }

        // POST: Player/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PlayerModel playerModel = db.PlayerModels.Find(id);
            db.PlayerModels.Remove(playerModel);
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
