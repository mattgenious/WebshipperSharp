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
  public class ShipmentsRelationships {
    /// <summary>
    /// Gets or Sets Carrier
    /// </summary>
    [DataMember(Name="carrier", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "carrier")]
    public BarcodeRangesidRelationshipsCarrier Carrier { get; set; }

    /// <summary>
    /// Gets or Sets Order
    /// </summary>
    [DataMember(Name="order", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "order")]
    public AdditionalAttributesidRelationshipsOrder Order { get; set; }

    /// <summary>
    /// Gets or Sets ShippingRate
    /// </summary>
    [DataMember(Name="shipping_rate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "shipping_rate")]
    public OrdersidRelationshipsShippingRate ShippingRate { get; set; }

    /// <summary>
    /// Gets or Sets PrinterClient
    /// </summary>
    [DataMember(Name="printer_client", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "printer_client")]
    public OrdersidRelationshipsPrinterClient PrinterClient { get; set; }

    /// <summary>
    /// Gets or Sets OriginalShipment
    /// </summary>
    [DataMember(Name="original_shipment", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "original_shipment")]
    public PackagesRelationshipsShipment OriginalShipment { get; set; }

    /// <summary>
    /// Gets or Sets Pickup
    /// </summary>
    [DataMember(Name="pickup", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pickup")]
    public ShipmentsRelationshipsPickup Pickup { get; set; }

    /// <summary>
    /// Gets or Sets MailTemplate
    /// </summary>
    [DataMember(Name="mail_template", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "mail_template")]
    public ReturnPortalsidRelationshipsMailTemplate MailTemplate { get; set; }

    /// <summary>
    /// Gets or Sets ReturnLabelMailTemplate
    /// </summary>
    [DataMember(Name="return_label_mail_template", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "return_label_mail_template")]
    public ReturnPortalsidRelationshipsMailTemplate ReturnLabelMailTemplate { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ShipmentsRelationships {\n");
      sb.Append("  Carrier: ").Append(Carrier).Append("\n");
      sb.Append("  Order: ").Append(Order).Append("\n");
      sb.Append("  ShippingRate: ").Append(ShippingRate).Append("\n");
      sb.Append("  PrinterClient: ").Append(PrinterClient).Append("\n");
      sb.Append("  OriginalShipment: ").Append(OriginalShipment).Append("\n");
      sb.Append("  Pickup: ").Append(Pickup).Append("\n");
      sb.Append("  MailTemplate: ").Append(MailTemplate).Append("\n");
      sb.Append("  ReturnLabelMailTemplate: ").Append(ReturnLabelMailTemplate).Append("\n");
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
