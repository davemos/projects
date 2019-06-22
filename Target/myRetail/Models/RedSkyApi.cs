using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using myRetail.Properties;
using Newtonsoft.Json.Linq;

namespace myRetail.Models
{
    public class RedSkyApi
    {
       public string Url { get; set; }

        public string Excludes { get; set; }

        public RedSkyApi()
        {
            Url = "https://redsky.target.com/v2/pdp/tcin/";
            
        }

        public string GetProductName(string prodId)
        {
            WebClient wc = new WebClient();
            string name = "";

            JObject prodInfo = JObject.Parse(wc.DownloadString(Settings.Default.RedSkyApiUrl + prodId + "?excludes=" + Settings.Default.RedSkyProductInfoExclude));

            name = prodInfo["product"]["item"]["product_description"]["title"].ToString();
            return name;


        }

    }
}