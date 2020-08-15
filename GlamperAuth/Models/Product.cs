using ASPNET.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GlamperAuth.Models
{
    public class Product
    {
        public Product()
        {
        }


        public string agencyIcon { get; set; }

        public string agencyName { get; set; }

        public string contractID { get; set; }

        public string contractType { get; set; }

        public uint facilityID { get; set; }

        public string facilityName { get; set; }

        public string faciltyPhoto { get; set; }

        public string favorite { get; set; }

        public decimal latitude { get; set; }

        public string listingOnly { get; set; }

        public decimal longitude { get; set; }

        public string regionName { get; set; }

        public string shortName { get; set; }

        public string sitesWithAmps { get; set; }

        public string sitesWithPetsAllowed { get; set; }

        public string sitesWithSewerHookup { get; set; }

        public string sitesWithWaterHookup { get; set; }

        public string sitesWithWaterfront { get; set; }

        public string state { get; set; }

        public string user { get; set; }
        //public XElement CampDetail {get;set;}


    }
}
