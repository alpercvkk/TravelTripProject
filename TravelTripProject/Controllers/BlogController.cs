using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TravelTripProject.Data;

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


    }
}
