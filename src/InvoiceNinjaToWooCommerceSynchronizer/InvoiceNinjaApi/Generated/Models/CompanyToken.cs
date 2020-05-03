// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace InvoiceNinjaClient.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class CompanyToken
    {
        /// <summary>
        /// Initializes a new instance of the CompanyToken class.
        /// </summary>
        public CompanyToken()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CompanyToken class.
        /// </summary>
        /// <param name="name">The token name</param>
        /// <param name="token">The token value</param>
        public CompanyToken(string name = default(string), string token = default(string))
        {
            Name = name;
            Token = token;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the token name
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the token value
        /// </summary>
        [JsonProperty(PropertyName = "token")]
        public string Token { get; set; }

    }
}