using Fizzler.Systems.HtmlAgilityPack;
using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Text;
using static WebCrawlerCasaNur.Request;

namespace WebCrawlerCasaNur.Crawlers
{
    class CasaConstrucaoCrawler
    {
        public CasaConstrucaoCrawler()
        {

        }

        public HtmlDocument GetDocument(string keyword)
        {

            Request request = new Request();

            request = RequestBuilder
                    .create()
                    .setUrl("https://www.cec.com.br/busca?q=" + keyword)
                    .setMethod("GET").build();

            Connection.Connection conn = new Connection.Connection(request);

            String response = conn.Get();

            var document = new HtmlDocument();

            document.LoadHtml(response);

            return document;
        }

        public List<string> ExtractLinks(string keyword)
        {
            List<string> links = new List<string>();
            HtmlDocument document = GetDocument(keyword);
            IEnumerable<HtmlNode> products = document.DocumentNode.QuerySelectorAll(".products .product");
            foreach (HtmlNode element in products)
            {
                HtmlNode node = element.QuerySelector(".name-and-brand");
                if (node != null)
                {
                    string link = "https://www.cec.com.br" + node.Attributes["href"].Value;
                    links.Add(link);

                }

            }
            return links;
        }

    }
}
