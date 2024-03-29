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
  public class ReportsidRelationships {
    /// <summary>
    /// Gets or Sets ReportType
    /// </summary>
    [DataMember(Name="report_type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "report_type")]
    public ReportsidRelationshipsReportType ReportType { get; set; }

    /// <summary>
    /// Gets or Sets Carrier
    /// </summary>
    [DataMember(Name="carrier", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "carrier")]
    public BarcodeRangesidRelationshipsCarrier Carrier { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ReportsidRelationships {\n");
      sb.Append("  ReportType: ").Append(ReportType).Append("\n");
      sb.Append("  Carrier: ").Append(Carrier).Append("\n");
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
