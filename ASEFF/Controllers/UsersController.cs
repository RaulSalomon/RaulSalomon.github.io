using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ASEFF.Models;

namespace ASEFF.Controllers
{
    public class UsersController : Controller
    {
        private ASSEFFEntities db = new ASSEFFEntities();

        // GET: Users
        public ActionResult Index()
        {
            var user = db.User.Include(u => u.Alumno).Include(u => u.Rol);
            return View(user.ToList());
        }

        // GET: Users/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User user = db.User.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        // GET: Users/Create
        public ActionResult Create()
        {
            ViewBag.ID_ALUMNO = new SelectList(db.Alumno, "MATRICULA", "NOMBRE");
            ViewBag.ID_ROL = new SelectList(db.Rol, "ID", "ROL1");
            return View();
        }

        // POST: Users/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,EMAIL,PASSWORD,ID_ALUMNO,ID_ROL")] User user)
        {
            if (ModelState.IsValid)
            {
                db.User.Add(user);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ID_ALUMNO = new SelectList(db.Alumno, "MATRICULA", "NOMBRE", user.ID_ALUMNO);
            ViewBag.ID_ROL = new SelectList(db.Rol, "ID", "ROL1", user.ID_ROL);
            return View(user);
        }

        // GET: Users/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User user = db.User.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            ViewBag.ID_ALUMNO = new SelectList(db.Alumno, "MATRICULA", "NOMBRE", user.ID_ALUMNO);
            ViewBag.ID_ROL = new SelectList(db.Rol, "ID", "ROL1", user.ID_ROL);
            return View(user);
        }

        // POST: Users/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,EMAIL,PASSWORD,ID_ALUMNO,ID_ROL")] User user)
        {
            if (ModelState.IsValid)
            {
                db.Entry(user).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ID_ALUMNO = new SelectList(db.Alumno, "MATRICULA", "NOMBRE", user.ID_ALUMNO);
            ViewBag.ID_ROL = new SelectList(db.Rol, "ID", "ROL1", user.ID_ROL);
            return View(user);
        }

        // GET: Users/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User user = db.User.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        // POST: Users/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            User user = db.User.Find(id);
            db.User.Remove(user);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Profile()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AuthenticatedUser(string Email,string Password)
        {
            return View();
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
