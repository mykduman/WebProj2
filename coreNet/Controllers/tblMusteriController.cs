using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using coreNet;

namespace coreNet.Controllers
{
    public class tblMusteriController : Controller
    {
        private webDatabaseEntities db = new webDatabaseEntities();

        // GET: tblMusteri
        public ActionResult Index()
        {
            return View(db.tblMusteri.ToList());
        }

        // GET: tblMusteri/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblMusteri tblMusteri = db.tblMusteri.Find(id);
            if (tblMusteri == null)
            {
                return HttpNotFound();
            }
            return View(tblMusteri);
        }

        // GET: tblMusteri/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: tblMusteri/Create
        // Aşırı gönderim saldırılarından korunmak için, lütfen bağlamak istediğiniz belirli özellikleri etkinleştirin, 
        // daha fazla bilgi için https://go.microsoft.com/fwlink/?LinkId=317598 sayfasına bakın.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MusteriID,musteriAd,musteriSoyad,musteriMail,musteriTel,musteriMesaj,musteriIlce,musteriAtikTuru,musteriMiktar")] tblMusteri tblMusteri)
        {
            if (ModelState.IsValid)
            {
                db.tblMusteri.Add(tblMusteri);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tblMusteri);
        }

        // GET: tblMusteri/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblMusteri tblMusteri = db.tblMusteri.Find(id);
            if (tblMusteri == null)
            {
                return HttpNotFound();
            }
            return View(tblMusteri);
        }

        // POST: tblMusteri/Edit/5
        // Aşırı gönderim saldırılarından korunmak için, lütfen bağlamak istediğiniz belirli özellikleri etkinleştirin, 
        // daha fazla bilgi için https://go.microsoft.com/fwlink/?LinkId=317598 sayfasına bakın.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MusteriID,musteriAd,musteriSoyad,musteriMail,musteriTel,musteriMesaj,musteriIlce,musteriAtikTuru,musteriMiktar")] tblMusteri tblMusteri)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tblMusteri).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tblMusteri);
        }

        // GET: tblMusteri/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblMusteri tblMusteri = db.tblMusteri.Find(id);
            if (tblMusteri == null)
            {
                return HttpNotFound();
            }
            return View(tblMusteri);
        }

        // POST: tblMusteri/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tblMusteri tblMusteri = db.tblMusteri.Find(id);
            db.tblMusteri.Remove(tblMusteri);
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
