using System;
using InvoiceNinjaToWooCommerceSynchronizer.WooCommerce;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using WooCommerceNET;
using WooCommerceNET.WooCommerce.v3;

[assembly: FunctionsStartup(typeof(InvoiceNinjaToWooCommerceSynchronizer.Startup))]

namespace InvoiceNinjaToWooCommerceSynchronizer
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            builder.Services
                .AddOptions<WooCommerceOptions>()
                .Configure<IConfiguration>((options, configuration) =>
                {
                    configuration.GetSection("WooCommerce").Bind(options);
                });

            builder.Services.AddTransient<RestAPI>(provider =>
            {
                var options = provider.GetService<IOptions<WooCommerceOptions>>().Value;
                return new RestAPI(options.Url, options.ConsumerKey, options.ConsumerSecret);
            });

            builder.Services.AddTransient<WCObject>();
            builder.Services.AddTransient<IProductRepository, ProductRepository>();
        }
    }
}