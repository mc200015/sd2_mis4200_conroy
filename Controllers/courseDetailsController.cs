using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using sd2_mis4200_conroy.DAL;
using sd2_mis4200_conroy.Models;

namespace sd2_mis4200_conroy.Controllers
{
    public class courseDetailsController : Controller
    {
        private MIS4200Context db = new MIS4200Context();

        // GET: courseDetails
        public ActionResult Index()
        {
            var courseDetail = db.courseDetail.Include(c => c.Course).Include(c => c.Instructor);
            return View(courseDetail.ToList());
        }

        // GET: courseDetails/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            courseDetail courseDetail = db.courseDetail.Find(id);
            if (courseDetail == null)
            {
                return HttpNotFound();
            }
            return View(courseDetail);
        }

        // GET: courseDetails/Create
        public ActionResult Create()
        {
            ViewBag.courseID = new SelectList(db.Course, "courseID", "description");
            ViewBag.instructorID = new SelectList(db.Instructor, "instructorID", "firstName");
            return View();
        }

        // POST: courseDetails/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "coursedetailID,courseDescription,courseID,instructorID")] courseDetail courseDetail)
        {
            if (ModelState.IsValid)
            {
                db.courseDetail.Add(courseDetail);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.courseID = new SelectList(db.Course, "courseID", "description", courseDetail.courseID);
            ViewBag.instructorID = new SelectList(db.Instructor, "instructorID", "firstName", courseDetail.instructorID);
            return View(courseDetail);
        }

        // GET: courseDetails/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            courseDetail courseDetail = db.courseDetail.Find(id);
            if (courseDetail == null)
            {
                return HttpNotFound();
            }
            ViewBag.courseID = new SelectList(db.Course, "courseID", "description", courseDetail.courseID);
            ViewBag.instructorID = new SelectList(db.Instructor, "instructorID", "firstName", courseDetail.instructorID);
            return View(courseDetail);
        }

        // POST: courseDetails/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "coursedetailID,courseDescription,courseID,instructorID")] courseDetail courseDetail)
        {
            if (ModelState.IsValid)
            {
                db.Entry(courseDetail).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.courseID = new SelectList(db.Course, "courseID", "description", courseDetail.courseID);
            ViewBag.instructorID = new SelectList(db.Instructor, "instructorID", "firstName", courseDetail.instructorID);
            return View(courseDetail);
        }

        // GET: courseDetails/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            courseDetail courseDetail = db.courseDetail.Find(id);
            if (courseDetail == null)
            {
                return HttpNotFound();
            }
            return View(courseDetail);
        }

        // POST: courseDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            courseDetail courseDetail = db.courseDetail.Find(id);
            db.courseDetail.Remove(courseDetail);
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
