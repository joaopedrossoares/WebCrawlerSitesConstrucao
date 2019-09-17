using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace WebCrawlerCasaNur
{
    class Request
    {
        private String url;
        private String payload;
        private int timeout;
        private Dictionary<String, String> headers = new Dictionary<string, string>();
        private List<Cookie> cookies = new List<Cookie>();
        private String method;

        // Variables with default values
        private Boolean followRedirects = true;
        private Boolean sendContentEncoding = true;
        private Boolean sendUserAgent = true;

        public String getMethod()
        {
            return method;
        }

        public void setMethod(String method)
        {
            this.method = method;
        }


        public String getUrl()
        {
            return url;
        }

        public void setUrl(String url)
        {
            this.url = url;
        }

        public String getPayload()
        {
            return payload;
        }

        public void setPayload(String payload)
        {
            this.payload = payload;
        }

        public Dictionary<String, String> getHeaders()
        {
            return headers;
        }

        public void setHeaders(Dictionary<String, String> headers)
        {
            this.headers = headers;
        }

        public List<Cookie> getCookies()
        {
            return cookies;
        }

        public void setCookies(List<Cookie> cookies)
        {
            this.cookies = cookies;
        }

        public Boolean isFollowRedirects()
        {
            return followRedirects;
        }

        public void setFollowRedirects(Boolean followRedirects)
        {
            this.followRedirects = followRedirects;
        }

        public int getTimeout()
        {
            return timeout;
        }

        public void setTimeout(int timeout)
        {
            this.timeout = timeout;
        }

        public Boolean mustSendContentEncoding()
        {
            return sendContentEncoding;
        }

        public void setSendContentEncoding(Boolean sendContentEncoding)
        {
            this.sendContentEncoding = sendContentEncoding;
        }

        public Boolean mustSendUserAgent()
        {
            return sendUserAgent;
        }

        public void setSendUserAgent(Boolean sendUserAgent)
        {
            this.sendUserAgent = sendUserAgent;
        }

        public class RequestBuilder
        {

            private String url;
            private String payload;
            private Dictionary<String, String> headers = new Dictionary<String, String>();
            private List<Cookie> cookies = new List<Cookie>();
            private String method;

            // Variables with default values
            private Boolean followRedirects = true;
            private int timeout;
            private Boolean sendContentEncoding = true;
            private Boolean sendUserAgent = true;

            public static RequestBuilder create()
            {
                return new RequestBuilder();
            }

            public RequestBuilder setUrl(String url)
            {
                this.url = url;
                return this;
            }

            public RequestBuilder setMethod(String method)
            {
                this.method = method;
                return this;
            }

            public RequestBuilder setPayload(String payload)
            {
                this.payload = payload;
                return this;
            }

            public RequestBuilder setHeaders(Dictionary<String, String> headers)
            {
                this.headers = headers;
                return this;
            }

            public RequestBuilder setCookies(List<Cookie> cookies)
            {
                this.cookies = cookies;
                return this;
            }

            public RequestBuilder setTimeout(int timeout)
            {
                this.timeout = timeout;
                return this;
            }

            public RequestBuilder mustSendContentEncoding(Boolean must)
            {
                this.sendContentEncoding = must;
                return this;
            }

            public RequestBuilder setSendUserAgent(Boolean must)
            {
                this.sendUserAgent = must;
                return this;
            }

            public Request build()
            {
                Request request = new Request();
                request.setUrl(url);
                request.setCookies(cookies);
                request.setFollowRedirects(followRedirects);
                request.setPayload(payload);
                request.setHeaders(headers);
                request.setTimeout(timeout);
                request.setSendContentEncoding(sendContentEncoding);
                request.setSendUserAgent(sendUserAgent);

                return request;
            }
        }
    }
}
