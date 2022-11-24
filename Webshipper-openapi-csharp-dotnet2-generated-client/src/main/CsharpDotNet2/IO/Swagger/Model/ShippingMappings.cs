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
  public class ShippingMappings {
    /// <summary>
    /// Shipping code is a unique identifier from the order channel that will be mapped to a shipping rate
    /// </summary>
    /// <value>Shipping code is a unique identifier from the order channel that will be mapped to a shipping rate</value>
    [DataMember(Name="shipping_code", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "shipping_code")]
    public string ShippingCode { get; set; }

    /// <summary>
    /// Shipping name is a human readable identifier of the shipping method
    /// </summary>
    /// <value>Shipping name is a human readable identifier of the shipping method</value>
    [DataMember(Name="shipping_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "shipping_name")]
    public string ShippingName { get; set; }

    /// <summary>
    /// Shipping rate id is the id of the shipping rate which you want to map to.
    /// </summary>
    /// <value>Shipping rate id is the id of the shipping rate which you want to map to.</value>
    [DataMember(Name="shipping_rate_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "shipping_rate_id")]
    public int? ShippingRateId { get; set; }

    /// <summary>
    /// Order channel id of the order channel
    /// </summary>
    /// <value>Order channel id of the order channel</value>
    [DataMember(Name="order_channel_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "order_channel_id")]
    public int? OrderChannelId { get; set; }

    /// <summary>
    /// The time when the resource was created
    /// </summary>
    /// <value>The time when the resource was created</value>
    [DataMember(Name="created_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "created_at")]
    public string CreatedAt { get; set; }

    /// <summary>
    /// The time when resource was last updated or when it was created if it was never updated
    /// </summary>
    /// <value>The time when resource was last updated or when it was created if it was never updated</value>
    [DataMember(Name="updated_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "updated_at")]
    public string UpdatedAt { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ShippingMappings {\n");
      sb.Append("  ShippingCode: ").Append(ShippingCode).Append("\n");
      sb.Append("  ShippingName: ").Append(ShippingName).Append("\n");
      sb.Append("  ShippingRateId: ").Append(ShippingRateId).Append("\n");
      sb.Append("  OrderChannelId: ").Append(OrderChannelId).Append("\n");
      sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
      sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
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
