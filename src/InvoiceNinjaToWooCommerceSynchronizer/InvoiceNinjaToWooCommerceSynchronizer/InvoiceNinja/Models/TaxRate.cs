// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace InvoiceNinjaClient.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class TaxRate
    {
        /// <summary>
        /// Initializes a new instance of the TaxRate class.
        /// </summary>
        public TaxRate()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TaxRate class.
        /// </summary>
        /// <param name="id">______</param>
        /// <param name="name">______</param>
        /// <param name="rate">______</param>
        public TaxRate(string id = default(string), string name = default(string), double? rate = default(double?))
        {
            Id = id;
            Name = name;
            Rate = rate;
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
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets ______
        /// </summary>
        [JsonProperty(PropertyName = "rate")]
        public double? Rate { get; set; }

    }
}