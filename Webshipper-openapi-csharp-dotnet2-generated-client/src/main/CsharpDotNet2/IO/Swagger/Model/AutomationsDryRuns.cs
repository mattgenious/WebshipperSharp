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
  public class AutomationsDryRuns {
    /// <summary>
    /// Gets or Sets DryRun
    /// </summary>
    [DataMember(Name="dry_run", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dry_run")]
    public string DryRun { get; set; }

    /// <summary>
    /// Gets or Sets Automation
    /// </summary>
    [DataMember(Name="automation", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "automation")]
    public string Automation { get; set; }

    /// <summary>
    /// Gets or Sets ShipmentId
    /// </summary>
    [DataMember(Name="shipment_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "shipment_id")]
    public string ShipmentId { get; set; }

    /// <summary>
    /// Gets or Sets OrderId
    /// </summary>
    [DataMember(Name="order_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "order_id")]
    public string OrderId { get; set; }

    /// <summary>
    /// Gets or Sets ReportId
    /// </summary>
    [DataMember(Name="report_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "report_id")]
    public string ReportId { get; set; }

    /// <summary>
    /// Gets or Sets ModelType
    /// </summary>
    [DataMember(Name="model_type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "model_type")]
    public string ModelType { get; set; }

    /// <summary>
    /// Gets or Sets ElementName
    /// </summary>
    [DataMember(Name="element_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "element_name")]
    public string ElementName { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AutomationsDryRuns {\n");
      sb.Append("  DryRun: ").Append(DryRun).Append("\n");
      sb.Append("  Automation: ").Append(Automation).Append("\n");
      sb.Append("  ShipmentId: ").Append(ShipmentId).Append("\n");
      sb.Append("  OrderId: ").Append(OrderId).Append("\n");
      sb.Append("  ReportId: ").Append(ReportId).Append("\n");
      sb.Append("  ModelType: ").Append(ModelType).Append("\n");
      sb.Append("  ElementName: ").Append(ElementName).Append("\n");
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
