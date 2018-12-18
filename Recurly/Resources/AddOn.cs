using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Newtonsoft.Json;

namespace Recurly.Resources {
  [ExcludeFromCodeCoverage] 
  public class AddOn : Resource {
  
    /// <value>Accounting code for invoice line items for this add-on. If no value is provided, it defaults to add-on's code.</value>
    [JsonProperty("accounting_code")]
    public string AccountingCode { get; set; }
  
    /// <value>The unique identifier for the add-on within its plan.</value>
    [JsonProperty("code")]
    public string Code { get; set; }
  
    /// <value>Created at</value>
    [JsonProperty("created_at")]
    public DateTime? CreatedAt { get; set; }
  
    /// <value>Add-on pricing</value>
    [JsonProperty("currencies")]
    public List<AddOnPricing> Currencies { get; set; }
  
    /// <value>Default quantity for the hosted pages.</value>
    [JsonProperty("default_quantity")]
    public int? DefaultQuantity { get; set; }
  
    /// <value>Deleted at</value>
    [JsonProperty("deleted_at")]
    public DateTime? DeletedAt { get; set; }
  
    /// <value>Determines if the quantity field is displayed on the hosted pages for the add-on.</value>
    [JsonProperty("display_quantity")]
    public bool? DisplayQuantity { get; set; }
  
    /// <value>Add-on ID</value>
    [JsonProperty("id")]
    public string Id { get; set; }
  
    /// <value>Describes your add-on and will appear in subscribers' invoices.</value>
    [JsonProperty("name")]
    public string Name { get; set; }
  
    /// <value>Plan ID</value>
    [JsonProperty("plan_id")]
    public string PlanId { get; set; }
  
    /// <value>Add-ons can be either active or inactive.</value>
    [JsonProperty("state")]
    public string State { get; set; }
  
    /// <value>Optional field for EU VAT merchants and Avalara AvaTax Pro merchants. If you are using Recurly's EU VAT feature, you can use values of 'unknown', 'physical', or 'digital'. If you have your own AvaTax account configured, you can use Avalara tax codes to assign custom tax rules.</value>
    [JsonProperty("tax_code")]
    public string TaxCode { get; set; }
  
    /// <value>Last updated at</value>
    [JsonProperty("updated_at")]
    public DateTime? UpdatedAt { get; set; }
  
  }
}