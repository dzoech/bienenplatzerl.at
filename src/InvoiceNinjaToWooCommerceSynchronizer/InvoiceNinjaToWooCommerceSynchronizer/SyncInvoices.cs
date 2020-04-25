using System;
using InvoiceNinjaClient;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;
using Microsoft.Rest;

namespace InvoiceNinjaToWooCommerceSynchronizer
{
    public static class SyncInvoices
    {
        [FunctionName("SyncInvoices")]
        public static void Run([TimerTrigger("0 */5 * * * *")]TimerInfo myTimer, ILogger log)
        {
            log.LogInformation($"C# Timer trigger function executed at: {DateTime.Now}");

            var cred = new InvoiceNinjaAuthentication();
            var invoiceNinjaClient = new InvoiceNinja(cred);
            invoiceNinjaClient.GetInvoices();
        }
    }
}
