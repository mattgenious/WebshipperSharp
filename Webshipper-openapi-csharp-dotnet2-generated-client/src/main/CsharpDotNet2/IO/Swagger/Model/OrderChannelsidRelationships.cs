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
  public class OrderChannelsidRelationships {
    /// <summary>
    /// Gets or Sets OrderChannelType
    /// </summary>
    [DataMember(Name="order_channel_type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "order_channel_type")]
    public OrderChannelsidRelationshipsOrderChannelType OrderChannelType { get; set; }

    /// <summary>
    /// Gets or Sets SlipTemplate
    /// </summary>
    [DataMember(Name="slip_template", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "slip_template")]
    public OrderChannelsidRelationshipsSlipTemplate SlipTemplate { get; set; }

    /// <summary>
    /// Gets or Sets SenderAddress
    /// </summary>
    [DataMember(Name="sender_address", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sender_address")]
    public CarriersidRelationshipsSenderAddress SenderAddress { get; set; }

    /// <summary>
    /// Gets or Sets ReturnAddress
    /// </summary>
    [DataMember(Name="return_address", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "return_address")]
    public CarriersidRelationshipsSenderAddress ReturnAddress { get; set; }

    /// <summary>
    /// Gets or Sets PickupAddress
    /// </summary>
    [DataMember(Name="pickup_address", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pickup_address")]
    public CarriersidRelationshipsSenderAddress PickupAddress { get; set; }

    /// <summary>
    /// Gets or Sets SoldFromAddress
    /// </summary>
    [DataMember(Name="sold_from_address", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sold_from_address")]
    public CarriersidRelationshipsSenderAddress SoldFromAddress { get; set; }

    /// <summary>
    /// Gets or Sets DefaultPrinterClient
    /// </summary>
    [DataMember(Name="default_printer_client", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "default_printer_client")]
    public OrdersidRelationshipsPrinterClient DefaultPrinterClient { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class OrderChannelsidRelationships {\n");
      sb.Append("  OrderChannelType: ").Append(OrderChannelType).Append("\n");
      sb.Append("  SlipTemplate: ").Append(SlipTemplate).Append("\n");
      sb.Append("  SenderAddress: ").Append(SenderAddress).Append("\n");
      sb.Append("  ReturnAddress: ").Append(ReturnAddress).Append("\n");
      sb.Append("  PickupAddress: ").Append(PickupAddress).Append("\n");
      sb.Append("  SoldFromAddress: ").Append(SoldFromAddress).Append("\n");
      sb.Append("  DefaultPrinterClient: ").Append(DefaultPrinterClient).Append("\n");
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
