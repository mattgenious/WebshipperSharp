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
  public class ShippingRates {
    /// <summary>
    /// Id of the carrier which the shipping rate belongs to
    /// </summary>
    /// <value>Id of the carrier which the shipping rate belongs to</value>
    [DataMember(Name="carrier_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "carrier_id")]
    public int? CarrierId { get; set; }

    /// <summary>
    /// Id of the order channel which the shipping rate belongs to
    /// </summary>
    /// <value>Id of the order channel which the shipping rate belongs to</value>
    [DataMember(Name="order_channel_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "order_channel_id")]
    public int? OrderChannelId { get; set; }

    /// <summary>
    /// Name to be displayed in the e-commerce system.
    /// </summary>
    /// <value>Name to be displayed in the e-commerce system.</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// The carrier's service code which must be used when generating parcels with this shipping rate.
    /// </summary>
    /// <value>The carrier's service code which must be used when generating parcels with this shipping rate.</value>
    [DataMember(Name="carrier_service_code", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "carrier_service_code")]
    public string CarrierServiceCode { get; set; }

    /// <summary>
    /// Determines if the shipping rate requires a drop point to be assigned.
    /// </summary>
    /// <value>Determines if the shipping rate requires a drop point to be assigned.</value>
    [DataMember(Name="require_drop_point", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "require_drop_point")]
    public bool? RequireDropPoint { get; set; }

    /// <summary>
    /// Enum - determines whether the rate is returned for all customers, private_customers or business customers. This must be one of the following values:  <code>any</code>, <code>privat_customers</code>, <code>business_customers</code>
    /// </summary>
    /// <value>Enum - determines whether the rate is returned for all customers, private_customers or business customers. This must be one of the following values:  <code>any</code>, <code>privat_customers</code>, <code>business_customers</code></value>
    [DataMember(Name="visible_for", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "visible_for")]
    public int? VisibleFor { get; set; }

    /// <summary>
    /// Array of flattened resources of type <code>Service Attribute</code>. Depends on the carrier service's requirements. Service Attribute has the following attributes:  <code>attr_key</code>, <code>attr_value</code>. You may use the Webshipper Template Language (WTL) for the values.
    /// </summary>
    /// <value>Array of flattened resources of type <code>Service Attribute</code>. Depends on the carrier service's requirements. Service Attribute has the following attributes:  <code>attr_key</code>, <code>attr_value</code>. You may use the Webshipper Template Language (WTL) for the values.</value>
    [DataMember(Name="service_attributes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "service_attributes")]
    public string ServiceAttributes { get; set; }

    /// <summary>
    /// Predefined dimensions which are a assigned when using the shipping rate. Attributes are: <code>height</code>,<code>width</code> and <code>length</code>. The Webshipper Template Language (WTL) may be used for the values.
    /// </summary>
    /// <value>Predefined dimensions which are a assigned when using the shipping rate. Attributes are: <code>height</code>,<code>width</code> and <code>length</code>. The Webshipper Template Language (WTL) may be used for the values.</value>
    [DataMember(Name="dimensions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dimensions")]
    public string Dimensions { get; set; }

    /// <summary>
    /// Array of add_ons supported by the carrier service.
    /// </summary>
    /// <value>Array of add_ons supported by the carrier service.</value>
    [DataMember(Name="add_ons", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "add_ons")]
    public string AddOns { get; set; }

    /// <summary>
    /// Defines whether the rate is a return (inbound) rate or a standard rate (outbound). Please be aware that this attribute must match the carrier's service type.
    /// </summary>
    /// <value>Defines whether the rate is a return (inbound) rate or a standard rate (outbound). Please be aware that this attribute must match the carrier's service type.</value>
    [DataMember(Name="is_return", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "is_return")]
    public bool? IsReturn { get; set; }

    /// <summary>
    /// When this is set to true, the shipping rate will enable e-mail notifications from the carrier.
    /// </summary>
    /// <value>When this is set to true, the shipping rate will enable e-mail notifications from the carrier.</value>
    [DataMember(Name="carriers_email", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "carriers_email")]
    public bool? CarriersEmail { get; set; }

    /// <summary>
    /// Defines what content is included in the comment field. The Webshipper Template Language (WTL) may be used in this field. For example:  {{order.external_comment}}
    /// </summary>
    /// <value>Defines what content is included in the comment field. The Webshipper Template Language (WTL) may be used in this field. For example:  {{order.external_comment}}</value>
    [DataMember(Name="comment_map", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "comment_map")]
    public string CommentMap { get; set; }

    /// <summary>
    /// Defines what content is included in the reference field. The Webshipper Template Language (WTL) may be used in this field. For example: {{order.visible_ref}}
    /// </summary>
    /// <value>Defines what content is included in the reference field. The Webshipper Template Language (WTL) may be used in this field. For example: {{order.visible_ref}}</value>
    [DataMember(Name="reference_map", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reference_map")]
    public string ReferenceMap { get; set; }

    /// <summary>
    /// When this is set to true, the shipping rate will enable SMS notifications from the carrier.
    /// </summary>
    /// <value>When this is set to true, the shipping rate will enable SMS notifications from the carrier.</value>
    [DataMember(Name="carriers_sms", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "carriers_sms")]
    public bool? CarriersSms { get; set; }

    /// <summary>
    /// Defines whether the goods sent using this shipping rate are dutiable.
    /// </summary>
    /// <value>Defines whether the goods sent using this shipping rate are dutiable.</value>
    [DataMember(Name="dutiable", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dutiable")]
    public bool? Dutiable { get; set; }

    /// <summary>
    /// Attribute to indicate if the shipping rate is visible to order channels
    /// </summary>
    /// <value>Attribute to indicate if the shipping rate is visible to order channels</value>
    [DataMember(Name="is_hidden", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "is_hidden")]
    public bool? IsHidden { get; set; }

    /// <summary>
    /// Gets or Sets ClickCollect
    /// </summary>
    [DataMember(Name="click_collect", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "click_collect")]
    public bool? ClickCollect { get; set; }

    /// <summary>
    /// Gets or Sets Reference
    /// </summary>
    [DataMember(Name="reference", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reference")]
    public string Reference { get; set; }

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
    /// Predefined colli type to be used when using the shipping rate. Must be supported by the carrier.
    /// </summary>
    /// <value>Predefined colli type to be used when using the shipping rate. Must be supported by the carrier.</value>
    [DataMember(Name="default_colli_type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "default_colli_type")]
    public string DefaultColliType { get; set; }

    /// <summary>
    /// Gets or Sets SenderAddressId
    /// </summary>
    [DataMember(Name="sender_address_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sender_address_id")]
    public int? SenderAddressId { get; set; }

    /// <summary>
    /// Gets or Sets ReturnAddressId
    /// </summary>
    [DataMember(Name="return_address_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "return_address_id")]
    public int? ReturnAddressId { get; set; }

    /// <summary>
    /// Gets or Sets InvoiceSettings
    /// </summary>
    [DataMember(Name="invoice_settings", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "invoice_settings")]
    public string InvoiceSettings { get; set; }

    /// <summary>
    /// Flattended array of Regions. See section on Shipping Regions and Expressions for more details
    /// </summary>
    /// <value>Flattended array of Regions. See section on Shipping Regions and Expressions for more details</value>
    [DataMember(Name="regions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "regions")]
    public string Regions { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ShippingRates {\n");
      sb.Append("  CarrierId: ").Append(CarrierId).Append("\n");
      sb.Append("  OrderChannelId: ").Append(OrderChannelId).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  CarrierServiceCode: ").Append(CarrierServiceCode).Append("\n");
      sb.Append("  RequireDropPoint: ").Append(RequireDropPoint).Append("\n");
      sb.Append("  VisibleFor: ").Append(VisibleFor).Append("\n");
      sb.Append("  ServiceAttributes: ").Append(ServiceAttributes).Append("\n");
      sb.Append("  Dimensions: ").Append(Dimensions).Append("\n");
      sb.Append("  AddOns: ").Append(AddOns).Append("\n");
      sb.Append("  IsReturn: ").Append(IsReturn).Append("\n");
      sb.Append("  CarriersEmail: ").Append(CarriersEmail).Append("\n");
      sb.Append("  CommentMap: ").Append(CommentMap).Append("\n");
      sb.Append("  ReferenceMap: ").Append(ReferenceMap).Append("\n");
      sb.Append("  CarriersSms: ").Append(CarriersSms).Append("\n");
      sb.Append("  Dutiable: ").Append(Dutiable).Append("\n");
      sb.Append("  IsHidden: ").Append(IsHidden).Append("\n");
      sb.Append("  ClickCollect: ").Append(ClickCollect).Append("\n");
      sb.Append("  Reference: ").Append(Reference).Append("\n");
      sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
      sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
      sb.Append("  DefaultColliType: ").Append(DefaultColliType).Append("\n");
      sb.Append("  SenderAddressId: ").Append(SenderAddressId).Append("\n");
      sb.Append("  ReturnAddressId: ").Append(ReturnAddressId).Append("\n");
      sb.Append("  InvoiceSettings: ").Append(InvoiceSettings).Append("\n");
      sb.Append("  Regions: ").Append(Regions).Append("\n");
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
