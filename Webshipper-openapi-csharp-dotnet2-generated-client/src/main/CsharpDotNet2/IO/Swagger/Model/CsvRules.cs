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
  public class CsvRules {
    /// <summary>
    /// Path of the attribute to update
    /// </summary>
    /// <value>Path of the attribute to update</value>
    [DataMember(Name="target_path", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "target_path")]
    public string TargetPath { get; set; }

    /// <summary>
    /// The index of the field in the CSV file to be mapped
    /// </summary>
    /// <value>The index of the field in the CSV file to be mapped</value>
    [DataMember(Name="source_index", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "source_index")]
    public int? SourceIndex { get; set; }

    /// <summary>
    /// Value to use if the value in the CSV file is empty or missing
    /// </summary>
    /// <value>Value to use if the value in the CSV file is empty or missing</value>
    [DataMember(Name="default_value", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "default_value")]
    public string DefaultValue { get; set; }

    /// <summary>
    /// A key/value mapping for converting values before creating the object
    /// </summary>
    /// <value>A key/value mapping for converting values before creating the object</value>
    [DataMember(Name="input_conversions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "input_conversions")]
    public Object InputConversions { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CsvRules {\n");
      sb.Append("  TargetPath: ").Append(TargetPath).Append("\n");
      sb.Append("  SourceIndex: ").Append(SourceIndex).Append("\n");
      sb.Append("  DefaultValue: ").Append(DefaultValue).Append("\n");
      sb.Append("  InputConversions: ").Append(InputConversions).Append("\n");
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
