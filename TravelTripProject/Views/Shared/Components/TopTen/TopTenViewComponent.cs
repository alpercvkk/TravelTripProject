using MessagePack;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Differencing;
using Microsoft.Data.SqlClient.Server;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.Intrinsics.X86;
using System;
using TravelTripProject.Data;

namespace TravelTripProject.Views.Shared.Components.TopTen
{
    public class TopTenViewComponent : ViewComponent
    {

        public IViewComponentResult Invoke()
        {
            var db = new TravelTripDbContext();

            var values = db.Blogs.OrderByDescending(x => x.Date).Take(10).ToList();

            return View(values);
        }
    }
}

