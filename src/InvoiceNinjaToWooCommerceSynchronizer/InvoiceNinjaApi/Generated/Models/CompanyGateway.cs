// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace InvoiceNinjaClient.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class CompanyGateway
    {
        /// <summary>
        /// Initializes a new instance of the CompanyGateway class.
        /// </summary>
        public CompanyGateway()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CompanyGateway class.
        /// </summary>
        /// <param name="id">______</param>
        /// <param name="companyId">______</param>
        /// <param name="gatewayKey">______</param>
        /// <param name="acceptedCreditCards">Bitmask representation of
        /// cards</param>
        /// <param name="showBillingAddress">______</param>
        /// <param name="showShippingAddress">______</param>
        /// <param name="config">The configuration map for the gateway</param>
        /// <param name="updateDetails">______</param>
        /// <param name="feesAndLimits">A mapped collection of the fees and
        /// limits for the configured gateway</param>
        public CompanyGateway(string id = default(string), string companyId = default(string), string gatewayKey = default(string), int? acceptedCreditCards = default(int?), bool? showBillingAddress = default(bool?), bool? showShippingAddress = default(bool?), string config = default(string), bool? updateDetails = default(bool?), IList<FeesAndLimits> feesAndLimits = default(IList<FeesAndLimits>))
        {
            Id = id;
            CompanyId = companyId;
            GatewayKey = gatewayKey;
            AcceptedCreditCards = acceptedCreditCards;
            ShowBillingAddress = showBillingAddress;
            ShowShippingAddress = showShippingAddress;
            Config = config;
            UpdateDetails = updateDetails;
            FeesAndLimits = feesAndLimits;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets ______
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets ______
        /// </summary>
        [JsonProperty(PropertyName = "company_id")]
        public string CompanyId { get; set; }

        /// <summary>
        /// Gets or sets ______
        /// </summary>
        [JsonProperty(PropertyName = "gateway_key")]
        public string GatewayKey { get; set; }

        /// <summary>
        /// Gets or sets bitmask representation of cards
        /// </summary>
        [JsonProperty(PropertyName = "accepted_credit_cards")]
        public int? AcceptedCreditCards { get; set; }

        /// <summary>
        /// Gets or sets ______
        /// </summary>
        [JsonProperty(PropertyName = "show_billing_address")]
        public bool? ShowBillingAddress { get; set; }

        /// <summary>
        /// Gets or sets ______
        /// </summary>
        [JsonProperty(PropertyName = "show_shipping_address")]
        public bool? ShowShippingAddress { get; set; }

        /// <summary>
        /// Gets or sets the configuration map for the gateway
        /// </summary>
        [JsonProperty(PropertyName = "config")]
        public string Config { get; set; }

        /// <summary>
        /// Gets or sets ______
        /// </summary>
        [JsonProperty(PropertyName = "update_details")]
        public bool? UpdateDetails { get; set; }

        /// <summary>
        /// Gets or sets a mapped collection of the fees and limits for the
        /// configured gateway
        /// </summary>
        [JsonProperty(PropertyName = "fees_and_limits")]
        public IList<FeesAndLimits> FeesAndLimits { get; set; }

    }
}
