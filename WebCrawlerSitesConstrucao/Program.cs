using System;
using static WebCrawlerCasaNur.Request;
using  WebCrawlerCasaNur.Connection;
using System.IO;
using HtmlAgilityPack;
using WebCrawlerCasaNur.Crawlers;
using System.Collections.Generic;

namespace WebCrawlerCasaNur
{
    class Program
    {
        public static void SaveDataToFile<T>(string filePath, T objectToWrite, bool append = false)
        {
            using (Stream stream = File.Open(filePath, append ? FileMode.Append : FileMode.Create))
            {
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                binaryFormatter.Serialize(stream, objectToWrite);
            }
        }
        static void Main(string[] args)
        {
            CasaConstrucaoCrawler casaConstrucao = new CasaConstrucaoCrawler();
            List<string> porcelanatoLinks = casaConstrucao.ExtractLinks("porcelanato");
            foreach (string link in porcelanatoLinks)
            {
                Console.WriteLine(link);
            }
            Console.ReadKey();
        }
    }
}