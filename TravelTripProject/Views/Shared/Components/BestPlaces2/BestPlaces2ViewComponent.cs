using Microsoft.AspNetCore.Mvc;
using TravelTripProject.Data;

namespace TravelTripProject.Views.Shared.Components.BestPlaces2
{
    public class BestPlaces2ViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var db = new TravelTripDbContext();

            var values = db.Blogs.OrderBy(x => x.Date).Take(3).ToList();

            return View(values);
        }
    }
}
