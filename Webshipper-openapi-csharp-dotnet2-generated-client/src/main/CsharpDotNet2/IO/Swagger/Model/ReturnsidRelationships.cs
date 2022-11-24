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
  public class ReturnsidRelationships {
    /// <summary>
    /// Gets or Sets Order
    /// </summary>
    [DataMember(Name="order", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "order")]
    public AdditionalAttributesidRelationshipsOrder Order { get; set; }

    /// <summary>
    /// Gets or Sets Portal
    /// </summary>
    [DataMember(Name="portal", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "portal")]
    public ReturnRefundMethodsidRelationshipsPortal Portal { get; set; }

    /// <summary>
    /// Gets or Sets ShippingMethod
    /// </summary>
    [DataMember(Name="shipping_method", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "shipping_method")]
    public ReturnsidRelationshipsShippingMethod ShippingMethod { get; set; }

    /// <summary>
    /// Gets or Sets RefundMethod
    /// </summary>
    [DataMember(Name="refund_method", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "refund_method")]
    public ReturnsidRelationshipsRefundMethod RefundMethod { get; set; }

    /// <summary>
    /// Gets or Sets Shipment
    /// </summary>
    [DataMember(Name="shipment", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "shipment")]
    public PackagesRelationshipsShipment Shipment { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ReturnsidRelationships {\n");
      sb.Append("  Order: ").Append(Order).Append("\n");
      sb.Append("  Portal: ").Append(Portal).Append("\n");
      sb.Append("  ShippingMethod: ").Append(ShippingMethod).Append("\n");
      sb.Append("  RefundMethod: ").Append(RefundMethod).Append("\n");
      sb.Append("  Shipment: ").Append(Shipment).Append("\n");
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
