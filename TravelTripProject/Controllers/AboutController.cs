using Microsoft.AspNetCore.Mvc;
using TravelTripProject.Data;



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
	}
}
