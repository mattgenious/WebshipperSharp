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
  public class Carriers {
    /// <summary>
    /// Your name for the carrier
    /// </summary>
    /// <value>Your name for the carrier</value>
    [DataMember(Name="alias", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "alias")]
    public string Alias { get; set; }

    /// <summary>
    /// Array of services provided by this Carrier
    /// </summary>
    /// <value>Array of services provided by this Carrier</value>
    [DataMember(Name="services", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "services")]
    public string Services { get; set; }

    /// <summary>
    /// Array of hashes with keys: <code>attr_key</code>, <code>attr_value</code>, <code>attr_name</code>, <code>attr_type</code>, <code>is_required</code>, </code>enums</code>. See       documentation for Local Attributes
    /// </summary>
    /// <value>Array of hashes with keys: <code>attr_key</code>, <code>attr_value</code>, <code>attr_name</code>, <code>attr_type</code>, <code>is_required</code>, </code>enums</code>. See       documentation for Local Attributes</value>
    [DataMember(Name="attrs", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "attrs")]
    public string Attrs { get; set; }

    /// <summary>
    /// Gets or Sets PreferZpl
    /// </summary>
    [DataMember(Name="prefer_zpl", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "prefer_zpl")]
    public bool? PreferZpl { get; set; }

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
    /// Gets or Sets IsApproved
    /// </summary>
    [DataMember(Name="is_approved", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "is_approved")]
    public bool? IsApproved { get; set; }

    /// <summary>
    /// Gets or Sets ApprovedServiceCodes
    /// </summary>
    [DataMember(Name="approved_service_codes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "approved_service_codes")]
    public string ApprovedServiceCodes { get; set; }

    /// <summary>
    /// Gets or Sets ServiceParameterEnums
    /// </summary>
    [DataMember(Name="service_parameter_enums", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "service_parameter_enums")]
    public string ServiceParameterEnums { get; set; }

    /// <summary>
    /// Gets or Sets BarcodeNotificationBehavior
    /// </summary>
    [DataMember(Name="barcode_notification_behavior", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "barcode_notification_behavior")]
    public int? BarcodeNotificationBehavior { get; set; }

    /// <summary>
    /// Gets or Sets BarcodeNotificationMail
    /// </summary>
    [DataMember(Name="barcode_notification_mail", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "barcode_notification_mail")]
    public string BarcodeNotificationMail { get; set; }

    /// <summary>
    /// Gets or Sets HasActiveCostSheet
    /// </summary>
    [DataMember(Name="has_active_cost_sheet", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "has_active_cost_sheet")]
    public string HasActiveCostSheet { get; set; }

    /// <summary>
    /// Gets or Sets DeleteAtCarrier
    /// </summary>
    [DataMember(Name="delete_at_carrier", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "delete_at_carrier")]
    public bool? DeleteAtCarrier { get; set; }

    /// <summary>
    /// Gets or Sets TestMode
    /// </summary>
    [DataMember(Name="test_mode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "test_mode")]
    public bool? TestMode { get; set; }

    /// <summary>
    /// Gets or Sets Logo
    /// </summary>
    [DataMember(Name="logo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "logo")]
    public string Logo { get; set; }

    /// <summary>
    /// Gets or Sets PrintErrorLabel
    /// </summary>
    [DataMember(Name="print_error_label", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "print_error_label")]
    public bool? PrintErrorLabel { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Carriers {\n");
      sb.Append("  Alias: ").Append(Alias).Append("\n");
      sb.Append("  Services: ").Append(Services).Append("\n");
      sb.Append("  Attrs: ").Append(Attrs).Append("\n");
      sb.Append("  PreferZpl: ").Append(PreferZpl).Append("\n");
      sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
      sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
      sb.Append("  IsApproved: ").Append(IsApproved).Append("\n");
      sb.Append("  ApprovedServiceCodes: ").Append(ApprovedServiceCodes).Append("\n");
      sb.Append("  ServiceParameterEnums: ").Append(ServiceParameterEnums).Append("\n");
      sb.Append("  BarcodeNotificationBehavior: ").Append(BarcodeNotificationBehavior).Append("\n");
      sb.Append("  BarcodeNotificationMail: ").Append(BarcodeNotificationMail).Append("\n");
      sb.Append("  HasActiveCostSheet: ").Append(HasActiveCostSheet).Append("\n");
      sb.Append("  DeleteAtCarrier: ").Append(DeleteAtCarrier).Append("\n");
      sb.Append("  TestMode: ").Append(TestMode).Append("\n");
      sb.Append("  Logo: ").Append(Logo).Append("\n");
      sb.Append("  PrintErrorLabel: ").Append(PrintErrorLabel).Append("\n");
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
