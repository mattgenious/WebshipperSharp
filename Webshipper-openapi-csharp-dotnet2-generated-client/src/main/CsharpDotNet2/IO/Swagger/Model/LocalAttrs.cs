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
  public class LocalAttrs {
    /// <summary>
    /// Visible name of the attribute
    /// </summary>
    /// <value>Visible name of the attribute</value>
    [DataMember(Name="attr_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "attr_name")]
    public string AttrName { get; set; }

    /// <summary>
    /// Key for the attribute. Used by the system to read the correct information
    /// </summary>
    /// <value>Key for the attribute. Used by the system to read the correct information</value>
    [DataMember(Name="attr_key", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "attr_key")]
    public string AttrKey { get; set; }

    /// <summary>
    /// Data type. Must be either of the following: <code>string</code>, <code>integer</code> or <code>password</code>
    /// </summary>
    /// <value>Data type. Must be either of the following: <code>string</code>, <code>integer</code> or <code>password</code></value>
    [DataMember(Name="attr_type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "attr_type")]
    public string AttrType { get; set; }

    /// <summary>
    /// Determines if the form should require the attr to be filled
    /// </summary>
    /// <value>Determines if the form should require the attr to be filled</value>
    [DataMember(Name="is_required", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "is_required")]
    public bool? IsRequired { get; set; }

    /// <summary>
    /// Help text to describe the attribute
    /// </summary>
    /// <value>Help text to describe the attribute</value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// Gets or Sets RequirementType
    /// </summary>
    [DataMember(Name="requirement_type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "requirement_type")]
    public int? RequirementType { get; set; }

    /// <summary>
    /// Gets or Sets Category
    /// </summary>
    [DataMember(Name="category", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "category")]
    public string Category { get; set; }

    /// <summary>
    /// Gets or Sets Priority
    /// </summary>
    [DataMember(Name="priority", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "priority")]
    public int? Priority { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class LocalAttrs {\n");
      sb.Append("  AttrName: ").Append(AttrName).Append("\n");
      sb.Append("  AttrKey: ").Append(AttrKey).Append("\n");
      sb.Append("  AttrType: ").Append(AttrType).Append("\n");
      sb.Append("  IsRequired: ").Append(IsRequired).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  RequirementType: ").Append(RequirementType).Append("\n");
      sb.Append("  Category: ").Append(Category).Append("\n");
      sb.Append("  Priority: ").Append(Priority).Append("\n");
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
