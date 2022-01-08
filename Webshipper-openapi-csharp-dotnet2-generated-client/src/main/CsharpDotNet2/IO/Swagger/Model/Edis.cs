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
  public class Edis {
    /// <summary>
    /// Must be one of 'pending', 'on_hold' or 'sent'
    /// </summary>
    /// <value>Must be one of 'pending', 'on_hold' or 'sent'</value>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public int? Status { get; set; }

    /// <summary>
    /// The file contents (as text)
    /// </summary>
    /// <value>The file contents (as text)</value>
    [DataMember(Name="data", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "data")]
    public string Data { get; set; }

    /// <summary>
    /// Must be either 'utf8' or 'ascii'
    /// </summary>
    /// <value>Must be either 'utf8' or 'ascii'</value>
    [DataMember(Name="encoding", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "encoding")]
    public int? Encoding { get; set; }

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
    /// Text-based code representing the carrier type.
    /// </summary>
    /// <value>Text-based code representing the carrier type.</value>
    [DataMember(Name="carrier_code", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "carrier_code")]
    public string CarrierCode { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Edis {\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  Data: ").Append(Data).Append("\n");
      sb.Append("  Encoding: ").Append(Encoding).Append("\n");
      sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
      sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
      sb.Append("  CarrierCode: ").Append(CarrierCode).Append("\n");
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
