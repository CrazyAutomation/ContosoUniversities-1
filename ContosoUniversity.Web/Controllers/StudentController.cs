using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using ContosoUniversity.Entities;
using ContosoUniversity.Web.DataContexts;

namespace ContosoUniversity.Web.Controllers
{
    public class StudentController : Controller
    {
        private readonly UniversityDb _universityDb = new UniversityDb();

        // GET: Student
        public ActionResult Index()
        {
            return View(_universityDb.Students.ToList());
        }

        // GET: Student/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var student = _universityDb.Students
                .Include(e => e.Enrollments.Select(c => c.Course))
                .FirstOrDefault(s => s.StudentId == id);

            if (student == null)
            {
                return HttpNotFound();
            }

            return View(student);
        }

        // GET: Student/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Student/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "FirstName,LastName,EnrollmentDate")] Student student)
        {
            if (!ModelState.IsValid)
            {
                return View(student);
            }

            _universityDb.Students.Add(student);
            _universityDb.SaveChanges();

            return RedirectToAction("Index");
        }

        // GET: Student/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var student = _universityDb.Students.Find(id);

            if (student == null)
            {
                return HttpNotFound();
            }

            return View(student);
        }

        // POST: Student/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for    
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "StudentId,FirstName,LastName,EnrollmentDate")] Student student)
        {
            if (!ModelState.IsValid)
            {
                return View(student);
            }

            _universityDb.Entry(student).State = EntityState.Modified;
            _universityDb.SaveChanges();

            return RedirectToAction("Index");
        }

        // GET: Student/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var student = _universityDb.Students.Find(id);

            if (student == null)
            {
                return HttpNotFound();
            }

            return View(student);
        }

        // POST: Student/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var student = _universityDb.Students.Find(id);

            if (student == null)
            {
                return HttpNotFound();
            }

            _universityDb.Students.Remove(student);
            _universityDb.SaveChanges();

            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _universityDb.Dispose();
            }

            base.Dispose(disposing);
        }
    }
}