# WebCrawlerSitesConstrucao
Crawlers to get links from constructions web sites

- This Web Crawler has been builded to help a friend to get products data from constructions web sites;
- This Web Crawler has been builded in C#.

## What was used?

- To parse html, the parser Html Agility Pack has been used;
  - But Html Agililty Pack uses XPath to get HtmlNodes and that's can be more difficult than CSS Selectors. So I found Fizzler, to help me.
  - Fizzler is a CSS Selector Engine based in Html Agililty Pack.
  - Now it's easier to get HtmlNodes, because we can use CSS Selectors instead XPath.