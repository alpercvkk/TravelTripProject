using Microsoft.AspNetCore.Mvc;
using TravelTripProject.Data;
using TravelTripProject.Data.Entities;

namespace TravelTripProject.Controllers
{
	public class AboutController : Controller
	{
		public IActionResult Index()
		{
			var db = new TravelTripDbContext();

			var values = db.AboutUs.ToList();

			return View(values);
		}


		[HttpGet]
		public IActionResult ContactUs()
		{

			return View();
		}

		[HttpPost]
		public IActionResult ContactUs(Contact contact)
		{
			if (ModelState.IsValid)
			{
                var db = new TravelTripDbContext();

                db.Contacts.Add(contact);
                db.SaveChanges();
                ModelState.Clear();
                return RedirectToAction("ContactUs", "About");

            }

			return View();
            

        }



    }
}
