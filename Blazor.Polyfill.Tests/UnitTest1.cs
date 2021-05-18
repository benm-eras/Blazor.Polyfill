using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Blazor.Polyfill.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public async Task TestMethod1()
        {
            using WebApplicationFactory<Startup> factory = new();
            using HttpClient http = factory.CreateClient();

            HttpResponseMessage response = await http.GetAsync("/");
            _ = response.EnsureSuccessStatusCode();
        }

        [TestMethod]
        public async Task TestMethod2()
        {
            using WebApplicationFactory<Startup> factory = new();
            using HttpClient http = factory.CreateClient();

            HttpResponseMessage response = await http.GetAsync("/");
            _ = response.EnsureSuccessStatusCode();
        }
    }
}
