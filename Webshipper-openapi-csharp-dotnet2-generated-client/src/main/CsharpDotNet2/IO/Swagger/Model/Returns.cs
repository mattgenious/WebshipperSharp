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
  public class Returns {
    /// <summary>
    /// One of pending, sent, arrived, processed, error or approved
    /// </summary>
    /// <value>One of pending, sent, arrived, processed, error or approved</value>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

    /// <summary>
    /// Gets or Sets ErrorMessage
    /// </summary>
    [DataMember(Name="error_message", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "error_message")]
    public string ErrorMessage { get; set; }

    /// <summary>
    /// Array of ReturnLine objects. Contains fields order_line_id, quantity, cause_id, cause_description and images. When creating, images should be an array of data uri containing the base64 encoding of the image, example: <em>data:image/jpeg;base64,AAQSkZJ......RgABAQEAlgCWAAD</em>
    /// </summary>
    /// <value>Array of ReturnLine objects. Contains fields order_line_id, quantity, cause_id, cause_description and images. When creating, images should be an array of data uri containing the base64 encoding of the image, example: <em>data:image/jpeg;base64,AAQSkZJ......RgABAQEAlgCWAAD</em></value>
    [DataMember(Name="return_lines", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "return_lines")]
    public List<string> ReturnLines { get; set; }

    /// <summary>
    /// Base 64 encoding of return slip
    /// </summary>
    /// <value>Base 64 encoding of return slip</value>
    [DataMember(Name="base64", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "base64")]
    public string Base64 { get; set; }

    /// <summary>
    /// Read only token for publicly accessing status of the return order
    /// </summary>
    /// <value>Read only token for publicly accessing status of the return order</value>
    [DataMember(Name="secret", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "secret")]
    public string Secret { get; set; }

    /// <summary>
    /// Gets or Sets InternalComment
    /// </summary>
    [DataMember(Name="internal_comment", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "internal_comment")]
    public string InternalComment { get; set; }

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
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Returns {\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append("\n");
      sb.Append("  ReturnLines: ").Append(ReturnLines).Append("\n");
      sb.Append("  Base64: ").Append(Base64).Append("\n");
      sb.Append("  Secret: ").Append(Secret).Append("\n");
      sb.Append("  InternalComment: ").Append(InternalComment).Append("\n");
      sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
      sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
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
