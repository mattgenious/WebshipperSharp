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
  public class ShippingRatesidRelationships {
    /// <summary>
    /// Gets or Sets Carrier
    /// </summary>
    [DataMember(Name="carrier", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "carrier")]
    public BarcodeRangesidRelationshipsCarrier Carrier { get; set; }

    /// <summary>
    /// Gets or Sets OrderChannel
    /// </summary>
    [DataMember(Name="order_channel", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "order_channel")]
    public CsvMappingsidRelationshipsOrderChannel OrderChannel { get; set; }

    /// <summary>
    /// Gets or Sets ReturnShippingRate
    /// </summary>
    [DataMember(Name="return_shipping_rate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "return_shipping_rate")]
    public OrdersidRelationshipsShippingRate ReturnShippingRate { get; set; }

    /// <summary>
    /// Gets or Sets SenderAddress
    /// </summary>
    [DataMember(Name="sender_address", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sender_address")]
    public CarriersidRelationshipsSenderAddress SenderAddress { get; set; }

    /// <summary>
    /// Gets or Sets ReturnAddress
    /// </summary>
    [DataMember(Name="return_address", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "return_address")]
    public CarriersidRelationshipsSenderAddress ReturnAddress { get; set; }

    /// <summary>
    /// Gets or Sets MailTemplate
    /// </summary>
    [DataMember(Name="mail_template", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "mail_template")]
    public ReturnPortalsidRelationshipsMailTemplate MailTemplate { get; set; }

    /// <summary>
    /// Gets or Sets ReturnMailTemplate
    /// </summary>
    [DataMember(Name="return_mail_template", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "return_mail_template")]
    public ReturnPortalsidRelationshipsMailTemplate ReturnMailTemplate { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ShippingRatesidRelationships {\n");
      sb.Append("  Carrier: ").Append(Carrier).Append("\n");
      sb.Append("  OrderChannel: ").Append(OrderChannel).Append("\n");
      sb.Append("  ReturnShippingRate: ").Append(ReturnShippingRate).Append("\n");
      sb.Append("  SenderAddress: ").Append(SenderAddress).Append("\n");
      sb.Append("  ReturnAddress: ").Append(ReturnAddress).Append("\n");
      sb.Append("  MailTemplate: ").Append(MailTemplate).Append("\n");
      sb.Append("  ReturnMailTemplate: ").Append(ReturnMailTemplate).Append("\n");
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
