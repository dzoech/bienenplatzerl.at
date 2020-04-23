// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace InvoiceNinjaClient.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class VendorContact
    {
        /// <summary>
        /// Initializes a new instance of the VendorContact class.
        /// </summary>
        public VendorContact()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VendorContact class.
        /// </summary>
        /// <param name="id">_________</param>
        /// <param name="userId">__________</param>
        /// <param name="companyId">________</param>
        /// <param name="vendorId">________</param>
        /// <param name="firstName">________</param>
        /// <param name="lastName">________</param>
        /// <param name="phone">________</param>
        /// <param name="customValue1">________</param>
        /// <param name="customValue2">________</param>
        /// <param name="customValue3">________</param>
        /// <param name="customValue4">________</param>
        /// <param name="email">________</param>
        /// <param name="isPrimary">________</param>
        /// <param name="createdAt">Timestamp</param>
        /// <param name="updatedAt">Timestamp</param>
        /// <param name="deletedAt">Timestamp</param>
        public VendorContact(string id = default(string), string userId = default(string), string companyId = default(string), string vendorId = default(string), string firstName = default(string), string lastName = default(string), string phone = default(string), string customValue1 = default(string), string customValue2 = default(string), string customValue3 = default(string), string customValue4 = default(string), string email = default(string), bool? isPrimary = default(bool?), double? createdAt = default(double?), double? updatedAt = default(double?), double? deletedAt = default(double?))
        {
            Id = id;
            UserId = userId;
            CompanyId = companyId;
            VendorId = vendorId;
            FirstName = firstName;
            LastName = lastName;
            Phone = phone;
            CustomValue1 = customValue1;
            CustomValue2 = customValue2;
            CustomValue3 = customValue3;
            CustomValue4 = customValue4;
            Email = email;
            IsPrimary = isPrimary;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            DeletedAt = deletedAt;
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
        [JsonProperty(PropertyName = "vendor_id")]
        public string VendorId { get; set; }

        /// <summary>
        /// Gets or sets ________
        /// </summary>
        [JsonProperty(PropertyName = "first_name")]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets ________
        /// </summary>
        [JsonProperty(PropertyName = "last_name")]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets ________
        /// </summary>
        [JsonProperty(PropertyName = "phone")]
        public string Phone { get; set; }

        /// <summary>
        /// Gets or sets ________
        /// </summary>
        [JsonProperty(PropertyName = "custom_value1")]
        public string CustomValue1 { get; set; }

        /// <summary>
        /// Gets or sets ________
        /// </summary>
        [JsonProperty(PropertyName = "custom_value2")]
        public string CustomValue2 { get; set; }

        /// <summary>
        /// Gets or sets ________
        /// </summary>
        [JsonProperty(PropertyName = "custom_value3")]
        public string CustomValue3 { get; set; }

        /// <summary>
        /// Gets or sets ________
        /// </summary>
        [JsonProperty(PropertyName = "custom_value4")]
        public string CustomValue4 { get; set; }

        /// <summary>
        /// Gets or sets ________
        /// </summary>
        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets ________
        /// </summary>
        [JsonProperty(PropertyName = "is_primary")]
        public bool? IsPrimary { get; set; }

        /// <summary>
        /// Gets or sets timestamp
        /// </summary>
        [JsonProperty(PropertyName = "created_at")]
        public double? CreatedAt { get; set; }

        /// <summary>
        /// Gets or sets timestamp
        /// </summary>
        [JsonProperty(PropertyName = "updated_at")]
        public double? UpdatedAt { get; set; }

        /// <summary>
        /// Gets or sets timestamp
        /// </summary>
        [JsonProperty(PropertyName = "deleted_at")]
        public double? DeletedAt { get; set; }

    }
}
