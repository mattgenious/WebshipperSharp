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
  public class ReturnShippingMethodsidRelationships {
    /// <summary>
    /// Gets or Sets Portal
    /// </summary>
    [DataMember(Name="portal", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "portal")]
    public ReturnRefundMethodsidRelationshipsPortal Portal { get; set; }

    /// <summary>
    /// Gets or Sets ShippingRate
    /// </summary>
    [DataMember(Name="shipping_rate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "shipping_rate")]
    public OrdersidRelationshipsShippingRate ShippingRate { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ReturnShippingMethodsidRelationships {\n");
      sb.Append("  Portal: ").Append(Portal).Append("\n");
      sb.Append("  ShippingRate: ").Append(ShippingRate).Append("\n");
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
