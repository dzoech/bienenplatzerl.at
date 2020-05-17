using System;
using System.Collections.Generic;
using System.Text;

namespace InvoiceNinjaToWooCommerceSynchronizer.Dtos
{
    public class InvoiceEventDto
    {
        public string client_name { get; set; }
        public Invoice_Items[] invoice_items { get; set; }
    }
    public class Invoice_Items
    {
        public int id { get; set; }
        public string product_key { get; set; }
        public int qty { get; set; }
        public string custom_value1 { get; set; }
        /// <summary>
        /// SKU
        /// </summary>
        public string custom_value2 { get; set; }
    }

}
