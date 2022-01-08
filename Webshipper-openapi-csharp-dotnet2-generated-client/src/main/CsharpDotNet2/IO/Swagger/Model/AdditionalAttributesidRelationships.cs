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
  public class AdditionalAttributesidRelationships {
    /// <summary>
    /// Gets or Sets Order
    /// </summary>
    [DataMember(Name="order", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "order")]
    public AdditionalAttributesidRelationshipsOrder Order { get; set; }

    /// <summary>
    /// Gets or Sets OrderLine
    /// </summary>
    [DataMember(Name="order_line", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "order_line")]
    public AdditionalAttributesidRelationshipsOrderLine OrderLine { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AdditionalAttributesidRelationships {\n");
      sb.Append("  Order: ").Append(Order).Append("\n");
      sb.Append("  OrderLine: ").Append(OrderLine).Append("\n");
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
