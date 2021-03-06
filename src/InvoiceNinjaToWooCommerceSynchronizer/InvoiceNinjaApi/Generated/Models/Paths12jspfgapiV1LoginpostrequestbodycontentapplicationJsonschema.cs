// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace InvoiceNinjaClient.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class Paths12jspfgapiV1LoginpostrequestbodycontentapplicationJsonschema
    {
        /// <summary>
        /// Initializes a new instance of the
        /// Paths12jspfgapiV1LoginpostrequestbodycontentapplicationJsonschema
        /// class.
        /// </summary>
        public Paths12jspfgapiV1LoginpostrequestbodycontentapplicationJsonschema()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// Paths12jspfgapiV1LoginpostrequestbodycontentapplicationJsonschema
        /// class.
        /// </summary>
        /// <param name="email">The user email address</param>
        /// <param name="password">The user password must meet minimum criteria
        /// ~ &gt;6 characters</param>
        public Paths12jspfgapiV1LoginpostrequestbodycontentapplicationJsonschema(string email = default(string), string password = default(string))
        {
            Email = email;
            Password = password;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the user email address
        /// </summary>
        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the user password must meet minimum criteria ~
        /// &amp;gt;6 characters
        /// </summary>
        [JsonProperty(PropertyName = "password")]
        public string Password { get; set; }

    }
}
