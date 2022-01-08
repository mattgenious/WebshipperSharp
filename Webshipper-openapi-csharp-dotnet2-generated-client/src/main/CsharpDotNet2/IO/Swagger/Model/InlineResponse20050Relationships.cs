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
  public class InlineResponse20050Relationships {
    /// <summary>
    /// Gets or Sets OrderChannelType
    /// </summary>
    [DataMember(Name="order_channel_type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "order_channel_type")]
    public OrderChannelsidRelationshipsOrderChannelType OrderChannelType { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class InlineResponse20050Relationships {\n");
      sb.Append("  OrderChannelType: ").Append(OrderChannelType).Append("\n");
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
