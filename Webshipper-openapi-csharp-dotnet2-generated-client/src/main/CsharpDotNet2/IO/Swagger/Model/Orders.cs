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
  public class Orders {
    /// <summary>
    /// DEPRECATED Assign a relation instead
    /// </summary>
    /// <value>DEPRECATED Assign a relation instead</value>
    [DataMember(Name="order_channel_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "order_channel_id")]
    public int? OrderChannelId { get; set; }

    /// <summary>
    /// Enum status of the order. Possible values: pending, dispatched, partly_dispatched, cancelled, error, missing_rate, on_hold
    /// </summary>
    /// <value>Enum status of the order. Possible values: pending, dispatched, partly_dispatched, cancelled, error, missing_rate, on_hold</value>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

    /// <summary>
    /// External ( hidden ) reference for the order. Used by system to update the order in e.g. order channels. Must be unique in scope of order channels.
    /// </summary>
    /// <value>External ( hidden ) reference for the order. Used by system to update the order in e.g. order channels. Must be unique in scope of order channels.</value>
    [DataMember(Name="ext_ref", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ext_ref")]
    public string ExtRef { get; set; }

    /// <summary>
    /// Visible reference - the friendly/visible external order number
    /// </summary>
    /// <value>Visible reference - the friendly/visible external order number</value>
    [DataMember(Name="visible_ref", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "visible_ref")]
    public string VisibleRef { get; set; }

    /// <summary>
    /// Gets or Sets DropPoint
    /// </summary>
    [DataMember(Name="drop_point", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "drop_point")]
    public DropPoints DropPoint { get; set; }

    /// <summary>
    /// Flattened resource describing the original shipping option from the order channel. This will be used for matching in cases where shipping was not quoted from Webshipper.
    /// </summary>
    /// <value>Flattened resource describing the original shipping option from the order channel. This will be used for matching in cases where shipping was not quoted from Webshipper.</value>
    [DataMember(Name="original_shipping", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "original_shipping")]
    public Object OriginalShipping { get; set; }

    /// <summary>
    /// Flattened resource of type OrderLine
    /// </summary>
    /// <value>Flattened resource of type OrderLine</value>
    [DataMember(Name="order_lines", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "order_lines")]
    public List<OrderLines> OrderLines { get; set; }

    /// <summary>
    /// Gets or Sets DeliveryAddress
    /// </summary>
    [DataMember(Name="delivery_address", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "delivery_address")]
    public ShippingAddresses DeliveryAddress { get; set; }

    /// <summary>
    /// Gets or Sets SenderAddress
    /// </summary>
    [DataMember(Name="sender_address", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sender_address")]
    public ShippingAddresses SenderAddress { get; set; }

    /// <summary>
    /// Gets or Sets BillingAddress
    /// </summary>
    [DataMember(Name="billing_address", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "billing_address")]
    public ShippingAddresses BillingAddress { get; set; }

    /// <summary>
    /// Gets or Sets SoldFromAddress
    /// </summary>
    [DataMember(Name="sold_from_address", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sold_from_address")]
    public ShippingAddresses SoldFromAddress { get; set; }

    /// <summary>
    /// Currency code of the order
    /// </summary>
    /// <value>Currency code of the order</value>
    [DataMember(Name="currency", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "currency")]
    public string Currency { get; set; }

    /// <summary>
    /// Internal order comment.
    /// </summary>
    /// <value>Internal order comment.</value>
    [DataMember(Name="internal_comment", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "internal_comment")]
    public string InternalComment { get; set; }

    /// <summary>
    /// External order comment. Will typically be the order comment from e-commerce checkout.
    /// </summary>
    /// <value>External order comment. Will typically be the order comment from e-commerce checkout.</value>
    [DataMember(Name="external_comment", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "external_comment")]
    public string ExternalComment { get; set; }

    /// <summary>
    /// Any error message that resulted from the latest attempt at making a shipment from the order.
    /// </summary>
    /// <value>Any error message that resulted from the latest attempt at making a shipment from the order.</value>
    [DataMember(Name="error_message", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "error_message")]
    public Object ErrorMessage { get; set; }

    /// <summary>
    /// The order slip in PDF format using base64 encoding. This will only be included if the parameter fields[orders] includes slip.
    /// </summary>
    /// <value>The order slip in PDF format using base64 encoding. This will only be included if the parameter fields[orders] includes slip.</value>
    [DataMember(Name="slip", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "slip")]
    public string Slip { get; set; }

    /// <summary>
    /// Gets or Sets Base64
    /// </summary>
    [DataMember(Name="base64", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "base64")]
    public string Base64 { get; set; }

    /// <summary>
    /// The time when resource was last updated or when it was created if it was never updated
    /// </summary>
    /// <value>The time when resource was last updated or when it was created if it was never updated</value>
    [DataMember(Name="updated_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "updated_at")]
    public string UpdatedAt { get; set; }

    /// <summary>
    /// The time when the resource was created
    /// </summary>
    /// <value>The time when the resource was created</value>
    [DataMember(Name="created_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "created_at")]
    public string CreatedAt { get; set; }

    /// <summary>
    /// When an order is locked, it cannot be modified or sent until it is unlocked. Possible values: <code>locked</code> or <code>unlocked</code>.
    /// </summary>
    /// <value>When an order is locked, it cannot be modified or sent until it is unlocked. Possible values: <code>locked</code> or <code>unlocked</code>.</value>
    [DataMember(Name="lock_state", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lock_state")]
    public string LockState { get; set; }

    /// <summary>
    /// A description of how the order was created in Webshipper. Possible values: 'api', 'manual' or 'csv'
    /// </summary>
    /// <value>A description of how the order was created in Webshipper. Possible values: 'api', 'manual' or 'csv'</value>
    [DataMember(Name="source", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "source")]
    public string Source { get; set; }

    /// <summary>
    /// Array of strings used to tag an order
    /// </summary>
    /// <value>Array of strings used to tag an order</value>
    [DataMember(Name="tags", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tags")]
    public List<string> Tags { get; set; }

    /// <summary>
    /// A string like 'address' or 'carrier_downtime' describe which type of error caused the order to fail
    /// </summary>
    /// <value>A string like 'address' or 'carrier_downtime' describe which type of error caused the order to fail</value>
    [DataMember(Name="error_class", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "error_class")]
    public string ErrorClass { get; set; }

    /// <summary>
    /// Gets or Sets SlipPrinted
    /// </summary>
    [DataMember(Name="slip_printed", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "slip_printed")]
    public bool? SlipPrinted { get; set; }

    /// <summary>
    /// Gets or Sets LabelPrinted
    /// </summary>
    [DataMember(Name="label_printed", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "label_printed")]
    public bool? LabelPrinted { get; set; }

    /// <summary>
    /// Gets or Sets CreateShipmentAutomatically
    /// </summary>
    [DataMember(Name="create_shipment_automatically", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "create_shipment_automatically")]
    public string CreateShipmentAutomatically { get; set; }

    /// <summary>
    /// Gets or Sets LatestStatusEvent
    /// </summary>
    [DataMember(Name="latest_status_event", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "latest_status_event")]
    public string LatestStatusEvent { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Orders {\n");
      sb.Append("  OrderChannelId: ").Append(OrderChannelId).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  ExtRef: ").Append(ExtRef).Append("\n");
      sb.Append("  VisibleRef: ").Append(VisibleRef).Append("\n");
      sb.Append("  DropPoint: ").Append(DropPoint).Append("\n");
      sb.Append("  OriginalShipping: ").Append(OriginalShipping).Append("\n");
      sb.Append("  OrderLines: ").Append(OrderLines).Append("\n");
      sb.Append("  DeliveryAddress: ").Append(DeliveryAddress).Append("\n");
      sb.Append("  SenderAddress: ").Append(SenderAddress).Append("\n");
      sb.Append("  BillingAddress: ").Append(BillingAddress).Append("\n");
      sb.Append("  SoldFromAddress: ").Append(SoldFromAddress).Append("\n");
      sb.Append("  Currency: ").Append(Currency).Append("\n");
      sb.Append("  InternalComment: ").Append(InternalComment).Append("\n");
      sb.Append("  ExternalComment: ").Append(ExternalComment).Append("\n");
      sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append("\n");
      sb.Append("  Slip: ").Append(Slip).Append("\n");
      sb.Append("  Base64: ").Append(Base64).Append("\n");
      sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
      sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
      sb.Append("  LockState: ").Append(LockState).Append("\n");
      sb.Append("  Source: ").Append(Source).Append("\n");
      sb.Append("  Tags: ").Append(Tags).Append("\n");
      sb.Append("  ErrorClass: ").Append(ErrorClass).Append("\n");
      sb.Append("  SlipPrinted: ").Append(SlipPrinted).Append("\n");
      sb.Append("  LabelPrinted: ").Append(LabelPrinted).Append("\n");
      sb.Append("  CreateShipmentAutomatically: ").Append(CreateShipmentAutomatically).Append("\n");
      sb.Append("  LatestStatusEvent: ").Append(LatestStatusEvent).Append("\n");
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
