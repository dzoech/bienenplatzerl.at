// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace InvoiceNinjaClient.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class Activity
    {
        /// <summary>
        /// Initializes a new instance of the Activity class.
        /// </summary>
        public Activity()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Activity class.
        /// </summary>
        /// <param name="id">______</param>
        /// <param name="activityTypeId">______</param>
        /// <param name="clientId">______</param>
        /// <param name="companyId">______</param>
        /// <param name="userId">______</param>
        /// <param name="invoiceId">______</param>
        /// <param name="paymentId">______</param>
        /// <param name="creditId">______</param>
        /// <param name="updatedAt">______</param>
        /// <param name="expenseId">______</param>
        /// <param name="isSystem">______</param>
        /// <param name="contactId">______</param>
        /// <param name="taskId">______</param>
        /// <param name="notes">______</param>
        /// <param name="ip">______</param>
        public Activity(string id = default(string), string activityTypeId = default(string), string clientId = default(string), string companyId = default(string), string userId = default(string), string invoiceId = default(string), string paymentId = default(string), string creditId = default(string), string updatedAt = default(string), string expenseId = default(string), bool? isSystem = default(bool?), string contactId = default(string), string taskId = default(string), string notes = default(string), string ip = default(string))
        {
            Id = id;
            ActivityTypeId = activityTypeId;
            ClientId = clientId;
            CompanyId = companyId;
            UserId = userId;
            InvoiceId = invoiceId;
            PaymentId = paymentId;
            CreditId = creditId;
            UpdatedAt = updatedAt;
            ExpenseId = expenseId;
            IsSystem = isSystem;
            ContactId = contactId;
            TaskId = taskId;
            Notes = notes;
            Ip = ip;
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
        [JsonProperty(PropertyName = "activity_type_id")]
        public string ActivityTypeId { get; set; }

        /// <summary>
        /// Gets or sets ______
        /// </summary>
        [JsonProperty(PropertyName = "client_id")]
        public string ClientId { get; set; }

        /// <summary>
        /// Gets or sets ______
        /// </summary>
        [JsonProperty(PropertyName = "company_id")]
        public string CompanyId { get; set; }

        /// <summary>
        /// Gets or sets ______
        /// </summary>
        [JsonProperty(PropertyName = "user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// Gets or sets ______
        /// </summary>
        [JsonProperty(PropertyName = "invoice_id")]
        public string InvoiceId { get; set; }

        /// <summary>
        /// Gets or sets ______
        /// </summary>
        [JsonProperty(PropertyName = "payment_id")]
        public string PaymentId { get; set; }

        /// <summary>
        /// Gets or sets ______
        /// </summary>
        [JsonProperty(PropertyName = "credit_id")]
        public string CreditId { get; set; }

        /// <summary>
        /// Gets or sets ______
        /// </summary>
        [JsonProperty(PropertyName = "updated_at")]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// Gets or sets ______
        /// </summary>
        [JsonProperty(PropertyName = "expense_id")]
        public string ExpenseId { get; set; }

        /// <summary>
        /// Gets or sets ______
        /// </summary>
        [JsonProperty(PropertyName = "is_system")]
        public bool? IsSystem { get; set; }

        /// <summary>
        /// Gets or sets ______
        /// </summary>
        [JsonProperty(PropertyName = "contact_id")]
        public string ContactId { get; set; }

        /// <summary>
        /// Gets or sets ______
        /// </summary>
        [JsonProperty(PropertyName = "task_id")]
        public string TaskId { get; set; }

        /// <summary>
        /// Gets or sets ______
        /// </summary>
        [JsonProperty(PropertyName = "notes")]
        public string Notes { get; set; }

        /// <summary>
        /// Gets or sets ______
        /// </summary>
        [JsonProperty(PropertyName = "ip")]
        public string Ip { get; set; }

    }
}
