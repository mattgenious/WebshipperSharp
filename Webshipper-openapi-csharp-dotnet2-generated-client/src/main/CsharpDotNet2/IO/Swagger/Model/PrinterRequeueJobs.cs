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
  public class PrinterRequeueJobs {
    /// <summary>
    /// Gets or Sets StartTime
    /// </summary>
    [DataMember(Name="start_time", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "start_time")]
    public string StartTime { get; set; }

    /// <summary>
    /// Gets or Sets EndTime
    /// </summary>
    [DataMember(Name="end_time", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "end_time")]
    public string EndTime { get; set; }

    /// <summary>
    /// Gets or Sets JobId
    /// </summary>
    [DataMember(Name="job_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "job_id")]
    public string JobId { get; set; }

    /// <summary>
    /// Gets or Sets MarkAsComplete
    /// </summary>
    [DataMember(Name="mark_as_complete", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "mark_as_complete")]
    public string MarkAsComplete { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PrinterRequeueJobs {\n");
      sb.Append("  StartTime: ").Append(StartTime).Append("\n");
      sb.Append("  EndTime: ").Append(EndTime).Append("\n");
      sb.Append("  JobId: ").Append(JobId).Append("\n");
      sb.Append("  MarkAsComplete: ").Append(MarkAsComplete).Append("\n");
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
