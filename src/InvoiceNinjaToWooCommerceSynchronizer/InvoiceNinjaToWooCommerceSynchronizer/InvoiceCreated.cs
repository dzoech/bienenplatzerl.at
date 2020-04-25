using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using InvoiceNinjaToWooCommerceSynchronizer.Dtos;
using System.Linq;

namespace InvoiceNinjaToWooCommerceSynchronizer
{
    public static class InvoiceCreated
    {
        // TODO: InvoiceUpdated

        [FunctionName("InvoiceCreated")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "post", Route = null)] HttpRequest req,
            ILogger logger)
        {
            logger.LogInformation("C# HTTP trigger function processed a request.");

            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            var invoiceData = JsonConvert.DeserializeObject<InvoiceCreatedDto>(requestBody);
 

            var purchasedItems = invoiceData.invoice_items.Select(i => 
                new { 
                    ArticleId = int.Parse(i.custom_value2), 
                    ProductName = i.product_key, 
                    Quantity = i.qty 
                });

            foreach (var item in purchasedItems)
            {
                logger.LogInformation($"Stock Reduction: {item}");
            }

            return new OkObjectResult("Success");
        }
    }
}
