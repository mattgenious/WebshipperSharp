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
  public class SlipTemplatePreviews {
    /// <summary>
    /// Gets or Sets SlipTemplate
    /// </summary>
    [DataMember(Name="slip_template", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "slip_template")]
    public string SlipTemplate { get; set; }

    /// <summary>
    /// Gets or Sets OrderVisibleRef
    /// </summary>
    [DataMember(Name="order_visible_ref", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "order_visible_ref")]
    public string OrderVisibleRef { get; set; }

    /// <summary>
    /// Gets or Sets Base64
    /// </summary>
    [DataMember(Name="base64", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "base64")]
    public string Base64 { get; set; }

    /// <summary>
    /// Gets or Sets ExampleId
    /// </summary>
    [DataMember(Name="example_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "example_id")]
    public string ExampleId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SlipTemplatePreviews {\n");
      sb.Append("  SlipTemplate: ").Append(SlipTemplate).Append("\n");
      sb.Append("  OrderVisibleRef: ").Append(OrderVisibleRef).Append("\n");
      sb.Append("  Base64: ").Append(Base64).Append("\n");
      sb.Append("  ExampleId: ").Append(ExampleId).Append("\n");
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
