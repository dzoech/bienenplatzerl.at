using System.Threading.Tasks;
using WooCommerceNET.WooCommerce.v3;

namespace InvoiceNinjaToWooCommerceSynchronizer.WooCommerce
{
    public interface IProductRepository
    {
        Task<Product> GetBySkuAsync(int id);
        Task AdjustStockQuantity(int sku, int quantityAdjustment = -1);
    }
}