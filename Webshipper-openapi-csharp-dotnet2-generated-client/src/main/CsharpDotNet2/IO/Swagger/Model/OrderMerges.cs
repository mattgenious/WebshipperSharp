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
  public class OrderMerges {
    /// <summary>
    /// ID of order to merge order lines in to
    /// </summary>
    /// <value>ID of order to merge order lines in to</value>
    [DataMember(Name="order_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "order_id")]
    public bool? OrderId { get; set; }

    /// <summary>
    /// Orders from which to merge order lines from. Orders as nested resources
    /// </summary>
    /// <value>Orders from which to merge order lines from. Orders as nested resources</value>
    [DataMember(Name="orders", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "orders")]
    public List<string> Orders { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class OrderMerges {\n");
      sb.Append("  OrderId: ").Append(OrderId).Append("\n");
      sb.Append("  Orders: ").Append(Orders).Append("\n");
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
