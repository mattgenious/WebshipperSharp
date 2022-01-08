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
  public class AdditionalAttributes {
    /// <summary>
    /// Visible name of the attribute
    /// </summary>
    /// <value>Visible name of the attribute</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Key for the attribute
    /// </summary>
    /// <value>Key for the attribute</value>
    [DataMember(Name="attr_key", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "attr_key")]
    public string AttrKey { get; set; }

    /// <summary>
    /// Value of the attribute
    /// </summary>
    /// <value>Value of the attribute</value>
    [DataMember(Name="attr_value", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "attr_value")]
    public string AttrValue { get; set; }

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
      sb.Append("class AdditionalAttributes {\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  AttrKey: ").Append(AttrKey).Append("\n");
      sb.Append("  AttrValue: ").Append(AttrValue).Append("\n");
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
