using Microsoft.AspNetCore.Mvc;
using TravelTripProject.Data;

namespace TravelTripProject.Views.Shared.Components.Sneak2
{
    public class Sneak2ViewComponent : ViewComponent
    {

        public IViewComponentResult Invoke()
        {
            var db = new TravelTripDbContext();
            var values = db.Blogs.Where(x => x.Id == 2).ToList();

            return View(values);
        }
    }
}
