using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class ServiceQuotes {
    /// <summary>
    /// True if quote was successful
    /// </summary>
    /// <value>True if quote was successful</value>
    [DataMember(Name="success", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "success")]
    public bool? Success { get; set; }

    /// <summary>
    /// The id of the carrier to quote
    /// </summary>
    /// <value>The id of the carrier to quote</value>
    [DataMember(Name="carrier_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "carrier_id")]
    public int? CarrierId { get; set; }

    /// <summary>
    /// Service code of the carrier. This is optional. When omitted, all supported services will be returned.
    /// </summary>
    /// <value>Service code of the carrier. This is optional. When omitted, all supported services will be returned.</value>
    [DataMember(Name="service_code", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "service_code")]
    public string ServiceCode { get; set; }

    /// <summary>
    /// ISO 8601 formatted
    /// </summary>
    /// <value>ISO 8601 formatted</value>
    [DataMember(Name="send_time", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "send_time")]
    public string SendTime { get; set; }

    /// <summary>
    /// Gets or Sets SendDate
    /// </summary>
    [DataMember(Name="send_date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "send_date")]
    public string SendDate { get; set; }

    /// <summary>
    /// Array of objects, each containing key <code>weight</code>. At least one package is required.
    /// </summary>
    /// <value>Array of objects, each containing key <code>weight</code>. At least one package is required.</value>
    [DataMember(Name="packages", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "packages")]
    public List<string> Packages { get; set; }

    /// <summary>
    /// Delivery address for the quote
    /// </summary>
    /// <value>Delivery address for the quote</value>
    [DataMember(Name="delivery_address", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "delivery_address")]
    public Object DeliveryAddress { get; set; }

    /// <summary>
    /// Sender address for the quote
    /// </summary>
    /// <value>Sender address for the quote</value>
    [DataMember(Name="sender_address", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sender_address")]
    public Object SenderAddress { get; set; }

    /// <summary>
    /// Read only. Populated in response with an array of objects containing the following keys: <ul class='list-doc'>  <li><code>service_name</code></li>  <li><code>service_code</code></li>  <li><code>is_return</code></li>    <li><code>supports_paperless</code></li>    <li><code>requires_drop_point</code></li>    <li><code>cost_price</code></li>    <li><code>currency</code></li>    <li><code>vat_percent</code></li>    <li><code>estimated_delivery_date_from</code></li>    <li><code>estimated_delivery_date_to</code></li>    <li>    <code>add_ons</code> <div class='text-muted'>Array containing objects</div>   <ul class='list-doc'>     <li><code>add_on_name</code></li>     <li><code>add_on_code</code></li>   </ul> </li>    <li><code>parameters</code></li> <div class='text-muted'>Array containing objects</div>    <ul class='list-doc'>     <li><code>attr_name</code></li>     <li><code>attr_key</code></li>     <li><code>attr_type</code></li>    </ul>    <li><code>country_combinations</code></li>    <li><code>barcode_requirement</code></li>    <li><code>waybill_requirement</code></li>    <li><code>booking_quote_info</code></li>    <li><code>supported_colli_types</code></li>  </ul>
    /// </summary>
    /// <value>Read only. Populated in response with an array of objects containing the following keys: <ul class='list-doc'>  <li><code>service_name</code></li>  <li><code>service_code</code></li>  <li><code>is_return</code></li>    <li><code>supports_paperless</code></li>    <li><code>requires_drop_point</code></li>    <li><code>cost_price</code></li>    <li><code>currency</code></li>    <li><code>vat_percent</code></li>    <li><code>estimated_delivery_date_from</code></li>    <li><code>estimated_delivery_date_to</code></li>    <li>    <code>add_ons</code> <div class='text-muted'>Array containing objects</div>   <ul class='list-doc'>     <li><code>add_on_name</code></li>     <li><code>add_on_code</code></li>   </ul> </li>    <li><code>parameters</code></li> <div class='text-muted'>Array containing objects</div>    <ul class='list-doc'>     <li><code>attr_name</code></li>     <li><code>attr_key</code></li>     <li><code>attr_type</code></li>    </ul>    <li><code>country_combinations</code></li>    <li><code>barcode_requirement</code></li>    <li><code>waybill_requirement</code></li>    <li><code>booking_quote_info</code></li>    <li><code>supported_colli_types</code></li>  </ul></value>
    [DataMember(Name="services", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "services")]
    public List<string> Services { get; set; }

    /// <summary>
    /// Carrier add-ons for the quote
    /// </summary>
    /// <value>Carrier add-ons for the quote</value>
    [DataMember(Name="add_ons", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "add_ons")]
    public string AddOns { get; set; }

    /// <summary>
    /// Service attributes for the carrier
    /// </summary>
    /// <value>Service attributes for the carrier</value>
    [DataMember(Name="service_attributes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "service_attributes")]
    public string ServiceAttributes { get; set; }

    /// <summary>
    /// Determines if you are quoting for return (inbound) services or standard (outbound) services.
    /// </summary>
    /// <value>Determines if you are quoting for return (inbound) services or standard (outbound) services.</value>
    [DataMember(Name="is_return", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "is_return")]
    public string IsReturn { get; set; }

    /// <summary>
    /// Determines if the goods for the quote are dutiable
    /// </summary>
    /// <value>Determines if the goods for the quote are dutiable</value>
    [DataMember(Name="dutiable", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dutiable")]
    public string Dutiable { get; set; }

    /// <summary>
    /// Used if you want only a price from a specific cost sheet
    /// </summary>
    /// <value>Used if you want only a price from a specific cost sheet</value>
    [DataMember(Name="cost_sheet_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cost_sheet_id")]
    public string CostSheetId { get; set; }

    /// <summary>
    /// Gets or Sets Timeout
    /// </summary>
    [DataMember(Name="timeout", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "timeout")]
    public string Timeout { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ServiceQuotes {\n");
      sb.Append("  Success: ").Append(Success).Append("\n");
      sb.Append("  CarrierId: ").Append(CarrierId).Append("\n");
      sb.Append("  ServiceCode: ").Append(ServiceCode).Append("\n");
      sb.Append("  SendTime: ").Append(SendTime).Append("\n");
      sb.Append("  SendDate: ").Append(SendDate).Append("\n");
      sb.Append("  Packages: ").Append(Packages).Append("\n");
      sb.Append("  DeliveryAddress: ").Append(DeliveryAddress).Append("\n");
      sb.Append("  SenderAddress: ").Append(SenderAddress).Append("\n");
      sb.Append("  Services: ").Append(Services).Append("\n");
      sb.Append("  AddOns: ").Append(AddOns).Append("\n");
      sb.Append("  ServiceAttributes: ").Append(ServiceAttributes).Append("\n");
      sb.Append("  IsReturn: ").Append(IsReturn).Append("\n");
      sb.Append("  Dutiable: ").Append(Dutiable).Append("\n");
      sb.Append("  CostSheetId: ").Append(CostSheetId).Append("\n");
      sb.Append("  Timeout: ").Append(Timeout).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
