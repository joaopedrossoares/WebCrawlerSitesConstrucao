using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using WebCrawlerCasaNur.Interfaces;

namespace WebCrawlerCasaNur.Connection
{
    class Connection : MethodsConnection
    {
        private Request buildedRequest;

        public Connection(Request buildedRequest)
        {
            this.buildedRequest = buildedRequest;
        }
        public string Get()
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(buildedRequest.getUrl());
            request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                return reader.ReadToEnd();
            }
        }

        public string Post()
        {
            throw new NotImplementedException();
        }
    }
}
