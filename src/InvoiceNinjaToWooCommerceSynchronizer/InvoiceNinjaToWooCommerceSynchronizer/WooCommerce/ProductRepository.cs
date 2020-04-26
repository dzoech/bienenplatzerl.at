using Microsoft.Extensions.Configuration;
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

        public ProductRepository(WCObject wooClient)
        {
            this.wooClient = wooClient;
        }

        public async Task<Product> GetBySkuAsync(int sku)
        {
            var queryBySku = CreateQueryBySku(sku);
            var products = await wooClient.Product.GetAll(queryBySku);
            return products.SingleOrDefault();
        }

        public async Task DecreaseStockQuantity(int sku, int decreaseBy = 1)
        {
            if (decreaseBy < 1)
            {
                throw new ArgumentException("Decrease of stock quantity must be greater than zero.");
            }

            var product = await GetBySkuAsync(sku);

            var productChanges = new Variation
            {
                stock_quantity = product.stock_quantity - decreaseBy
            };

            // Product variations must be updated via this endpoint: /products/<product_id>/variations/<id>
            var updatedProduct = 
                await wooClient.Product.Variations
                    .Update(product.id.Value, productChanges, product.parent_id.Value);
        }

        private static Dictionary<string, string> CreateQueryBySku(int sku)
        {
            return new Dictionary<string, string>()
            {
                { "sku", sku.ToString() }
            };
        }
    }
}
