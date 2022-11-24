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
  public class WaybillsidRelationships {
    /// <summary>
    /// Gets or Sets Carrier
    /// </summary>
    [DataMember(Name="carrier", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "carrier")]
    public BarcodeRangesidRelationshipsCarrier Carrier { get; set; }

    /// <summary>
    /// Gets or Sets SoldToAddress
    /// </summary>
    [DataMember(Name="sold_to_address", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sold_to_address")]
    public CarriersidRelationshipsSenderAddress SoldToAddress { get; set; }

    /// <summary>
    /// Gets or Sets SenderAddress
    /// </summary>
    [DataMember(Name="sender_address", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sender_address")]
    public CarriersidRelationshipsSenderAddress SenderAddress { get; set; }

    /// <summary>
    /// Gets or Sets PrinterClient
    /// </summary>
    [DataMember(Name="printer_client", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "printer_client")]
    public OrdersidRelationshipsPrinterClient PrinterClient { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class WaybillsidRelationships {\n");
      sb.Append("  Carrier: ").Append(Carrier).Append("\n");
      sb.Append("  SoldToAddress: ").Append(SoldToAddress).Append("\n");
      sb.Append("  SenderAddress: ").Append(SenderAddress).Append("\n");
      sb.Append("  PrinterClient: ").Append(PrinterClient).Append("\n");
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
