using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using TravelTripProject.Data;
using TravelTripProject.Data.Entities;

namespace TravelTripProject.Controllers
{
    [Authorize(AuthenticationSchemes = "AC1999")]
    [Authorize(Roles = "Admin")]
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
            if (ModelState.IsValid)
            {
                var db = new TravelTripDbContext();

                db.Blogs.Add(blog);

                db.SaveChanges();

                return RedirectToAction("Index", "Admin");
            }
            else
            {
                ViewBag.Message = "Eksik yada hatalı değerleriniz bulunmaktadır..";
                return View();
            }
        }




        [HttpGet]
        public IActionResult Delete(int id)
        {
            var db = new TravelTripDbContext();

            var deletedValues = db.Blogs.Find(id);

            return View(deletedValues);
        }

        [HttpPost]
        public IActionResult Delete(Blog blog)
        {
            var db = new TravelTripDbContext();

            db.Blogs.Remove(blog);
            db.SaveChanges();

            return RedirectToAction("Index", "Admin");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {


            var db = new TravelTripDbContext();

            var updatedBlog = db.Blogs.Find(id);

            return View(updatedBlog);

        }

        [HttpPost]

        public IActionResult Update(Blog blog)
        {

            if (ModelState.IsValid)
            {
                var db = new TravelTripDbContext();
                db.Blogs.Update(blog);
                db.SaveChanges();
                ModelState.Clear();
                return RedirectToAction("Index", "Admin");
            }
            return View();
        }

        // Comment İşlemleri >>>>>>>>

        [HttpGet]
        public IActionResult CommentList()
        {
            var db = new TravelTripDbContext();

            var CommentList = db.Comments.Include(x => x.Blog).ToList();

            return View(CommentList);
        }
        public IActionResult DeleteComment(int id)
        {
            var db = new TravelTripDbContext();

            var c = db.Comments.Find(id);

            db.Comments.Remove(c);
            db.SaveChanges();

            return RedirectToAction("CommentList", "Admin");
        }

        [HttpGet]
        public IActionResult UpdateComment(int id)
        {
            var db = new TravelTripDbContext();
            var UpdateComment = db.Comments.Find(id);
            return View(UpdateComment);
        }

        [HttpPost]
        public IActionResult UpdateComment(Comment comment)
        {
            if (ModelState.IsValid)
            {
                var db = new TravelTripDbContext();
                db.Comments.Update(comment);
                db.SaveChanges();
                ModelState.Clear();
                return RedirectToAction("CommentList", "Admin");

            }
            return View();

        }

        [HttpGet]
        public IActionResult ContactUsList()
        {
            var db = new TravelTripDbContext();
            var values = db.Contacts.ToList();
            return View(values);
        }


        public IActionResult DeleteContactUs(int id)
        {
            var db = new TravelTripDbContext();

            var value = db.Contacts.Find(id);

            db.Contacts.Remove(value);
            db.SaveChanges();

            return RedirectToAction("ContactUsList", "Admin");
        }

        public IActionResult AboutUsList()
        {
            var db = new TravelTripDbContext();

            var values = db.AboutUs.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult UpdateAboutUs(int id)
        {
            var db = new TravelTripDbContext();
            var UpdateAboutUs = db.AboutUs.Find(id);
            return View(UpdateAboutUs);
        }
        [HttpPost]
        public IActionResult UpdateAboutUs(AboutUs about)
        {
            var db = new TravelTripDbContext();
            db.AboutUs.Update(about);
            db.SaveChanges();
            ModelState.Clear();

            return RedirectToAction("AboutUsList", "Admin");
        }
    }
}
