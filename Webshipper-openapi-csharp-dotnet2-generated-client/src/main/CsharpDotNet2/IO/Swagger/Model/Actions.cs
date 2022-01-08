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
  public class Actions {
    /// <summary>
    /// Name of a supported job: <ul> <li> CreateShipmentJob </li> </ul>
    /// </summary>
    /// <value>Name of a supported job: <ul> <li> CreateShipmentJob </li> </ul></value>
    [DataMember(Name="job_type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "job_type")]
    public string JobType { get; set; }

    /// <summary>
    /// If true, this action runs as a background process, if not it runs immediately
    /// </summary>
    /// <value>If true, this action runs as a background process, if not it runs immediately</value>
    [DataMember(Name="async", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "async")]
    public bool? Async { get; set; }

    /// <summary>
    /// Array of objects containing keys <code>attr_values</code> and <code>attr_value</code>
    /// </summary>
    /// <value>Array of objects containing keys <code>attr_values</code> and <code>attr_value</code></value>
    [DataMember(Name="additional_attributes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "additional_attributes")]
    public List<string> AdditionalAttributes { get; set; }

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
      sb.Append("class Actions {\n");
      sb.Append("  JobType: ").Append(JobType).Append("\n");
      sb.Append("  Async: ").Append(Async).Append("\n");
      sb.Append("  AdditionalAttributes: ").Append(AdditionalAttributes).Append("\n");
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
