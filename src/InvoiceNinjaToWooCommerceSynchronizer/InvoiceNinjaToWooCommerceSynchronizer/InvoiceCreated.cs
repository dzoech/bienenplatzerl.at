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
using InvoiceNinjaToWooCommerceSynchronizer.WooCommerce;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

namespace InvoiceNinjaToWooCommerceSynchronizer
{
    public class InvoiceCreated
    {
        private readonly IProductRepository productRepository;
        public InvoiceCreated(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        // TODO: InvoiceUpdated

        [FunctionName("InvoiceCreated")]
        public async Task<IActionResult> Run(
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

                try
                {
                    await productRepository.DecreaseStockQuantity(item.ArticleId, decreaseBy: item.Quantity);
                }
                catch (Exception ex)
                {
                    logger.LogError(
                        ex, 
                        $"Failed to decrease stock in WooCommerce for product {item.ProductName} ({item.ArticleId}).");
                }
            }

            return new OkObjectResult("Success");
        }
    }
}
