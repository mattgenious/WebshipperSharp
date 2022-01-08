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
  public class BarcodeRanges {
    /// <summary>
    /// String like DPD or SSCC
    /// </summary>
    /// <value>String like DPD or SSCC</value>
    [DataMember(Name="barcode_type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "barcode_type")]
    public string BarcodeType { get; set; }

    /// <summary>
    /// The first barcode in the range
    /// </summary>
    /// <value>The first barcode in the range</value>
    [DataMember(Name="serial_from", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "serial_from")]
    public int? SerialFrom { get; set; }

    /// <summary>
    /// The last barcode in the range
    /// </summary>
    /// <value>The last barcode in the range</value>
    [DataMember(Name="serial_to", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "serial_to")]
    public int? SerialTo { get; set; }

    /// <summary>
    /// The last used (highest) barcode serial
    /// </summary>
    /// <value>The last used (highest) barcode serial</value>
    [DataMember(Name="current_serial", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "current_serial")]
    public int? CurrentSerial { get; set; }

    /// <summary>
    /// Gets or Sets UsageStatus
    /// </summary>
    [DataMember(Name="usage_status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "usage_status")]
    public int? UsageStatus { get; set; }

    /// <summary>
    /// Gets or Sets ReplacesId
    /// </summary>
    [DataMember(Name="replaces_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "replaces_id")]
    public string ReplacesId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class BarcodeRanges {\n");
      sb.Append("  BarcodeType: ").Append(BarcodeType).Append("\n");
      sb.Append("  SerialFrom: ").Append(SerialFrom).Append("\n");
      sb.Append("  SerialTo: ").Append(SerialTo).Append("\n");
      sb.Append("  CurrentSerial: ").Append(CurrentSerial).Append("\n");
      sb.Append("  UsageStatus: ").Append(UsageStatus).Append("\n");
      sb.Append("  ReplacesId: ").Append(ReplacesId).Append("\n");
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
