using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using TravelTripProject.Data;
using TravelTripProject.Data.Entities;

namespace TravelTripProject.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            var db = new TravelTripDbContext();

            var clist = db.Blogs.ToList();
            return View(clist);
        }


        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Blog blog)
        {
            var db = new TravelTripDbContext();

            db.Blogs.Add(blog);

            db.SaveChanges();

            return RedirectToAction ("Index", "Admin");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var db = new TravelTripDbContext();

            var deletedValues =   db.Blogs.Find(id);

            return View(deletedValues);
        }

        [HttpPost]
        public IActionResult Delete(Blog blog )
        {
            var db = new TravelTripDbContext();

            db.Blogs.Remove(blog);
            db.SaveChanges();

            return RedirectToAction("Index","Admin");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var db = new TravelTripDbContext();

            var updatedBlog =  db.Blogs.Find(id);

            return View(updatedBlog);

        }

        [HttpPost]

        public IActionResult Update(Blog blog)
        {
            var db = new TravelTripDbContext();

            db.Blogs.Update(blog);
            db.SaveChanges();

            ModelState.Clear();

            return View();
        }


    }
}
