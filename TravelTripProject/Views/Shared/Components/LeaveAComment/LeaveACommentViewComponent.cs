using Microsoft.AspNetCore.Mvc;
using TravelTripProject.Data;
using TravelTripProject.Data.Entities;

namespace TravelTripProject.Views.Shared.Components.LeaveACommentViewComponent

{
    public class LeaveACommentViewComponent : ViewComponent
    {

        public IViewComponentResult Invoke(Comment comment, int id)
        {
            if(comment is  null)
            {
                comment = new Comment();
                comment.BlogId = id;
            }
             
            return View(comment);
        }

      
       
    }
}
