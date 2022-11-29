using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using FluentAssertions;
using NUnit.Framework;
using RichardSzalay.MockHttp;

namespace Camunda.Api.Client.Tests
{
    public class ProcessInstanceTests
    {
        [Test]
        public async Task GetList()
        {
            var mockHttp = new MockHttpMessageHandler();

            mockHttp.Expect(HttpMethod.Post, "http://localhost:31020/engine-rest/*")
                .Respond(HttpStatusCode.OK, "text/html", "OK");

            var client = CamundaClient.Create("http://localhost:31020/engine-rest");
            var process = await client.ProcessDefinitions.GetStatistics(false);

            process.Should().NotBeNull();
        }
    }
}
