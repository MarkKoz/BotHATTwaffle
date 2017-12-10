﻿using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;

namespace TestHATTwaffle
{
    class DataServices
    {
        JObject searchData;
        JsonRoot root;
        List<JsonSeries> series;

        public DataServices()
        {
            Start();
        }

        private void Start()
        {
            string dataPath = "searchData.json";
            searchData = JObject.Parse(File.ReadAllText(dataPath));

            root = searchData.ToObject<JsonRoot>();
            series = root.series;
        }

        public void Search(string searchSeries, string searchTerm)
        {
            var bootcamp = series[0];
            var v2 = series[1];

            var returns = v2.tutorial.FindAll(x => x.tags.Contains(searchTerm));

            foreach(var result in returns)
            {
                Console.WriteLine(result.url);
            }

            Console.WriteLine($"");



            //TODO: Basically everything

            //Download webpage title and store to string

            /*
            string URL = null;
            WebClient x = new WebClient();
            string siteTitle = x.DownloadString(URL);
            string regex = @"(?<=<title.*>)([\s\S]*)(?=</title>)";
            Regex ex = new Regex(regex, RegexOptions.IgnoreCase);
            siteTitle = ex.Match(siteTitle).Value.Trim();
            */
        }
    }
}
