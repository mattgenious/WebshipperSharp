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
  public class ErrorTypes {
    /// <summary>
    /// Gets or Sets Translations
    /// </summary>
    [DataMember(Name="translations", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "translations")]
    public string Translations { get; set; }

    /// <summary>
    /// Gets or Sets Matcher
    /// </summary>
    [DataMember(Name="matcher", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "matcher")]
    public string Matcher { get; set; }

    /// <summary>
    /// Gets or Sets ErrorClass
    /// </summary>
    [DataMember(Name="error_class", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "error_class")]
    public string ErrorClass { get; set; }

    /// <summary>
    /// Gets or Sets SupportUrl
    /// </summary>
    [DataMember(Name="support_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "support_url")]
    public string SupportUrl { get; set; }

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
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ErrorTypes {\n");
      sb.Append("  Translations: ").Append(Translations).Append("\n");
      sb.Append("  Matcher: ").Append(Matcher).Append("\n");
      sb.Append("  ErrorClass: ").Append(ErrorClass).Append("\n");
      sb.Append("  SupportUrl: ").Append(SupportUrl).Append("\n");
      sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
      sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
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
