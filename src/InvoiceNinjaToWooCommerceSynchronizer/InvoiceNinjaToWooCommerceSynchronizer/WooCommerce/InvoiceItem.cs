using System;
using System.Collections.Generic;
using System.Text;

namespace InvoiceNinjaToWooCommerceSynchronizer.WooCommerce
{
    class InvoiceItem
    {
        public int ArticleId { get; set; }

        public string ProductName { get; set; }

        public int Quantity { get; set; }

        public static InvoiceItem Create(string sku, string productKey, int quantity)
        {
            if (productKey == sku)
            {
                throw new ArgumentNullException($"{nameof(sku)}");
            }

            if (productKey == null)
            {
                throw new ArgumentNullException($"{nameof(productKey)}");
            }

            var success = int.TryParse(sku, out var articleId);

            if (!success)
            {
                throw new ArgumentException($"Cannot parse provided argument '{nameof(sku)}' to int.");
            }

            var item = new InvoiceItem
            {
                ArticleId = articleId,
                ProductName = productKey,
                Quantity = quantity
            };

            return item;
        }

        public override string ToString()
        {
            return $"{ProductName} ({nameof(ArticleId)}: '{ArticleId}', {nameof(Quantity)}: '{Quantity}'";
        }
    }
}
