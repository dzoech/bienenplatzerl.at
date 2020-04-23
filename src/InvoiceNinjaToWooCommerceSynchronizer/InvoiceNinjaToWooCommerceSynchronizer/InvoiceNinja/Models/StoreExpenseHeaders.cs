// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace InvoiceNinjaClient.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Defines headers for storeExpense operation.
    /// </summary>
    public partial class StoreExpenseHeaders
    {
        /// <summary>
        /// Initializes a new instance of the StoreExpenseHeaders class.
        /// </summary>
        public StoreExpenseHeaders()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the StoreExpenseHeaders class.
        /// </summary>
        /// <param name="xAPIVersion">The API version</param>
        /// <param name="xRateLimitRemaining">The number of requests left for
        /// the time window.</param>
        /// <param name="xRateLimitLimit">The total number of requests in a
        /// given time window.</param>
        public StoreExpenseHeaders(double? xAPIVersion = default(double?), int? xRateLimitRemaining = default(int?), int? xRateLimitLimit = default(int?))
        {
            XAPIVersion = xAPIVersion;
            XRateLimitRemaining = xRateLimitRemaining;
            XRateLimitLimit = xRateLimitLimit;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the API version
        /// </summary>
        [JsonProperty(PropertyName = "X-API-Version")]
        public double? XAPIVersion { get; set; }

        /// <summary>
        /// Gets or sets the number of requests left for the time window.
        /// </summary>
        [JsonProperty(PropertyName = "X-RateLimit-Remaining")]
        public int? XRateLimitRemaining { get; set; }

        /// <summary>
        /// Gets or sets the total number of requests in a given time window.
        /// </summary>
        [JsonProperty(PropertyName = "X-RateLimit-Limit")]
        public int? XRateLimitLimit { get; set; }

    }
}
