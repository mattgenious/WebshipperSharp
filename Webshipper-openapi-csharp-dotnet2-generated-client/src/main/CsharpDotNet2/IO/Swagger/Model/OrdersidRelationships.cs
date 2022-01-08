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
  public class OrdersidRelationships {
    /// <summary>
    /// Gets or Sets OrderChannel
    /// </summary>
    [DataMember(Name="order_channel", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "order_channel")]
    public CsvMappingsidRelationshipsOrderChannel OrderChannel { get; set; }

    /// <summary>
    /// Gets or Sets ShippingRate
    /// </summary>
    [DataMember(Name="shipping_rate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "shipping_rate")]
    public OrdersidRelationshipsShippingRate ShippingRate { get; set; }

    /// <summary>
    /// Gets or Sets ErrorType
    /// </summary>
    [DataMember(Name="error_type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "error_type")]
    public OrdersidRelationshipsErrorType ErrorType { get; set; }

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
      sb.Append("class OrdersidRelationships {\n");
      sb.Append("  OrderChannel: ").Append(OrderChannel).Append("\n");
      sb.Append("  ShippingRate: ").Append(ShippingRate).Append("\n");
      sb.Append("  ErrorType: ").Append(ErrorType).Append("\n");
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
