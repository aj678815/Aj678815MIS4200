using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Aj678815MIS4200.Models;
using Aj678815MIS4200.Models.DAL;

namespace Aj678815MIS4200.Controllers
{
    public class AppointmentDetailsController : Controller
    {
        private MIS4200Context db = new MIS4200Context();

        // GET: AppointmentDetails
        public ActionResult Index()
        {
            var appointmentDetails = db.AppointmentDetails.Include(a => a.pet);
            return View(appointmentDetails.ToList());
        }

        // GET: AppointmentDetails/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AppointmentDetails appointmentDetails = db.AppointmentDetails.Find(id);
            if (appointmentDetails == null)
            {
                return HttpNotFound();
            }
            return View(appointmentDetails);
        }

        // GET: AppointmentDetails/Create
        public ActionResult Create()
        {
            ViewBag.petId = new SelectList(db.Pets, "petId", "description");
            return View();
        }

        // POST: AppointmentDetails/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "appointmentDetailsId,qtyVisits,price,appiontmentId,petId")] AppointmentDetails appointmentDetails)
        {
            if (ModelState.IsValid)
            {
                db.AppointmentDetails.Add(appointmentDetails);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.petId = new SelectList(db.Pets, "petId", "description", appointmentDetails.petId);
            return View(appointmentDetails);
        }

        // GET: AppointmentDetails/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AppointmentDetails appointmentDetails = db.AppointmentDetails.Find(id);
            if (appointmentDetails == null)
            {
                return HttpNotFound();
            }
            ViewBag.petId = new SelectList(db.Pets, "petId", "description", appointmentDetails.petId);
            return View(appointmentDetails);
        }

        // POST: AppointmentDetails/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "appointmentDetailsId,qtyVisits,price,appiontmentId,petId")] AppointmentDetails appointmentDetails)
        {
            if (ModelState.IsValid)
            {
                db.Entry(appointmentDetails).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.petId = new SelectList(db.Pets, "petId", "description", appointmentDetails.petId);
            return View(appointmentDetails);
        }

        // GET: AppointmentDetails/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AppointmentDetails appointmentDetails = db.AppointmentDetails.Find(id);
            if (appointmentDetails == null)
            {
                return HttpNotFound();
            }
            return View(appointmentDetails);
        }

        // POST: AppointmentDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AppointmentDetails appointmentDetails = db.AppointmentDetails.Find(id);
            db.AppointmentDetails.Remove(appointmentDetails);
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
