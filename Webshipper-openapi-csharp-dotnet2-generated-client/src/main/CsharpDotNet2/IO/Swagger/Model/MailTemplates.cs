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
  public class MailTemplates {
    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets DefaultLocale
    /// </summary>
    [DataMember(Name="default_locale", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "default_locale")]
    public string DefaultLocale { get; set; }

    /// <summary>
    /// Gets or Sets MailLocales
    /// </summary>
    [DataMember(Name="mail_locales", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "mail_locales")]
    public string MailLocales { get; set; }

    /// <summary>
    /// Gets or Sets Images
    /// </summary>
    [DataMember(Name="images", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "images")]
    public string Images { get; set; }

    /// <summary>
    /// Gets or Sets Purpose
    /// </summary>
    [DataMember(Name="purpose", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "purpose")]
    public int? Purpose { get; set; }

    /// <summary>
    /// Gets or Sets BccMail
    /// </summary>
    [DataMember(Name="bcc_mail", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bcc_mail")]
    public string BccMail { get; set; }

    /// <summary>
    /// Gets or Sets IsPrebuilt
    /// </summary>
    [DataMember(Name="is_prebuilt", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "is_prebuilt")]
    public bool? IsPrebuilt { get; set; }

    /// <summary>
    /// Gets or Sets Overrides
    /// </summary>
    [DataMember(Name="overrides", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "overrides")]
    public string Overrides { get; set; }

    /// <summary>
    /// Gets or Sets Defaults
    /// </summary>
    [DataMember(Name="defaults", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "defaults")]
    public string Defaults { get; set; }

    /// <summary>
    /// Gets or Sets Hook
    /// </summary>
    [DataMember(Name="hook", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hook")]
    public string Hook { get; set; }

    /// <summary>
    /// Encapsulated with new WYSIWYG editor and legacy HTML based templates
    /// </summary>
    /// <value>Encapsulated with new WYSIWYG editor and legacy HTML based templates</value>
    [DataMember(Name="described", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "described")]
    public string Described { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class MailTemplates {\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  DefaultLocale: ").Append(DefaultLocale).Append("\n");
      sb.Append("  MailLocales: ").Append(MailLocales).Append("\n");
      sb.Append("  Images: ").Append(Images).Append("\n");
      sb.Append("  Purpose: ").Append(Purpose).Append("\n");
      sb.Append("  BccMail: ").Append(BccMail).Append("\n");
      sb.Append("  IsPrebuilt: ").Append(IsPrebuilt).Append("\n");
      sb.Append("  Overrides: ").Append(Overrides).Append("\n");
      sb.Append("  Defaults: ").Append(Defaults).Append("\n");
      sb.Append("  Hook: ").Append(Hook).Append("\n");
      sb.Append("  Described: ").Append(Described).Append("\n");
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
