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
        //    var campUrl = "http://api.amp.active.com/camping/campground/details?contractCode=CO&parkId=50032&api_key=hcgj5x79d9wren68k2pj5nv9";
        //    var campResponse = _client.GetStringAsync(campUrl).Result;
        //    var CampDetail = XElement.Parse(campResponse).ToString();
        //    //List<XElement> contactNodes = ProductDetail.Elements("result").ToList();
            

        //    return <ProductDetail> CampDetail;
        //}
    }
}
