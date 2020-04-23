// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace InvoiceNinjaClient.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class GroupSetting
    {
        /// <summary>
        /// Initializes a new instance of the GroupSetting class.
        /// </summary>
        public GroupSetting()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GroupSetting class.
        /// </summary>
        /// <param name="id">_________</param>
        /// <param name="userId">__________</param>
        /// <param name="companyId">________</param>
        /// <param name="name">________</param>
        /// <param name="settings">________</param>
        public GroupSetting(string id = default(string), string userId = default(string), string companyId = default(string), string name = default(string), object settings = default(object))
        {
            Id = id;
            UserId = userId;
            CompanyId = companyId;
            Name = name;
            Settings = settings;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets _________
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets __________
        /// </summary>
        [JsonProperty(PropertyName = "user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// Gets or sets ________
        /// </summary>
        [JsonProperty(PropertyName = "company_id")]
        public string CompanyId { get; set; }

        /// <summary>
        /// Gets or sets ________
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets ________
        /// </summary>
        [JsonProperty(PropertyName = "settings")]
        public object Settings { get; set; }

    }
}