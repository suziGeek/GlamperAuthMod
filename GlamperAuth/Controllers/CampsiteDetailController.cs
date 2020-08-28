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
    public class CampsiteDetailController : Controller
    {

        public ActionResult Index(string campId, string contractId)
        {

            var client = new HttpClient();
            var quote = new CampsiteDetailRepository(client);

            CampsiteDetail campsites = quote.GetCamperDetail(campId, contractId);

            return View(campsites);
        }

    }
}
