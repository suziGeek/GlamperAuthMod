using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GlamperAuthMOD.Models
{
    

    public class ProductDetailRepository
    {
        private HttpClient _client;


        public ProductDetailRepository(HttpClient client)
        {
            _client = client;
        }

        //public ProductDetail GetProductDetail()
        //{
            //var campUrl = "http://api.amp.active.com/camping/campground/details?contractCode=CO&parkId=50032&api_key=hcgj5x79d9wren68k2pj5nv9";
            //var campResponse = _client.GetStringAsync(campUrl).Result;
            //XDocument doc = XDocument.Load(campResponse);
            // var campDetails = doc.Root
            //                  .Elements("detailDescription")
            //                  .Select(x => new ProductDetail
            //                  {
            //                      alert = (string)x.Attribute("alert"),
            //                      description = (string)x.Attribute("description")
            //                  })
            //                  .ToList();


            //return campDetails;
        //}
    }
}
