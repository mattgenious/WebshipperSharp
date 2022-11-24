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
  public class ReportTypes {
    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Array of objects with keys <code>header</code> and <code>content</code>
    /// </summary>
    /// <value>Array of objects with keys <code>header</code> and <code>content</code></value>
    [DataMember(Name="columns", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "columns")]
    public List<string> Columns { get; set; }

    /// <summary>
    /// Array of objects with keys <code>parameter_key</code> and <code>parameter_value</code>
    /// </summary>
    /// <value>Array of objects with keys <code>parameter_key</code> and <code>parameter_value</code></value>
    [DataMember(Name="parameters", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "parameters")]
    public List<string> Parameters { get; set; }

    /// <summary>
    /// Gets or Sets Resource
    /// </summary>
    [DataMember(Name="resource", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "resource")]
    public string Resource { get; set; }

    /// <summary>
    /// Array of objects with keys <code>header</code> and <code>content</code> that will be used to display the header content of the report
    /// </summary>
    /// <value>Array of objects with keys <code>header</code> and <code>content</code> that will be used to display the header content of the report</value>
    [DataMember(Name="header_columns", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "header_columns")]
    public List<string> HeaderColumns { get; set; }

    /// <summary>
    /// Gets or Sets FooterContent
    /// </summary>
    [DataMember(Name="footer_content", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "footer_content")]
    public string FooterContent { get; set; }

    /// <summary>
    /// Array of objects describing how to load the resources. Contains keys <code>condition_key</code>, <code>condition_operator</code>, <code>condition_value</code>.
    /// </summary>
    /// <value>Array of objects describing how to load the resources. Contains keys <code>condition_key</code>, <code>condition_operator</code>, <code>condition_value</code>.</value>
    [DataMember(Name="conditions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "conditions")]
    public List<string> Conditions { get; set; }

    /// <summary>
    /// If true the report will included deleted records. Default: <code>false</code>
    /// </summary>
    /// <value>If true the report will included deleted records. Default: <code>false</code></value>
    [DataMember(Name="include_deleted", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "include_deleted")]
    public bool? IncludeDeleted { get; set; }

    /// <summary>
    /// When set to true it will attempt to fetch the end of day list directly from the carrier. When this option is enabled, only pdf reports are available.
    /// </summary>
    /// <value>When set to true it will attempt to fetch the end of day list directly from the carrier. When this option is enabled, only pdf reports are available.</value>
    [DataMember(Name="use_carrier_eod", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "use_carrier_eod")]
    public bool? UseCarrierEod { get; set; }

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
    /// Gets or Sets Schedule
    /// </summary>
    [DataMember(Name="schedule", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "schedule")]
    public string Schedule { get; set; }

    /// <summary>
    /// Gets or Sets DefaultFormat
    /// </summary>
    [DataMember(Name="default_format", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "default_format")]
    public string DefaultFormat { get; set; }

    /// <summary>
    /// Gets or Sets MailOnRun
    /// </summary>
    [DataMember(Name="mail_on_run", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "mail_on_run")]
    public bool? MailOnRun { get; set; }

    /// <summary>
    /// Gets or Sets Mail
    /// </summary>
    [DataMember(Name="mail", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "mail")]
    public string Mail { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ReportTypes {\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Columns: ").Append(Columns).Append("\n");
      sb.Append("  Parameters: ").Append(Parameters).Append("\n");
      sb.Append("  Resource: ").Append(Resource).Append("\n");
      sb.Append("  HeaderColumns: ").Append(HeaderColumns).Append("\n");
      sb.Append("  FooterContent: ").Append(FooterContent).Append("\n");
      sb.Append("  Conditions: ").Append(Conditions).Append("\n");
      sb.Append("  IncludeDeleted: ").Append(IncludeDeleted).Append("\n");
      sb.Append("  UseCarrierEod: ").Append(UseCarrierEod).Append("\n");
      sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
      sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
      sb.Append("  Schedule: ").Append(Schedule).Append("\n");
      sb.Append("  DefaultFormat: ").Append(DefaultFormat).Append("\n");
      sb.Append("  MailOnRun: ").Append(MailOnRun).Append("\n");
      sb.Append("  Mail: ").Append(Mail).Append("\n");
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
