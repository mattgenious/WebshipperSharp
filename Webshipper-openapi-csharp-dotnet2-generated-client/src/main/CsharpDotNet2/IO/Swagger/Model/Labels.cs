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
  public class Labels {
    /// <summary>
    /// Gets or Sets ShipmentId
    /// </summary>
    [DataMember(Name="shipment_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "shipment_id")]
    public int? ShipmentId { get; set; }

    /// <summary>
    /// Size of the label. Enum with possible values: '100X150', '100X192'.
    /// </summary>
    /// <value>Size of the label. Enum with possible values: '100X150', '100X192'.</value>
    [DataMember(Name="label_size", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "label_size")]
    public int? LabelSize { get; set; }

    /// <summary>
    /// Label format. Enum with possible values: 'PDF', 'ZPL'.
    /// </summary>
    /// <value>Label format. Enum with possible values: 'PDF', 'ZPL'.</value>
    [DataMember(Name="label_format", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "label_format")]
    public int? LabelFormat { get; set; }

    /// <summary>
    /// Base64 encoding of the pdf document. (Can be an array, see the description above)
    /// </summary>
    /// <value>Base64 encoding of the pdf document. (Can be an array, see the description above)</value>
    [DataMember(Name="base64", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "base64")]
    public string Base64 { get; set; }

    /// <summary>
    /// The time when resource was last updated or when it was created if it was never updated
    /// </summary>
    /// <value>The time when resource was last updated or when it was created if it was never updated</value>
    [DataMember(Name="updated_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "updated_at")]
    public string UpdatedAt { get; set; }

    /// <summary>
    /// The time when the resource was created
    /// </summary>
    /// <value>The time when the resource was created</value>
    [DataMember(Name="created_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "created_at")]
    public string CreatedAt { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Labels {\n");
      sb.Append("  ShipmentId: ").Append(ShipmentId).Append("\n");
      sb.Append("  LabelSize: ").Append(LabelSize).Append("\n");
      sb.Append("  LabelFormat: ").Append(LabelFormat).Append("\n");
      sb.Append("  Base64: ").Append(Base64).Append("\n");
      sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
      sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
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
