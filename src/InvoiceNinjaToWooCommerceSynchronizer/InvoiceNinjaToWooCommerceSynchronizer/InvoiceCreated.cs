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
using System.Collections.Generic;

namespace InvoiceNinjaToWooCommerceSynchronizer
{
    public class InvoiceWebhooks
    {
        private readonly IProductRepository productRepository;
        public InvoiceWebhooks(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        [FunctionName("InvoiceCreated")]
        public async Task<IActionResult> InvoiceCreated(
            [HttpTrigger(AuthorizationLevel.Function, "post", Route = null)] HttpRequest request,
            ILogger logger)
        {
            logger.LogInformation($"{nameof(InvoiceCreated)} triggered function triggered.");
            var purchasedItems = await ExtractInvoiceItems(request);

            foreach (var item in purchasedItems)
            {
                logger.LogInformation($"Stock reduction for item '{item}'");

                try
                {
                    await productRepository.AdjustStockQuantity(item.ArticleId, quantityAdjustment: -item.Quantity);
                }
                catch (Exception ex)
                {
                    logger.LogError(
                        ex,
                        $"Failed to decrease stock in WooCommerce for product {item}.");
                }
            }

            return new OkObjectResult("Success");
        }


        [FunctionName("InvoiceDeleted")]
        public async Task<IActionResult> InvoiceDeleted(
                    [HttpTrigger(AuthorizationLevel.Function, "post", Route = null)] HttpRequest request,
                    ILogger logger)
        {
            logger.LogInformation($"{nameof(InvoiceDeleted)} triggered function triggered.");
            var purchasedItems = await ExtractInvoiceItems(request);

            foreach (var item in purchasedItems)
            {
                logger.LogInformation($"Stock increase for item '{item}'");

                try
                {
                    await productRepository.AdjustStockQuantity(item.ArticleId, quantityAdjustment: +item.Quantity);
                }
                catch (Exception ex)
                {
                    logger.LogError(
                        ex,
                        $"Failed to increase stock in WooCommerce for product {item}.");
                }
            }

            return new OkObjectResult("Success");
        }

        // TODO: Update
        // Query invoice history to calculate change in stock quantity
        // https://rechnung.zoechbauer.info/invoices/invoice_history/127 

        private async Task<IEnumerable<InvoiceItem>> ExtractInvoiceItems(HttpRequest request)
        {
            string requestBody = await new StreamReader(request.Body).ReadToEndAsync();
            var invoiceData = JsonConvert.DeserializeObject<InvoiceEventDto>(requestBody);

            var purchasedItems = invoiceData.invoice_items.Select(i =>
                InvoiceItem.Create(i.custom_value2, i.product_key, i.qty));

            return purchasedItems;
        }
    }
}
