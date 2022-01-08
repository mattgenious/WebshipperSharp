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
  public class PdfMerges {
    /// <summary>
    /// Whether to include labels or not
    /// </summary>
    /// <value>Whether to include labels or not</value>
    [DataMember(Name="include_labels", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "include_labels")]
    public bool? IncludeLabels { get; set; }

    /// <summary>
    /// Whether to include docs or not' 
    /// </summary>
    /// <value>Whether to include docs or not' </value>
    [DataMember(Name="include_docs", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "include_docs")]
    public bool? IncludeDocs { get; set; }

    /// <summary>
    /// Whether to include slips or not
    /// </summary>
    /// <value>Whether to include slips or not</value>
    [DataMember(Name="include_slips", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "include_slips")]
    public bool? IncludeSlips { get; set; }

    /// <summary>
    /// Whether to use A4 paper size not
    /// </summary>
    /// <value>Whether to use A4 paper size not</value>
    [DataMember(Name="force_a4", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "force_a4")]
    public bool? ForceA4 { get; set; }

    /// <summary>
    /// A list of shipment ids to include in the merged pdf
    /// </summary>
    /// <value>A list of shipment ids to include in the merged pdf</value>
    [DataMember(Name="shipment_ids", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "shipment_ids")]
    public List<string> ShipmentIds { get; set; }

    /// <summary>
    /// A list of order ids to include in the merged pdf
    /// </summary>
    /// <value>A list of order ids to include in the merged pdf</value>
    [DataMember(Name="order_ids", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "order_ids")]
    public List<string> OrderIds { get; set; }

    /// <summary>
    /// Gets or Sets Url
    /// </summary>
    [DataMember(Name="url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "url")]
    public string Url { get; set; }

    /// <summary>
    /// Gets or Sets Failed
    /// </summary>
    [DataMember(Name="failed", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "failed")]
    public bool? Failed { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PdfMerges {\n");
      sb.Append("  IncludeLabels: ").Append(IncludeLabels).Append("\n");
      sb.Append("  IncludeDocs: ").Append(IncludeDocs).Append("\n");
      sb.Append("  IncludeSlips: ").Append(IncludeSlips).Append("\n");
      sb.Append("  ForceA4: ").Append(ForceA4).Append("\n");
      sb.Append("  ShipmentIds: ").Append(ShipmentIds).Append("\n");
      sb.Append("  OrderIds: ").Append(OrderIds).Append("\n");
      sb.Append("  Url: ").Append(Url).Append("\n");
      sb.Append("  Failed: ").Append(Failed).Append("\n");
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
