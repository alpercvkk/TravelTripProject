using Microsoft.AspNetCore.Mvc;
using TravelTripProject.Data;

namespace TravelTripProject.Views.Shared.Components.BestPlaces
{
    public class BestPlacesViewComponent : ViewComponent 
    {

       public IViewComponentResult Invoke()
        {
            var db = new TravelTripDbContext();

             var values =  db.Blogs.OrderBy(x => x.Id).Take(3).ToList();

                return View(values);
        }

    }
}
