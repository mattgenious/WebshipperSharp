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
  public class InlineResponse200116Relationships {
    /// <summary>
    /// Gets or Sets Package
    /// </summary>
    [DataMember(Name="package", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "package")]
    public InlineResponse200116RelationshipsPackage Package { get; set; }

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
      sb.Append("class InlineResponse200116Relationships {\n");
      sb.Append("  Package: ").Append(Package).Append("\n");
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
