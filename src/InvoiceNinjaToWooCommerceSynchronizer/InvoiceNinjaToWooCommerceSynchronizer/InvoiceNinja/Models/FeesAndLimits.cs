// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace InvoiceNinjaClient.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class FeesAndLimits
    {
        /// <summary>
        /// Initializes a new instance of the FeesAndLimits class.
        /// </summary>
        public FeesAndLimits()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the FeesAndLimits class.
        /// </summary>
        /// <param name="minLimit">______</param>
        /// <param name="maxLimit">______</param>
        /// <param name="feeAmount">______</param>
        /// <param name="feePercent">______</param>
        /// <param name="feeTaxName1">______</param>
        /// <param name="feeTaxName2">______</param>
        /// <param name="feeTaxName3">______</param>
        /// <param name="feeTaxRate1">______</param>
        /// <param name="feeTaxRate2">______</param>
        /// <param name="feeTaxRate3">______</param>
        /// <param name="feeCap">______</param>
        /// <param name="adjustFeePercent">______</param>
        public FeesAndLimits(string minLimit = default(string), string maxLimit = default(string), double? feeAmount = default(double?), double? feePercent = default(double?), string feeTaxName1 = default(string), string feeTaxName2 = default(string), string feeTaxName3 = default(string), double? feeTaxRate1 = default(double?), double? feeTaxRate2 = default(double?), double? feeTaxRate3 = default(double?), double? feeCap = default(double?), bool? adjustFeePercent = default(bool?))
        {
            MinLimit = minLimit;
            MaxLimit = maxLimit;
            FeeAmount = feeAmount;
            FeePercent = feePercent;
            FeeTaxName1 = feeTaxName1;
            FeeTaxName2 = feeTaxName2;
            FeeTaxName3 = feeTaxName3;
            FeeTaxRate1 = feeTaxRate1;
            FeeTaxRate2 = feeTaxRate2;
            FeeTaxRate3 = feeTaxRate3;
            FeeCap = feeCap;
            AdjustFeePercent = adjustFeePercent;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets ______
        /// </summary>
        [JsonProperty(PropertyName = "min_limit")]
        public string MinLimit { get; set; }

        /// <summary>
        /// Gets or sets ______
        /// </summary>
        [JsonProperty(PropertyName = "max_limit")]
        public string MaxLimit { get; set; }

        /// <summary>
        /// Gets or sets ______
        /// </summary>
        [JsonProperty(PropertyName = "fee_amount")]
        public double? FeeAmount { get; set; }

        /// <summary>
        /// Gets or sets ______
        /// </summary>
        [JsonProperty(PropertyName = "fee_percent")]
        public double? FeePercent { get; set; }

        /// <summary>
        /// Gets or sets ______
        /// </summary>
        [JsonProperty(PropertyName = "fee_tax_name1")]
        public string FeeTaxName1 { get; set; }

        /// <summary>
        /// Gets or sets ______
        /// </summary>
        [JsonProperty(PropertyName = "fee_tax_name2")]
        public string FeeTaxName2 { get; set; }

        /// <summary>
        /// Gets or sets ______
        /// </summary>
        [JsonProperty(PropertyName = "fee_tax_name3")]
        public string FeeTaxName3 { get; set; }

        /// <summary>
        /// Gets or sets ______
        /// </summary>
        [JsonProperty(PropertyName = "fee_tax_rate1")]
        public double? FeeTaxRate1 { get; set; }

        /// <summary>
        /// Gets or sets ______
        /// </summary>
        [JsonProperty(PropertyName = "fee_tax_rate2")]
        public double? FeeTaxRate2 { get; set; }

        /// <summary>
        /// Gets or sets ______
        /// </summary>
        [JsonProperty(PropertyName = "fee_tax_rate3")]
        public double? FeeTaxRate3 { get; set; }

        /// <summary>
        /// Gets or sets ______
        /// </summary>
        [JsonProperty(PropertyName = "fee_cap")]
        public double? FeeCap { get; set; }

        /// <summary>
        /// Gets or sets ______
        /// </summary>
        [JsonProperty(PropertyName = "adjust_fee_percent")]
        public bool? AdjustFeePercent { get; set; }

    }
}
