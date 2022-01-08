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
  public class OrderChannelAccessesidRelationships {
    /// <summary>
    /// Gets or Sets OrderChannel
    /// </summary>
    [DataMember(Name="order_channel", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "order_channel")]
    public CsvMappingsidRelationshipsOrderChannel OrderChannel { get; set; }

    /// <summary>
    /// Gets or Sets User
    /// </summary>
    [DataMember(Name="user", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "user")]
    public CarrierAccessesRelationshipsUser User { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class OrderChannelAccessesidRelationships {\n");
      sb.Append("  OrderChannel: ").Append(OrderChannel).Append("\n");
      sb.Append("  User: ").Append(User).Append("\n");
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
