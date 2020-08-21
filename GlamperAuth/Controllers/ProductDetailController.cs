using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Xml.Linq;
using Microsoft.AspNetCore.Mvc;

namespace GlamperAuthMOD.Controllers
{
    public class ProductDetailController : Controller
    {
       

        public IActionResult Index()
        {
           
            return View();
        }
    }
}
