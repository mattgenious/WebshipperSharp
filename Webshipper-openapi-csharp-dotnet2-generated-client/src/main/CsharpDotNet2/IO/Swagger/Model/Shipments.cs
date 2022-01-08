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
  public class Shipments {
    /// <summary>
    /// The reference you want to identify the shipment form. For example order number.
    /// </summary>
    /// <value>The reference you want to identify the shipment form. For example order number.</value>
    [DataMember(Name="reference", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reference")]
    public string Reference { get; set; }

    /// <summary>
    /// An optional comment for the carrier
    /// </summary>
    /// <value>An optional comment for the carrier</value>
    [DataMember(Name="comment", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "comment")]
    public string Comment { get; set; }

    /// <summary>
    /// The carrier's service code. This should only be assigned if you are not using a shipping rate.
    /// </summary>
    /// <value>The carrier's service code. This should only be assigned if you are not using a shipping rate.</value>
    [DataMember(Name="service_code", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "service_code")]
    public string ServiceCode { get; set; }

    /// <summary>
    /// Determines whether the shipment is a return shipment.
    /// </summary>
    /// <value>Determines whether the shipment is a return shipment.</value>
    [DataMember(Name="is_return", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "is_return")]
    public bool? IsReturn { get; set; }

    /// <summary>
    /// Flattened array of packages to be sent. At least one package is mandatory. For structure refer to 'Package' entity
    /// </summary>
    /// <value>Flattened array of packages to be sent. At least one package is mandatory. For structure refer to 'Package' entity</value>
    [DataMember(Name="packages", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "packages")]
    public List<Packages> Packages { get; set; }

    /// <summary>
    /// Flattened Shipping Address representing the delivery address for the shipment. <br><strong>Duplicated from order if order relation given.</strong>.
    /// </summary>
    /// <value>Flattened Shipping Address representing the delivery address for the shipment. <br><strong>Duplicated from order if order relation given.</strong>.</value>
    [DataMember(Name="delivery_address", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "delivery_address")]
    public Object DeliveryAddress { get; set; }

    /// <summary>
    /// Flattened Shipping Address representing the sender address of shipment. <br><strong>Duplicated from order if order relation given.</strong>.
    /// </summary>
    /// <value>Flattened Shipping Address representing the sender address of shipment. <br><strong>Duplicated from order if order relation given.</strong>.</value>
    [DataMember(Name="sender_address", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sender_address")]
    public Object SenderAddress { get; set; }

    /// <summary>
    /// Flattened Shipping Address representing the billing address of shipment. Duplicated from delivery address if empty. <br><strong>Duplicated from order if order relation given.</strong>.
    /// </summary>
    /// <value>Flattened Shipping Address representing the billing address of shipment. Duplicated from delivery address if empty. <br><strong>Duplicated from order if order relation given.</strong>.</value>
    [DataMember(Name="billing_address", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "billing_address")]
    public Object BillingAddress { get; set; }

    /// <summary>
    /// Flattened Shipping Address representing the pickup address of shipment. Is necessary for some carriers. This is duplicated from sender address if empty. <br><strong>Duplicated from order if order relation given.</strong>.
    /// </summary>
    /// <value>Flattened Shipping Address representing the pickup address of shipment. Is necessary for some carriers. This is duplicated from sender address if empty. <br><strong>Duplicated from order if order relation given.</strong>.</value>
    [DataMember(Name="pickup_address", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pickup_address")]
    public Object PickupAddress { get; set; }

    /// <summary>
    /// Flattened Shipping Address represnting return addres of shipment. Will be duplicated from sender address if empty ( Not used by all carriers ). <br><strong>Duplicated from order if order relation given.</strong>.
    /// </summary>
    /// <value>Flattened Shipping Address represnting return addres of shipment. Will be duplicated from sender address if empty ( Not used by all carriers ). <br><strong>Duplicated from order if order relation given.</strong>.</value>
    [DataMember(Name="return_address", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "return_address")]
    public Object ReturnAddress { get; set; }

    /// <summary>
    /// Array of hashes to assign parameters for any specific carrier service. It is only required if you are <strong>not</strong> using shipping rates and the service has additional required parameters. The hash must have the keys attr_key and attr_value. The type of attr_value should match the attr_type defined by the parameter. To see all possible attributes, please see the list of parameters from the carrier service. <strongShould only be assigned if you are not using a shipping rate</strong>.
    /// </summary>
    /// <value>Array of hashes to assign parameters for any specific carrier service. It is only required if you are <strong>not</strong> using shipping rates and the service has additional required parameters. The hash must have the keys attr_key and attr_value. The type of attr_value should match the attr_type defined by the parameter. To see all possible attributes, please see the list of parameters from the carrier service. <strongShould only be assigned if you are not using a shipping rate</strong>.</value>
    [DataMember(Name="service_attributes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "service_attributes")]
    public List<string> ServiceAttributes { get; set; }

    /// <summary>
    /// Array of add-ons. Add-ons are simply arrays of strings. To see possible add-ons, please refer to the carrier services. <strong>Should only be assigned if you are not using a shipping rate</strong>.
    /// </summary>
    /// <value>Array of add-ons. Add-ons are simply arrays of strings. To see possible add-ons, please refer to the carrier services. <strong>Should only be assigned if you are not using a shipping rate</strong>.</value>
    [DataMember(Name="add_ons", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "add_ons")]
    public List<string> AddOns { get; set; }

    /// <summary>
    /// Must be passed if the carrier should be allowed to send SMS notifications. It should be assigned with a hash including the key phone containing the phone number to be notified. <strong>Should only be assigned if you are not using a shipping rate</strong>.
    /// </summary>
    /// <value>Must be passed if the carrier should be allowed to send SMS notifications. It should be assigned with a hash including the key phone containing the phone number to be notified. <strong>Should only be assigned if you are not using a shipping rate</strong>.</value>
    [DataMember(Name="sms_notification", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sms_notification")]
    public string SmsNotification { get; set; }

    /// <summary>
    /// Must be passed if the carrier should be allowed to send e-mail notifications. It should be assigned with a hash including the key email containing the e-mail address to be notified. <strong>Should only be assigned if you are not using a shipping rate</strong>.
    /// </summary>
    /// <value>Must be passed if the carrier should be allowed to send e-mail notifications. It should be assigned with a hash including the key email containing the e-mail address to be notified. <strong>Should only be assigned if you are not using a shipping rate</strong>.</value>
    [DataMember(Name="email_notification", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "email_notification")]
    public string EmailNotification { get; set; }

    /// <summary>
    /// Flattened array of Document - can be used to upload documents to the shipment which will be sent to the carrier.
    /// </summary>
    /// <value>Flattened array of Document - can be used to upload documents to the shipment which will be sent to the carrier.</value>
    [DataMember(Name="included_documents", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "included_documents")]
    public string IncludedDocuments { get; set; }

    /// <summary>
    /// Flattened Drop Point - should only be assigned if you are sending to a drop point.
    /// </summary>
    /// <value>Flattened Drop Point - should only be assigned if you are sending to a drop point.</value>
    [DataMember(Name="drop_point", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "drop_point")]
    public string DropPoint { get; set; }

    /// <summary>
    /// An array of objects with the keys:       <ul>         <li><code>url</code>: The full URL to the tracking page.</li>         <li><code>number</code>: The tracking identifier.</li>         <li><code>latest_transit_event</code>: The latest tracking/transit event. Same options as Tracking Event statuses.</li>         <li><code>tracking_events</code>: Array of objects. Object has same attributes as the Tracking Event resource</li>       </ul>       
    /// </summary>
    /// <value>An array of objects with the keys:       <ul>         <li><code>url</code>: The full URL to the tracking page.</li>         <li><code>number</code>: The tracking identifier.</li>         <li><code>latest_transit_event</code>: The latest tracking/transit event. Same options as Tracking Event statuses.</li>         <li><code>tracking_events</code>: Array of objects. Object has same attributes as the Tracking Event resource</li>       </ul>       </value>
    [DataMember(Name="tracking_links", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tracking_links")]
    public List<ShipmentsTrackingLinks> TrackingLinks { get; set; }

    /// <summary>
    /// Deprecated
    /// </summary>
    /// <value>Deprecated</value>
    [DataMember(Name="fulfill_immediately", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fulfill_immediately")]
    public string FulfillImmediately { get; set; }

    /// <summary>
    /// Gets or Sets TestMode
    /// </summary>
    [DataMember(Name="test_mode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "test_mode")]
    public bool? TestMode { get; set; }

    /// <summary>
    /// Gets or Sets Dutiable
    /// </summary>
    [DataMember(Name="dutiable", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dutiable")]
    public bool? Dutiable { get; set; }

    /// <summary>
    /// The time when the resource was created
    /// </summary>
    /// <value>The time when the resource was created</value>
    [DataMember(Name="created_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "created_at")]
    public string CreatedAt { get; set; }

    /// <summary>
    /// The external (carrier) reference
    /// </summary>
    /// <value>The external (carrier) reference</value>
    [DataMember(Name="ext_ref", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ext_ref")]
    public string ExtRef { get; set; }

    /// <summary>
    /// Gets or Sets OriginalShipmentId
    /// </summary>
    [DataMember(Name="original_shipment_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "original_shipment_id")]
    public int? OriginalShipmentId { get; set; }

    /// <summary>
    /// Gets or Sets SendTime
    /// </summary>
    [DataMember(Name="send_time", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "send_time")]
    public string SendTime { get; set; }

    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public int? Status { get; set; }

    /// <summary>
    /// Gets or Sets LatestUpdateTime
    /// </summary>
    [DataMember(Name="latest_update_time", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "latest_update_time")]
    public string LatestUpdateTime { get; set; }

    /// <summary>
    /// Gets or Sets SupportsUpdates
    /// </summary>
    [DataMember(Name="supports_updates", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "supports_updates")]
    public string SupportsUpdates { get; set; }

    /// <summary>
    /// Flattened hash with optional key/value pairs.
    /// </summary>
    /// <value>Flattened hash with optional key/value pairs.</value>
    [DataMember(Name="additional_attributes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "additional_attributes")]
    public string AdditionalAttributes { get; set; }

    /// <summary>
    /// The cost price of the shipment, either directly from the carrier or from a cost sheet
    /// </summary>
    /// <value>The cost price of the shipment, either directly from the carrier or from a cost sheet</value>
    [DataMember(Name="cost_price", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cost_price")]
    public decimal? CostPrice { get; set; }

    /// <summary>
    /// The price presented to the customer in checkout
    /// </summary>
    /// <value>The price presented to the customer in checkout</value>
    [DataMember(Name="sales_price", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sales_price")]
    public decimal? SalesPrice { get; set; }

    /// <summary>
    /// Gets or Sets Currency
    /// </summary>
    [DataMember(Name="currency", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "currency")]
    public string Currency { get; set; }

    /// <summary>
    /// Gets or Sets ManualOrderShipmentCreation
    /// </summary>
    [DataMember(Name="manual_order_shipment_creation", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "manual_order_shipment_creation")]
    public string ManualOrderShipmentCreation { get; set; }

    /// <summary>
    /// Webshipper defined name of the carrier type
    /// </summary>
    /// <value>Webshipper defined name of the carrier type</value>
    [DataMember(Name="carrier_type_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "carrier_type_name")]
    public string CarrierTypeName { get; set; }

    /// <summary>
    /// Carrier alias set by the user in Webshipper
    /// </summary>
    /// <value>Carrier alias set by the user in Webshipper</value>
    [DataMember(Name="carrier_alias", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "carrier_alias")]
    public string CarrierAlias { get; set; }

    /// <summary>
    /// ID of the carrier
    /// </summary>
    /// <value>ID of the carrier</value>
    [DataMember(Name="carrier_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "carrier_id")]
    public int? CarrierId { get; set; }

    /// <summary>
    /// Gets or Sets InvoiceSettings
    /// </summary>
    [DataMember(Name="invoice_settings", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "invoice_settings")]
    public string InvoiceSettings { get; set; }

    /// <summary>
    /// Gets or Sets LatestStatusEvent
    /// </summary>
    [DataMember(Name="latest_status_event", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "latest_status_event")]
    public string LatestStatusEvent { get; set; }

    /// <summary>
    /// An optional link to the original shipment, when creating a return-shipment
    /// </summary>
    /// <value>An optional link to the original shipment, when creating a return-shipment</value>
    [DataMember(Name="original_shipment", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "original_shipment")]
    public string OriginalShipment { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Shipments {\n");
      sb.Append("  Reference: ").Append(Reference).Append("\n");
      sb.Append("  Comment: ").Append(Comment).Append("\n");
      sb.Append("  ServiceCode: ").Append(ServiceCode).Append("\n");
      sb.Append("  IsReturn: ").Append(IsReturn).Append("\n");
      sb.Append("  Packages: ").Append(Packages).Append("\n");
      sb.Append("  DeliveryAddress: ").Append(DeliveryAddress).Append("\n");
      sb.Append("  SenderAddress: ").Append(SenderAddress).Append("\n");
      sb.Append("  BillingAddress: ").Append(BillingAddress).Append("\n");
      sb.Append("  PickupAddress: ").Append(PickupAddress).Append("\n");
      sb.Append("  ReturnAddress: ").Append(ReturnAddress).Append("\n");
      sb.Append("  ServiceAttributes: ").Append(ServiceAttributes).Append("\n");
      sb.Append("  AddOns: ").Append(AddOns).Append("\n");
      sb.Append("  SmsNotification: ").Append(SmsNotification).Append("\n");
      sb.Append("  EmailNotification: ").Append(EmailNotification).Append("\n");
      sb.Append("  IncludedDocuments: ").Append(IncludedDocuments).Append("\n");
      sb.Append("  DropPoint: ").Append(DropPoint).Append("\n");
      sb.Append("  TrackingLinks: ").Append(TrackingLinks).Append("\n");
      sb.Append("  FulfillImmediately: ").Append(FulfillImmediately).Append("\n");
      sb.Append("  TestMode: ").Append(TestMode).Append("\n");
      sb.Append("  Dutiable: ").Append(Dutiable).Append("\n");
      sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
      sb.Append("  ExtRef: ").Append(ExtRef).Append("\n");
      sb.Append("  OriginalShipmentId: ").Append(OriginalShipmentId).Append("\n");
      sb.Append("  SendTime: ").Append(SendTime).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  LatestUpdateTime: ").Append(LatestUpdateTime).Append("\n");
      sb.Append("  SupportsUpdates: ").Append(SupportsUpdates).Append("\n");
      sb.Append("  AdditionalAttributes: ").Append(AdditionalAttributes).Append("\n");
      sb.Append("  CostPrice: ").Append(CostPrice).Append("\n");
      sb.Append("  SalesPrice: ").Append(SalesPrice).Append("\n");
      sb.Append("  Currency: ").Append(Currency).Append("\n");
      sb.Append("  ManualOrderShipmentCreation: ").Append(ManualOrderShipmentCreation).Append("\n");
      sb.Append("  CarrierTypeName: ").Append(CarrierTypeName).Append("\n");
      sb.Append("  CarrierAlias: ").Append(CarrierAlias).Append("\n");
      sb.Append("  CarrierId: ").Append(CarrierId).Append("\n");
      sb.Append("  InvoiceSettings: ").Append(InvoiceSettings).Append("\n");
      sb.Append("  LatestStatusEvent: ").Append(LatestStatusEvent).Append("\n");
      sb.Append("  OriginalShipment: ").Append(OriginalShipment).Append("\n");
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
