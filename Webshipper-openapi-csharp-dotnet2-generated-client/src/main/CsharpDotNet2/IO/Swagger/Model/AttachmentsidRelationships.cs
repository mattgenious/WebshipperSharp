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
  public class AttachmentsidRelationships {
    /// <summary>
    /// Gets or Sets Document
    /// </summary>
    [DataMember(Name="document", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "document")]
    public AttachmentsidRelationshipsDocument Document { get; set; }

    /// <summary>
    /// Gets or Sets HasDocuments
    /// </summary>
    [DataMember(Name="has_documents", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "has_documents")]
    public AttachmentsidRelationshipsHasDocuments HasDocuments { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AttachmentsidRelationships {\n");
      sb.Append("  Document: ").Append(Document).Append("\n");
      sb.Append("  HasDocuments: ").Append(HasDocuments).Append("\n");
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
