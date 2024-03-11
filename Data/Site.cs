using Microsoft.VisualBasic;
using System.Net;

namespace GurleyHealthSite.Data
{
    public class Site
    {
        public string URL { get; set; }
        public string Status { get; set; }
        public HttpStatusCode Code { get; set; }
        public Task<HttpResponseMessage> TestSite { get; set; }
        public Site() { }
        public Task<HttpResponseMessage> Test()
        {
            HttpClient client = new HttpClient();
            HttpRequestMessage requestMessage = new HttpRequestMessage(HttpMethod.Get, URL);

            TestSite = client.SendAsync(requestMessage);
            return TestSite;
        }
    }
}
