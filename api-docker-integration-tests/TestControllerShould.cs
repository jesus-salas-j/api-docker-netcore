using System.Net.Http;
using api_docker;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace api_docker_integration_tests
{
    [TestClass]
    public class TestControllerShould
    {
        private HttpClient httpClient;

        [TestInitialize]
        public void BeforeEach()
        {
            WebApplicationFactory<Startup> factory = new WebApplicationFactory<Startup>();
            httpClient = factory.CreateClient();
        }

        [TestMethod]
        public void return_regards()
        {
            string expectedRegards = "Hello from test controller!";

            HttpResponseMessage responseMessage  = httpClient.GetAsync("api/Test").Result;
            string currentRegards = responseMessage.Content.ReadAsStringAsync().Result;

            Assert.AreEqual(expectedRegards, currentRegards);
        }
    }
}
