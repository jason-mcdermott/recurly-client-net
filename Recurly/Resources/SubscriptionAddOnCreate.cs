using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Newtonsoft.Json;

namespace Recurly.Resources {
  [ExcludeFromCodeCoverage] 
  public class SubscriptionAddOnCreate : Request {
  
    /// <value>Add-on code</value>
    [JsonProperty("code")]
    public string Code { get; set; }
  
    /// <value>Setting this field allows you to reference an existing add-on.</value>
    [JsonProperty("id")]
    public string Id { get; set; }
  
    /// <value>Optionally override the default quantity.</value>
    [JsonProperty("quantity")]
    public int? Quantity { get; set; }
  
    /// <value>Override the default unit amount of the add-on by setting this value.</value>
    [JsonProperty("unit_amount")]
    public float? UnitAmount { get; set; }
  
  }
}