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
  public class Pickups {
    /// <summary>
    /// Instruction to the carrier.
    /// </summary>
    /// <value>Instruction to the carrier.</value>
    [DataMember(Name="pickup_instruction", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pickup_instruction")]
    public string PickupInstruction { get; set; }

    /// <summary>
    /// When the pickup location is closing.
    /// </summary>
    /// <value>When the pickup location is closing.</value>
    [DataMember(Name="pickup_location_close_time", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pickup_location_close_time")]
    public string PickupLocationCloseTime { get; set; }

    /// <summary>
    /// The time you want the carrier to arrive at the pickup address.
    /// </summary>
    /// <value>The time you want the carrier to arrive at the pickup address.</value>
    [DataMember(Name="pickup_time", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pickup_time")]
    public string PickupTime { get; set; }

    /// <summary>
    /// The reference returned by the carrier.
    /// </summary>
    /// <value>The reference returned by the carrier.</value>
    [DataMember(Name="reference", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reference")]
    public string Reference { get; set; }

    /// <summary>
    /// Decides if the pickup is <code>requested</code> or <code>cancelled</code>. To cancel a pickup you must update the status to cancelled. 
    /// </summary>
    /// <value>Decides if the pickup is <code>requested</code> or <code>cancelled</code>. To cancel a pickup you must update the status to cancelled. </value>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public int? Status { get; set; }

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
    /// The address where the shipments must be picked up.
    /// </summary>
    /// <value>The address where the shipments must be picked up.</value>
    [DataMember(Name="shipping_address", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "shipping_address")]
    public string ShippingAddress { get; set; }

    /// <summary>
    /// The carrier that should pickup the shipments.
    /// </summary>
    /// <value>The carrier that should pickup the shipments.</value>
    [DataMember(Name="carrier", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "carrier")]
    public string Carrier { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Pickups {\n");
      sb.Append("  PickupInstruction: ").Append(PickupInstruction).Append("\n");
      sb.Append("  PickupLocationCloseTime: ").Append(PickupLocationCloseTime).Append("\n");
      sb.Append("  PickupTime: ").Append(PickupTime).Append("\n");
      sb.Append("  Reference: ").Append(Reference).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
      sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
      sb.Append("  ShippingAddress: ").Append(ShippingAddress).Append("\n");
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
