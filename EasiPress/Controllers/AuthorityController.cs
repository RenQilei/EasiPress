using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using EasiPress.Models;

namespace EasiPress.Controllers
{
    public class AuthorityController : Controller
    {
        private EasiPressContext db = new EasiPressContext();

        // GET: /Authority/
        public ActionResult Index()
        {
            return View(db.Authorities.ToList());
        }

        // GET: /Authority/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Authority authority = db.Authorities.Find(id);
            if (authority == null)
            {
                return HttpNotFound();
            }
            return View(authority);
        }

        // GET: /Authority/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Authority/Create
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="Id,Title,Level")] Authority authority)
        {
            if (ModelState.IsValid)
            {
                db.Authorities.Add(authority);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(authority);
        }

        // GET: /Authority/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Authority authority = db.Authorities.Find(id);
            if (authority == null)
            {
                return HttpNotFound();
            }
            return View(authority);
        }

        // POST: /Authority/Edit/5
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="Id,Title,Level")] Authority authority)
        {
            if (ModelState.IsValid)
            {
                db.Entry(authority).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(authority);
        }

        // GET: /Authority/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Authority authority = db.Authorities.Find(id);
            if (authority == null)
            {
                return HttpNotFound();
            }
            return View(authority);
        }

        // POST: /Authority/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Authority authority = db.Authorities.Find(id);
            db.Authorities.Remove(authority);
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
