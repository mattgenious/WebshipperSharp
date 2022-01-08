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
  public class OrderChannelTypes {
    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets SupportUrl
    /// </summary>
    [DataMember(Name="support_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "support_url")]
    public string SupportUrl { get; set; }

    /// <summary>
    /// Gets or Sets PublicGlobalAttrs
    /// </summary>
    [DataMember(Name="public_global_attrs", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "public_global_attrs")]
    public string PublicGlobalAttrs { get; set; }

    /// <summary>
    /// Gets or Sets ListLogo
    /// </summary>
    [DataMember(Name="list_logo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "list_logo")]
    public string ListLogo { get; set; }

    /// <summary>
    /// Gets or Sets Description
    /// </summary>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// Gets or Sets ModuleLink
    /// </summary>
    [DataMember(Name="module_link", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "module_link")]
    public string ModuleLink { get; set; }

    /// <summary>
    /// Gets or Sets CanAutofulfill
    /// </summary>
    [DataMember(Name="can_autofulfill", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "can_autofulfill")]
    public bool? CanAutofulfill { get; set; }

    /// <summary>
    /// Gets or Sets CanLimitDropPoints
    /// </summary>
    [DataMember(Name="can_limit_drop_points", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "can_limit_drop_points")]
    public bool? CanLimitDropPoints { get; set; }

    /// <summary>
    /// Gets or Sets SupportsRateQuoting
    /// </summary>
    [DataMember(Name="supports_rate_quoting", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "supports_rate_quoting")]
    public bool? SupportsRateQuoting { get; set; }

    /// <summary>
    /// Gets or Sets UsesScheduledImport
    /// </summary>
    [DataMember(Name="uses_scheduled_import", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "uses_scheduled_import")]
    public bool? UsesScheduledImport { get; set; }

    /// <summary>
    /// Gets or Sets SupportsTimeIntervalImport
    /// </summary>
    [DataMember(Name="supports_time_interval_import", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "supports_time_interval_import")]
    public bool? SupportsTimeIntervalImport { get; set; }

    /// <summary>
    /// Gets or Sets SupportsStatusesImport
    /// </summary>
    [DataMember(Name="supports_statuses_import", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "supports_statuses_import")]
    public bool? SupportsStatusesImport { get; set; }

    /// <summary>
    /// Gets or Sets SupportsIdImport
    /// </summary>
    [DataMember(Name="supports_id_import", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "supports_id_import")]
    public bool? SupportsIdImport { get; set; }

    /// <summary>
    /// Gets or Sets SupportsVatInCheckout
    /// </summary>
    [DataMember(Name="supports_vat_in_checkout", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "supports_vat_in_checkout")]
    public bool? SupportsVatInCheckout { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class OrderChannelTypes {\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  SupportUrl: ").Append(SupportUrl).Append("\n");
      sb.Append("  PublicGlobalAttrs: ").Append(PublicGlobalAttrs).Append("\n");
      sb.Append("  ListLogo: ").Append(ListLogo).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  ModuleLink: ").Append(ModuleLink).Append("\n");
      sb.Append("  CanAutofulfill: ").Append(CanAutofulfill).Append("\n");
      sb.Append("  CanLimitDropPoints: ").Append(CanLimitDropPoints).Append("\n");
      sb.Append("  SupportsRateQuoting: ").Append(SupportsRateQuoting).Append("\n");
      sb.Append("  UsesScheduledImport: ").Append(UsesScheduledImport).Append("\n");
      sb.Append("  SupportsTimeIntervalImport: ").Append(SupportsTimeIntervalImport).Append("\n");
      sb.Append("  SupportsStatusesImport: ").Append(SupportsStatusesImport).Append("\n");
      sb.Append("  SupportsIdImport: ").Append(SupportsIdImport).Append("\n");
      sb.Append("  SupportsVatInCheckout: ").Append(SupportsVatInCheckout).Append("\n");
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
