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
  public class CarriersidRelationships {
    /// <summary>
    /// Gets or Sets CarrierType
    /// </summary>
    [DataMember(Name="carrier_type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "carrier_type")]
    public CarriersidRelationshipsCarrierType CarrierType { get; set; }

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
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CarriersidRelationships {\n");
      sb.Append("  CarrierType: ").Append(CarrierType).Append("\n");
      sb.Append("  SenderAddress: ").Append(SenderAddress).Append("\n");
      sb.Append("  ReturnAddress: ").Append(ReturnAddress).Append("\n");
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
