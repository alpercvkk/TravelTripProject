using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.AccessControl;
using TravelTripProject.Data;
using TravelTripProject.Data.Entities;

namespace TravelTripProject.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {

            var db = new TravelTripDbContext();

            var values = db.Blogs.Include(x=> x.Comments).ToList();
            
            return View(values);
        }

        [HttpGet]
        public IActionResult BlogDetail(int id)
        {
            var db = new TravelTripDbContext();

             var findBlog  =  db.Blogs.Include(x => x.Comments).Where(x => x.Id == id).ToList(); 
           
            return View(findBlog);
        }

        //[HttpGet]
        //public IActionResult LeaveAComment(int id)
        //{
        //    ViewBag.BlogId = id;
        //    return View();
        //}


            [HttpPost]
        public IActionResult LeaveAComment(Comment comment)
        {
            var db = new TravelTripDbContext();
            db.Comments.Add(comment);
            db.SaveChanges();
            return RedirectToAction("BlogDetail", new { id = comment.BlogId });
        }

       




    }
}
