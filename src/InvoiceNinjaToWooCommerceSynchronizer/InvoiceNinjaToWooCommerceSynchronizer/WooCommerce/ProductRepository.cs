using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WooCommerceNET;
using WooCommerceNET.Base;
using WooCommerceNET.WooCommerce.v3;

namespace InvoiceNinjaToWooCommerceSynchronizer.WooCommerce
{
    class ProductRepository : IProductRepository
    {
        private readonly WCObject wooClient;
        private readonly ILogger logger;

        public ProductRepository(WCObject wooClient, ILogger logger)
        {
            this.wooClient = wooClient;
            this.logger = logger;
        }

        public async Task<Product> GetBySkuAsync(int sku)
        {
            var queryBySku = CreateQueryBySku(sku);
            var products = await wooClient.Product.GetAll(queryBySku);
            return products.SingleOrDefault();
        }

        /// <summary>
        /// This method might cause race conditions because WooCommerce does not
        /// provide a atomic operation to increase or decrease stock quantity.
        /// </summary>
        public async Task AdjustStockQuantity(int sku, int quantityAdjustment = -1)
        {
            if (quantityAdjustment == 0)
            {
                return;
            }

            var product = await GetBySkuAsync(sku);

            var productChanges = new Variation
            {
                stock_quantity = product.stock_quantity + quantityAdjustment
            };

            // Product variations must be updated via this endpoint: /products/<product_id>/variations/<id>
            var updatedProduct = 
                await wooClient.Product.Variations
                    .Update(product.id.Value, productChanges, product.parent_id.Value);

            logger.LogInformation($"Adjusted stock quantity for product {sku} by {quantityAdjustment}");
        }

        private Dictionary<string, string> CreateQueryBySku(int sku)
        {
            return new Dictionary<string, string>()
            {
                { "sku", sku.ToString() }
            };
        }
    }
}
