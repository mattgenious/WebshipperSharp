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
  public class DropPointLocators {
    /// <summary>
    /// ID of the carrier that you want to quote. <strong>This is only mandatory if no shipping_rate_id is given</strong>.
    /// </summary>
    /// <value>ID of the carrier that you want to quote. <strong>This is only mandatory if no shipping_rate_id is given</strong>.</value>
    [DataMember(Name="carrier_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "carrier_id")]
    public int? CarrierId { get; set; }

    /// <summary>
    /// Service code for the service that you want to quote. <strong>This is only mandatory if no shipping_rate_id is given.</strong>
    /// </summary>
    /// <value>Service code for the service that you want to quote. <strong>This is only mandatory if no shipping_rate_id is given.</strong></value>
    [DataMember(Name="service_code", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "service_code")]
    public string ServiceCode { get; set; }

    /// <summary>
    /// ID of the shipping rate that you want to quote. <strong>This is only mandatory if no carrier_id is given.</strong>.
    /// </summary>
    /// <value>ID of the shipping rate that you want to quote. <strong>This is only mandatory if no carrier_id is given.</strong>.</value>
    [DataMember(Name="shipping_rate_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "shipping_rate_id")]
    public string ShippingRateId { get; set; }

    /// <summary>
    /// Gets or Sets DropPointId
    /// </summary>
    [DataMember(Name="drop_point_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "drop_point_id")]
    public string DropPointId { get; set; }

    /// <summary>
    /// Flattened shipping address object. <code>zip</code> and <code>country_code</code>  are required and <code>address_1</code> is optional.
    /// </summary>
    /// <value>Flattened shipping address object. <code>zip</code> and <code>country_code</code>  are required and <code>address_1</code> is optional.</value>
    [DataMember(Name="delivery_address", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "delivery_address")]
    public string DeliveryAddress { get; set; }

    /// <summary>
    /// Array of drop points near delivery_address. This will be populated in the response.
    /// </summary>
    /// <value>Array of drop points near delivery_address. This will be populated in the response.</value>
    [DataMember(Name="drop_points", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "drop_points")]
    public List<DropPoints> DropPoints { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DropPointLocators {\n");
      sb.Append("  CarrierId: ").Append(CarrierId).Append("\n");
      sb.Append("  ServiceCode: ").Append(ServiceCode).Append("\n");
      sb.Append("  ShippingRateId: ").Append(ShippingRateId).Append("\n");
      sb.Append("  DropPointId: ").Append(DropPointId).Append("\n");
      sb.Append("  DeliveryAddress: ").Append(DeliveryAddress).Append("\n");
      sb.Append("  DropPoints: ").Append(DropPoints).Append("\n");
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
