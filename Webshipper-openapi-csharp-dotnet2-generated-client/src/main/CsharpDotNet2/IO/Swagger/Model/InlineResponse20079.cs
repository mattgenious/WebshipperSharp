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
  public class InlineResponse20079 {
    /// <summary>
    /// Gets or Sets Data
    /// </summary>
    [DataMember(Name="data", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "data")]
    public InlineResponse20079Data Data { get; set; }

    /// <summary>
    /// Gets or Sets Relationships
    /// </summary>
    [DataMember(Name="relationships", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "relationships")]
    public InlineResponse20079Relationships Relationships { get; set; }

    /// <summary>
    /// Gets or Sets Included
    /// </summary>
    [DataMember(Name="included", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "included")]
    public List<InlineResponse20079Included> Included { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class InlineResponse20079 {\n");
      sb.Append("  Data: ").Append(Data).Append("\n");
      sb.Append("  Relationships: ").Append(Relationships).Append("\n");
      sb.Append("  Included: ").Append(Included).Append("\n");
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