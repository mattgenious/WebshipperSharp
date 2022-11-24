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
  public class CarrierTypes {
    /// <summary>
    /// Logo for the carrier
    /// </summary>
    /// <value>Logo for the carrier</value>
    [DataMember(Name="fulfillment_logo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fulfillment_logo")]
    public string FulfillmentLogo { get; set; }

    /// <summary>
    /// Logo for the carrier
    /// </summary>
    /// <value>Logo for the carrier</value>
    [DataMember(Name="list_logo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "list_logo")]
    public string ListLogo { get; set; }

    /// <summary>
    /// Name of the carrier
    /// </summary>
    /// <value>Name of the carrier</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Code identifying the carrier
    /// </summary>
    /// <value>Code identifying the carrier</value>
    [DataMember(Name="carrier_code", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "carrier_code")]
    public string CarrierCode { get; set; }

    /// <summary>
    /// Description of the carrier
    /// </summary>
    /// <value>Description of the carrier</value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// Details required to use the carrier
    /// </summary>
    /// <value>Details required to use the carrier</value>
    [DataMember(Name="required_details", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "required_details")]
    public string RequiredDetails { get; set; }

    /// <summary>
    /// Gets or Sets RequiresDutiable
    /// </summary>
    [DataMember(Name="requires_dutiable", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "requires_dutiable")]
    public bool? RequiresDutiable { get; set; }

    /// <summary>
    /// Gets or Sets SupportsZpl
    /// </summary>
    [DataMember(Name="supports_zpl", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "supports_zpl")]
    public bool? SupportsZpl { get; set; }

    /// <summary>
    /// Gets or Sets SupportsPickup
    /// </summary>
    [DataMember(Name="supports_pickup", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "supports_pickup")]
    public string SupportsPickup { get; set; }

    /// <summary>
    /// Gets or Sets SupportsTracking
    /// </summary>
    [DataMember(Name="supports_tracking", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "supports_tracking")]
    public string SupportsTracking { get; set; }

    /// <summary>
    /// Gets or Sets SupportsPriceQuoting
    /// </summary>
    [DataMember(Name="supports_price_quoting", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "supports_price_quoting")]
    public bool? SupportsPriceQuoting { get; set; }

    /// <summary>
    /// Gets or Sets RequiresApproval
    /// </summary>
    [DataMember(Name="requires_approval", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "requires_approval")]
    public bool? RequiresApproval { get; set; }

    /// <summary>
    /// Gets or Sets SupportsDocuments
    /// </summary>
    [DataMember(Name="supports_documents", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "supports_documents")]
    public bool? SupportsDocuments { get; set; }

    /// <summary>
    /// Boolean indicating wether the carrier supports shipment updates
    /// </summary>
    /// <value>Boolean indicating wether the carrier supports shipment updates</value>
    [DataMember(Name="supports_shipment_updates", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "supports_shipment_updates")]
    public bool? SupportsShipmentUpdates { get; set; }

    /// <summary>
    /// Number of minutes before shipment time a shipment can be updated
    /// </summary>
    /// <value>Number of minutes before shipment time a shipment can be updated</value>
    [DataMember(Name="shipment_updates_limit_minutes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "shipment_updates_limit_minutes")]
    public int? ShipmentUpdatesLimitMinutes { get; set; }

    /// <summary>
    /// Gets or Sets BarcodeMail
    /// </summary>
    [DataMember(Name="barcode_mail", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "barcode_mail")]
    public string BarcodeMail { get; set; }

    /// <summary>
    /// Gets or Sets SupportsPricePdfUpload
    /// </summary>
    [DataMember(Name="supports_price_pdf_upload", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "supports_price_pdf_upload")]
    public string SupportsPricePdfUpload { get; set; }

    /// <summary>
    /// Gets or Sets SupportsDeletion
    /// </summary>
    [DataMember(Name="supports_deletion", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "supports_deletion")]
    public string SupportsDeletion { get; set; }

    /// <summary>
    /// Gets or Sets BarcodeCustomerNotificationMailTemplateId
    /// </summary>
    [DataMember(Name="barcode_customer_notification_mail_template_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "barcode_customer_notification_mail_template_id")]
    public int? BarcodeCustomerNotificationMailTemplateId { get; set; }

    /// <summary>
    /// Determines whether the carrier supports colli types.Values should be one of the following. null: Not supported, \"carrier_provided\": Values are determined by the carrier, \"webshipper_provided\": Default Webshipper colli types, \"customer_provided\": The customer can input colli types specific to their aggreement with the carrier.
    /// </summary>
    /// <value>Determines whether the carrier supports colli types.Values should be one of the following. null: Not supported, \"carrier_provided\": Values are determined by the carrier, \"webshipper_provided\": Default Webshipper colli types, \"customer_provided\": The customer can input colli types specific to their aggreement with the carrier.</value>
    [DataMember(Name="colli_type_support", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "colli_type_support")]
    public int? ColliTypeSupport { get; set; }

    /// <summary>
    /// Gets or Sets Beta
    /// </summary>
    [DataMember(Name="beta", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "beta")]
    public bool? Beta { get; set; }

    /// <summary>
    /// Gets or Sets SupportsTestMode
    /// </summary>
    [DataMember(Name="supports_test_mode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "supports_test_mode")]
    public bool? SupportsTestMode { get; set; }

    /// <summary>
    /// Gets or Sets ShowSendTime
    /// </summary>
    [DataMember(Name="show_send_time", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "show_send_time")]
    public bool? ShowSendTime { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CarrierTypes {\n");
      sb.Append("  FulfillmentLogo: ").Append(FulfillmentLogo).Append("\n");
      sb.Append("  ListLogo: ").Append(ListLogo).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  CarrierCode: ").Append(CarrierCode).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  RequiredDetails: ").Append(RequiredDetails).Append("\n");
      sb.Append("  RequiresDutiable: ").Append(RequiresDutiable).Append("\n");
      sb.Append("  SupportsZpl: ").Append(SupportsZpl).Append("\n");
      sb.Append("  SupportsPickup: ").Append(SupportsPickup).Append("\n");
      sb.Append("  SupportsTracking: ").Append(SupportsTracking).Append("\n");
      sb.Append("  SupportsPriceQuoting: ").Append(SupportsPriceQuoting).Append("\n");
      sb.Append("  RequiresApproval: ").Append(RequiresApproval).Append("\n");
      sb.Append("  SupportsDocuments: ").Append(SupportsDocuments).Append("\n");
      sb.Append("  SupportsShipmentUpdates: ").Append(SupportsShipmentUpdates).Append("\n");
      sb.Append("  ShipmentUpdatesLimitMinutes: ").Append(ShipmentUpdatesLimitMinutes).Append("\n");
      sb.Append("  BarcodeMail: ").Append(BarcodeMail).Append("\n");
      sb.Append("  SupportsPricePdfUpload: ").Append(SupportsPricePdfUpload).Append("\n");
      sb.Append("  SupportsDeletion: ").Append(SupportsDeletion).Append("\n");
      sb.Append("  BarcodeCustomerNotificationMailTemplateId: ").Append(BarcodeCustomerNotificationMailTemplateId).Append("\n");
      sb.Append("  ColliTypeSupport: ").Append(ColliTypeSupport).Append("\n");
      sb.Append("  Beta: ").Append(Beta).Append("\n");
      sb.Append("  SupportsTestMode: ").Append(SupportsTestMode).Append("\n");
      sb.Append("  ShowSendTime: ").Append(ShowSendTime).Append("\n");
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
