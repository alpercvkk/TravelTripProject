using Microsoft.AspNetCore.Mvc;

using TravelTripProject.Data;

namespace TravelTripProject.Views.Shared.Components.Sneak
{
    public class SneakViewComponent : ViewComponent
    {
        
        public IViewComponentResult Invoke()
        {
            var db = new TravelTripDbContext();

            var values = db.Blogs.OrderByDescending(x => x.Id).Take(2).ToList();

            return View(values);
        }

    }
}
