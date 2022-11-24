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
  public class Waybills {
    /// <summary>
    /// Name of the waybill type
    /// </summary>
    /// <value>Name of the waybill type</value>
    [DataMember(Name="waybill_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "waybill_name")]
    public string WaybillName { get; set; }

    /// <summary>
    /// Code identifying the type of waybill
    /// </summary>
    /// <value>Code identifying the type of waybill</value>
    [DataMember(Name="waybill_code", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "waybill_code")]
    public string WaybillCode { get; set; }

    /// <summary>
    /// Unique reference returned from the carrier implementation when a waybill is opened.
    /// </summary>
    /// <value>Unique reference returned from the carrier implementation when a waybill is opened.</value>
    [DataMember(Name="reference", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reference")]
    public string Reference { get; set; }

    /// <summary>
    /// Gets or Sets ConsolidationKey
    /// </summary>
    [DataMember(Name="consolidation_key", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "consolidation_key")]
    public string ConsolidationKey { get; set; }

    /// <summary>
    /// This will be assigned by the API if the waybill type has a barcode requirement.
    /// </summary>
    /// <value>This will be assigned by the API if the waybill type has a barcode requirement.</value>
    [DataMember(Name="barcode_serial", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "barcode_serial")]
    public int? BarcodeSerial { get; set; }

    /// <summary>
    /// Indicates whether the waybill is open or closed. When you want to close the waybill, you simply need to update the status of the way bill and set it to closed.
    /// </summary>
    /// <value>Indicates whether the waybill is open or closed. When you want to close the waybill, you simply need to update the status of the way bill and set it to closed.</value>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public int? Status { get; set; }

    /// <summary>
    /// This is a read-only attribute which returns the total number of shipments.
    /// </summary>
    /// <value>This is a read-only attribute which returns the total number of shipments.</value>
    [DataMember(Name="shipment_count", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "shipment_count")]
    public string ShipmentCount { get; set; }

    /// <summary>
    /// Gets or Sets Currency
    /// </summary>
    [DataMember(Name="currency", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "currency")]
    public string Currency { get; set; }

    /// <summary>
    /// Gets or Sets Copies
    /// </summary>
    [DataMember(Name="copies", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "copies")]
    public int? Copies { get; set; }

    /// <summary>
    /// The time when the resource was created
    /// </summary>
    /// <value>The time when the resource was created</value>
    [DataMember(Name="created_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "created_at")]
    public string CreatedAt { get; set; }

    /// <summary>
    /// The time when resource was last updated or when it was created if it was never updated
    /// </summary>
    /// <value>The time when resource was last updated or when it was created if it was never updated</value>
    [DataMember(Name="updated_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "updated_at")]
    public string UpdatedAt { get; set; }

    /// <summary>
    /// Array of documents. This is available when the waybill is closed.
    /// </summary>
    /// <value>Array of documents. This is available when the waybill is closed.</value>
    [DataMember(Name="documents", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "documents")]
    public string Documents { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Waybills {\n");
      sb.Append("  WaybillName: ").Append(WaybillName).Append("\n");
      sb.Append("  WaybillCode: ").Append(WaybillCode).Append("\n");
      sb.Append("  Reference: ").Append(Reference).Append("\n");
      sb.Append("  ConsolidationKey: ").Append(ConsolidationKey).Append("\n");
      sb.Append("  BarcodeSerial: ").Append(BarcodeSerial).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  ShipmentCount: ").Append(ShipmentCount).Append("\n");
      sb.Append("  Currency: ").Append(Currency).Append("\n");
      sb.Append("  Copies: ").Append(Copies).Append("\n");
      sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
      sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
      sb.Append("  Documents: ").Append(Documents).Append("\n");
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
