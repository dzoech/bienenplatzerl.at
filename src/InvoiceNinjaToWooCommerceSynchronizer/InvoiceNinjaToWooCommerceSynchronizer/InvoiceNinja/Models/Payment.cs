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

    public partial class Payment
    {
        /// <summary>
        /// Initializes a new instance of the Payment class.
        /// </summary>
        public Payment()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Payment class.
        /// </summary>
        /// <param name="id">______</param>
        /// <param name="clientId">______</param>
        /// <param name="invitationId">______</param>
        /// <param name="clientContactId">______</param>
        /// <param name="userId">______</param>
        /// <param name="typeId">The Payment Type ID</param>
        /// <param name="date">The Payment date</param>
        /// <param name="transactionReference">The transaction reference as
        /// defined by the payment gateway</param>
        /// <param name="assignedUserId">______</param>
        /// <param name="privateNotes">______</param>
        /// <param name="isManual">______</param>
        /// <param name="isDeleted">______</param>
        /// <param name="amount">The amount of this payment</param>
        /// <param name="refunded">The refunded amount of this payment</param>
        /// <param name="updatedAt">Timestamp</param>
        /// <param name="archivedAt">Timestamp</param>
        /// <param name="companyGatewayId">The company gateway id</param>
        public Payment(string id = default(string), string clientId = default(string), string invitationId = default(string), string clientContactId = default(string), string userId = default(string), string typeId = default(string), string date = default(string), string transactionReference = default(string), string assignedUserId = default(string), string privateNotes = default(string), bool? isManual = default(bool?), bool? isDeleted = default(bool?), double? amount = default(double?), double? refunded = default(double?), double? updatedAt = default(double?), double? archivedAt = default(double?), string companyGatewayId = default(string), Paymentable paymentables = default(Paymentable), IList<InvoicePaymentable> invoices = default(IList<InvoicePaymentable>), IList<CreditPaymentable> credits = default(IList<CreditPaymentable>))
        {
            Id = id;
            ClientId = clientId;
            InvitationId = invitationId;
            ClientContactId = clientContactId;
            UserId = userId;
            TypeId = typeId;
            Date = date;
            TransactionReference = transactionReference;
            AssignedUserId = assignedUserId;
            PrivateNotes = privateNotes;
            IsManual = isManual;
            IsDeleted = isDeleted;
            Amount = amount;
            Refunded = refunded;
            UpdatedAt = updatedAt;
            ArchivedAt = archivedAt;
            CompanyGatewayId = companyGatewayId;
            Paymentables = paymentables;
            Invoices = invoices;
            Credits = credits;
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
        [JsonProperty(PropertyName = "client_id")]
        public string ClientId { get; set; }

        /// <summary>
        /// Gets or sets ______
        /// </summary>
        [JsonProperty(PropertyName = "invitation_id")]
        public string InvitationId { get; set; }

        /// <summary>
        /// Gets or sets ______
        /// </summary>
        [JsonProperty(PropertyName = "client_contact_id")]
        public string ClientContactId { get; set; }

        /// <summary>
        /// Gets or sets ______
        /// </summary>
        [JsonProperty(PropertyName = "user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// Gets or sets the Payment Type ID
        /// </summary>
        [JsonProperty(PropertyName = "type_id")]
        public string TypeId { get; set; }

        /// <summary>
        /// Gets or sets the Payment date
        /// </summary>
        [JsonProperty(PropertyName = "date")]
        public string Date { get; set; }

        /// <summary>
        /// Gets or sets the transaction reference as defined by the payment
        /// gateway
        /// </summary>
        [JsonProperty(PropertyName = "transaction_reference")]
        public string TransactionReference { get; set; }

        /// <summary>
        /// Gets or sets ______
        /// </summary>
        [JsonProperty(PropertyName = "assigned_user_id")]
        public string AssignedUserId { get; set; }

        /// <summary>
        /// Gets or sets ______
        /// </summary>
        [JsonProperty(PropertyName = "private_notes")]
        public string PrivateNotes { get; set; }

        /// <summary>
        /// Gets or sets ______
        /// </summary>
        [JsonProperty(PropertyName = "is_manual")]
        public bool? IsManual { get; set; }

        /// <summary>
        /// Gets or sets ______
        /// </summary>
        [JsonProperty(PropertyName = "is_deleted")]
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// Gets or sets the amount of this payment
        /// </summary>
        [JsonProperty(PropertyName = "amount")]
        public double? Amount { get; set; }

        /// <summary>
        /// Gets or sets the refunded amount of this payment
        /// </summary>
        [JsonProperty(PropertyName = "refunded")]
        public double? Refunded { get; set; }

        /// <summary>
        /// Gets or sets timestamp
        /// </summary>
        [JsonProperty(PropertyName = "updated_at")]
        public double? UpdatedAt { get; set; }

        /// <summary>
        /// Gets or sets timestamp
        /// </summary>
        [JsonProperty(PropertyName = "archived_at")]
        public double? ArchivedAt { get; set; }

        /// <summary>
        /// Gets or sets the company gateway id
        /// </summary>
        [JsonProperty(PropertyName = "company_gateway_id")]
        public string CompanyGatewayId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "paymentables")]
        public Paymentable Paymentables { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "invoices")]
        public IList<InvoicePaymentable> Invoices { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "credits")]
        public IList<CreditPaymentable> Credits { get; set; }

    }
}