// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace InvoiceNinjaClient.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class CreditPaymentable
    {
        /// <summary>
        /// Initializes a new instance of the CreditPaymentable class.
        /// </summary>
        public CreditPaymentable()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CreditPaymentable class.
        /// </summary>
        /// <param name="creditId">______</param>
        /// <param name="amount">______</param>
        public CreditPaymentable(string creditId = default(string), string amount = default(string))
        {
            CreditId = creditId;
            Amount = amount;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets ______
        /// </summary>
        [JsonProperty(PropertyName = "credit_id")]
        public string CreditId { get; set; }

        /// <summary>
        /// Gets or sets ______
        /// </summary>
        [JsonProperty(PropertyName = "amount")]
        public string Amount { get; set; }

    }
}
