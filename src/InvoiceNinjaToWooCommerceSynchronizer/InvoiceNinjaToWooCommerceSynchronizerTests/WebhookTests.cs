using InvoiceNinjaToWooCommerceSynchronizer;
using InvoiceNinjaToWooCommerceSynchronizer.WooCommerce;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Internal;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Primitives;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;
using System.IO;

namespace InvoiceNinjaToWooCommerceSynchronizerTests
{
    [TestClass]
    public class WebhookTests
    {
        public HttpRequest SetupHttpRequest(Dictionary<string, StringValues> query, string body)
        {
            var reqMock = new Mock<HttpRequest>();

            reqMock.Setup(req => req.Query).Returns(new QueryCollection(query));
            var stream = new MemoryStream();
            var writer = new StreamWriter(stream);
            writer.Write(body);
            writer.Flush();
            stream.Position = 0;
            reqMock.Setup(req => req.Body).Returns(stream);
            return reqMock.Object;
        }


        [TestMethod]
        [DeploymentItem("TestWebhookData/demo-invoice-created.json")]
        public void TestInvoiceCreatedHttpPost()
        {
            var jsonString = File.ReadAllText("demo-invoice-created.json");

            var logger = new UnitTestLogger();
            var request = SetupHttpRequest(null, jsonString);

            var repo = new Mock<IProductRepository>();

            // TODO mock Repository methods

            var func = new InvoiceCreated(repo.Object);
            func.Run(request, logger);
        }
    }
}
