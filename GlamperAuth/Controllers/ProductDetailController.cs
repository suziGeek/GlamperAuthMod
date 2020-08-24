using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Xml.Linq;
using GlamperAuthMOD.Models;
using Microsoft.AspNetCore.Mvc;

namespace GlamperAuthMOD.Controllers
{
    public class ProductDetailController : Controller
    {
        private HttpClient _client;


        public ProductDetailController(HttpClient client)
        {
            _client = client;
        }

        public IActionResult Index()
        {
            var campUrl = "https://www.reserveamerica.com/campgroundDetails.do?contractCode=FLST&parkId=753016&api_key=hcgj5x79d9wren68k2pj5nv9&xml=true";
            var campResponse = _client.GetStringAsync(campUrl).Result;
            XDocument doc = XDocument.Load(campResponse);
           var  campDetails = doc.Root
                             .Elements("detailDescription")
                             .Select(x => new ProductDetail
                             {
                                 alert = (string)x.Attribute("alert"),
                                 description = (string)x.Attribute("description")
                             })
                             .ToList();


            

            return View(campDetails);
        }
    }
}
