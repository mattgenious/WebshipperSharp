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
  public class StoresidRelationships {
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
    /// Gets or Sets PickupAddress
    /// </summary>
    [DataMember(Name="pickup_address", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pickup_address")]
    public CarriersidRelationshipsSenderAddress PickupAddress { get; set; }

    /// <summary>
    /// Gets or Sets SoldFromAddress
    /// </summary>
    [DataMember(Name="sold_from_address", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sold_from_address")]
    public CarriersidRelationshipsSenderAddress SoldFromAddress { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class StoresidRelationships {\n");
      sb.Append("  SenderAddress: ").Append(SenderAddress).Append("\n");
      sb.Append("  ReturnAddress: ").Append(ReturnAddress).Append("\n");
      sb.Append("  PickupAddress: ").Append(PickupAddress).Append("\n");
      sb.Append("  SoldFromAddress: ").Append(SoldFromAddress).Append("\n");
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
