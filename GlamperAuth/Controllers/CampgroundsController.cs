using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using GlamperAuthMOD.Models;
using Microsoft.AspNetCore.Mvc;

namespace GlamperAuthMOD.Controllers
{
    public class CampgroundsController : Controller
    {
        private readonly IProductRepository repo;

        public CampgroundsController(IProductRepository repo)
        {
            this.repo = repo;
        }

        public IActionResult Index(string selectState)
        {
            var client = new HttpClient();
            var quote = new CampgroundsRepository(client);

            List<Campgrounds> campground = quote.GetCampgrounds(selectState);

            return View(campground);
        }
    }
}
