﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace GlamperAuthMOD.Models
{
    public class CampsiteDetailRepository : ICampsiteDetailRepository
    {



        private HttpClient _client;

        public CampsiteDetailRepository(HttpClient client)
        {
            _client = client;
        }

        private List<CampsiteDetail> allCampDetails;
        private XElement CampData;

        public static CampsiteDetail LoadFromXMLString(string xmlText)
        {
            XmlRootAttribute xRoot = new XmlRootAttribute();
            xRoot.ElementName = "Root";

            xRoot.IsNullable = true;


            var stringReader = new System.IO.StringReader(xmlText);
            var serializer = new XmlSerializer(typeof(CampsiteDetail), xRoot);
            return serializer.Deserialize(stringReader) as CampsiteDetail;
        }



        public CampsiteDetail GetCamperDetail(string campId, string contractId)
        {
            string campUrl = $"https://www.reserveamerica.com/campgroundDetails.do?contractCode={contractId}&parkId={campId}&api_key=hcgj5x79d9wren68k2pj5nv9&xml=true";
            var campResponse = _client.GetStringAsync(campUrl).Result;

            XElement root = XElement.Parse(campResponse);
            XElement newTree = new XElement("Root",
                root.Element("Child1"),
                from att in root.Attributes()
                select new XElement(att.Name, (string)att)

            );
            var stringXML = newTree.ToString();
            //string htmlString = HttpUtility.HtmlDecode(stringXML);

            return LoadFromXMLString(stringXML);

        }


    }

}

