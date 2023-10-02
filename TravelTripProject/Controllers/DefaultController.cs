using Microsoft.AspNetCore.Mvc;
using TravelTripProject.Migrations;
using TravelTripProject.Data;

namespace TravelTripProject.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            var db = new TravelTripDbContext();

            var values = db.Blogs.ToList();

            return View(values);
        }

        public IActionResult About()
        {

            return View();
        }
    }


    
}
