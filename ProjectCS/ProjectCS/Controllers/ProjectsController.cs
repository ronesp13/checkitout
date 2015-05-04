using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Helpers;
using System.Web.Mvc;
using ProjectCS.Models;

namespace ProjectCS.Controllers
{
    public class ProjectsController : Controller
    {
        private readonly ApplicationDbContext _db = new ApplicationDbContext();

        // GET: Projects
        public ActionResult Index()
        {
            return View(_db.Projects.ToList());
        }

        public ActionResult Search(int value, string title)
        {
            var projects = from p in _db.Projects select p;
            switch (value)
            {
                case 1:
                    projects = projects.OrderByDescending(p => p.Likes.Count);
                    break;
                case 2:
                    projects = projects.OrderByDescending(p => p.Followers.Count);
                    break;
                case 3:
                    projects = projects.OrderByDescending(p => p.CreatedAt);
                    break;
                default:
                    projects = projects.OrderBy(p => p.Title);
                    break;
            }
            // this logic should be moved when someone figures out how to create json objects properly.
            var projectsJson = new List<object>();
            var test = projects.ToList();
            foreach (var project in test)
            {
                projectsJson.Add(new { id = project.Id, title = project.Title, cover_url = project.CoverUrl, likes = project.Likes.Count, followers = project.Followers.Count});
            }
            return Json(new { title = title, projects = projectsJson}, JsonRequestBehavior.AllowGet);
        }

        // GET: Projects/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var project = _db.Projects.Find(id);
            if (project == null)
            {
                return HttpNotFound();
            }
            return View(project);
        }

        // GET: Projects/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Projects/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Title,Description,Genre,Language,CreatedAt,EstimatedCost,CoverUrl,CoverUrlSmall,IsPublic")] Project project)
        {
            if (ModelState.IsValid)
            {
                _db.Projects.Add(project);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(project);
        }

        // GET: Projects/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Project project = _db.Projects.Find(id);
            if (project == null)
            {
                return HttpNotFound();
            }
            return View(project);
        }

        // POST: Projects/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Title,Description,Genre,Language,CreatedAt,EstimatedCost,CoverUrl,CoverUrlSmall,IsPublic")] Project project)
        {
            if (ModelState.IsValid)
            {
                _db.Entry(project).State = EntityState.Modified;
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(project);
        }

        // GET: Projects/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Project project = _db.Projects.Find(id);
            if (project == null)
            {
                return HttpNotFound();
            }
            return View(project);
        }

        // POST: Projects/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Project project = _db.Projects.Find(id);
            _db.Projects.Remove(project);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Follow(int id)
        {
            if (!Request.IsAuthenticated)
            {
                return Json(new {status = 401});
            }
            var user = (ApplicationUser) ViewBag.CurrentUser;
            var project = _db.Projects.Find(id);

            project.Followers.Add(user);
            _db.SaveChanges();
            return Json(new {status = 200, followers = project.Followers.Count});
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
