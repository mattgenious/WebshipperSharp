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
  public class BulkPrinterJobs {
    /// <summary>
    /// Gets or Sets Ids
    /// </summary>
    [DataMember(Name="ids", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ids")]
    public string Ids { get; set; }

    /// <summary>
    /// Gets or Sets ModelType
    /// </summary>
    [DataMember(Name="model_type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "model_type")]
    public string ModelType { get; set; }

    /// <summary>
    /// Gets or Sets PrinterClientId
    /// </summary>
    [DataMember(Name="printer_client_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "printer_client_id")]
    public string PrinterClientId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class BulkPrinterJobs {\n");
      sb.Append("  Ids: ").Append(Ids).Append("\n");
      sb.Append("  ModelType: ").Append(ModelType).Append("\n");
      sb.Append("  PrinterClientId: ").Append(PrinterClientId).Append("\n");
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
