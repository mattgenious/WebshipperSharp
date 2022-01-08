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
  public class LocalAttrEnums {
    /// <summary>
    /// Visible name for the enum
    /// </summary>
    /// <value>Visible name for the enum</value>
    [DataMember(Name="enum_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "enum_name")]
    public string EnumName { get; set; }

    /// <summary>
    /// Value for the enum
    /// </summary>
    /// <value>Value for the enum</value>
    [DataMember(Name="enum_value", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "enum_value")]
    public string EnumValue { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class LocalAttrEnums {\n");
      sb.Append("  EnumName: ").Append(EnumName).Append("\n");
      sb.Append("  EnumValue: ").Append(EnumValue).Append("\n");
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
