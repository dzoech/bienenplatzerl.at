using System;
using System.Collections.Generic;
using System.Text;

namespace InvoiceNinjaToWooCommerceSynchronizer.Dtos
{
    public class InvoiceEventDto
    {
        public string account_key { get; set; }
        public bool is_owner { get; set; }
        public int user_id { get; set; }
        public int id { get; set; }
        public int amount { get; set; }
        public int balance { get; set; }
        public int client_id { get; set; }
        public int invoice_status_id { get; set; }
        public int updated_at { get; set; }
        public object archived_at { get; set; }
        public string invoice_number { get; set; }
        public int discount { get; set; }
        public string po_number { get; set; }
        public string invoice_date { get; set; }
        public string due_date { get; set; }
        public string terms { get; set; }
        public string public_notes { get; set; }
        public string private_notes { get; set; }
        public bool is_deleted { get; set; }
        public int invoice_type_id { get; set; }
        public bool is_recurring { get; set; }
        public int frequency_id { get; set; }
        public string start_date { get; set; }
        public string end_date { get; set; }
        public string last_sent_date { get; set; }
        public int recurring_invoice_id { get; set; }
        public string tax_name1 { get; set; }
        public int tax_rate1 { get; set; }
        public string tax_name2 { get; set; }
        public int tax_rate2 { get; set; }
        public bool is_amount_discount { get; set; }
        public string invoice_footer { get; set; }
        public int partial { get; set; }
        public string partial_due_date { get; set; }
        public bool has_tasks { get; set; }
        public bool auto_bill { get; set; }
        public int auto_bill_id { get; set; }
        public int custom_value1 { get; set; }
        public int custom_value2 { get; set; }
        public bool custom_taxes1 { get; set; }
        public bool custom_taxes2 { get; set; }
        public bool has_expenses { get; set; }
        public int quote_invoice_id { get; set; }
        public string custom_text_value1 { get; set; }
        public string custom_text_value2 { get; set; }
        public bool is_quote { get; set; }
        public bool is_public { get; set; }
        public string filename { get; set; }
        public int invoice_design_id { get; set; }
        public Invoice_Items[] invoice_items { get; set; }
        public Client client { get; set; }
        public string client_name { get; set; }
    }

    public class Client
    {
        public string account_key { get; set; }
        public bool is_owner { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public string display_name { get; set; }
        public int balance { get; set; }
        public int paid_to_date { get; set; }
        public int updated_at { get; set; }
        public object archived_at { get; set; }
        public string address1 { get; set; }
        public string address2 { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string postal_code { get; set; }
        public int country_id { get; set; }
        public string work_phone { get; set; }
        public string private_notes { get; set; }
        public string public_notes { get; set; }
        public string last_login { get; set; }
        public string website { get; set; }
        public int industry_id { get; set; }
        public int size_id { get; set; }
        public bool is_deleted { get; set; }
        public int payment_terms { get; set; }
        public string vat_number { get; set; }
        public string id_number { get; set; }
        public int language_id { get; set; }
        public int currency_id { get; set; }
        public string custom_value1 { get; set; }
        public string custom_value2 { get; set; }
        public int invoice_number_counter { get; set; }
        public int quote_number_counter { get; set; }
        public int task_rate { get; set; }
        public string shipping_address1 { get; set; }
        public string shipping_address2 { get; set; }
        public string shipping_city { get; set; }
        public string shipping_state { get; set; }
        public string shipping_postal_code { get; set; }
        public int shipping_country_id { get; set; }
        public bool show_tasks_in_portal { get; set; }
        public bool send_reminders { get; set; }
        public int credit_number_counter { get; set; }
        public string custom_messages { get; set; }
        public Contact[] contacts { get; set; }
    }

    public class Contact
    {
        public string account_key { get; set; }
        public bool is_owner { get; set; }
        public int id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string email { get; set; }
        public string contact_key { get; set; }
        public int updated_at { get; set; }
        public object archived_at { get; set; }
        public bool is_primary { get; set; }
        public string phone { get; set; }
        public string last_login { get; set; }
        public bool send_invoice { get; set; }
        public string custom_value1 { get; set; }
        public string custom_value2 { get; set; }
    }

    public class Invoice_Items
    {
        public string account_key { get; set; }
        public bool is_owner { get; set; }
        public int id { get; set; }
        public string product_key { get; set; }
        public int updated_at { get; set; }
        public object archived_at { get; set; }
        public string notes { get; set; }
        public decimal cost { get; set; }
        public int qty { get; set; }
        public string tax_name1 { get; set; }
        public int tax_rate1 { get; set; }
        public string tax_name2 { get; set; }
        public int tax_rate2 { get; set; }
        public int invoice_item_type_id { get; set; }
        public string custom_value1 { get; set; }
        public string custom_value2 { get; set; }
        public int discount { get; set; }
    }

}
