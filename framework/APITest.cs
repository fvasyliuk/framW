using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NUnit.Framework;
using RestSharp;
using System.Linq;
using System.Net;

namespace framework
{
    public class APITests : APITestsFixture
    {

        [Test]
        public void ApiGetFirstPostTitle()
        {
            Initialize();
            Request = new RestRequest("posts/1", Method.GET);
            Response = Client.Get(Request);
            Assert.That(Response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
            ResponseJson = JObject.Parse(Response.Content);
            string title = (string)ResponseJson.SelectTokens("title").FirstOrDefault();
            StringAssert.AreEqualIgnoringCase(title, "sunt aut facere repellat provident occaecati excepturi optio reprehenderit");
        }

        [Test]
        public void ApiGetSecondPostTitle()
        {
            Initialize();
            Request = new RestRequest("posts/2", Method.GET);
            Response = Client.Get(Request);
            Assert.That(Response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
            ResponseJson = JObject.Parse(Response.Content);
            string title = (string)ResponseJson.SelectTokens("title").FirstOrDefault();
            StringAssert.AreEqualIgnoringCase(title, "qui est esse");
        }

        [Test]
        public void ApiGetTNPostTitle()
        {
            Initialize();
            Request = new RestRequest("posts/19", Method.GET);
            Response = Client.Get(Request);
            Assert.That(Response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
            ResponseJson = JObject.Parse(Response.Content);
            string title = (string)ResponseJson.SelectTokens("title").FirstOrDefault();
            StringAssert.AreEqualIgnoringCase(title, "adipisci placeat illum aut reiciendis qui");
            string body = (string)ResponseJson.SelectTokens("body").FirstOrDefault();
            StringAssert.AreEqualIgnoringCase(body, "illum quis cupiditate provident sit magnam\nea sed aut omnis\nveniam maiores ullam consequatur atque\nadipisci quo iste expedita sit quos voluptas");
        }

        

    }
   
}
