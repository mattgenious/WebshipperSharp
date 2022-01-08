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
  public class FavouritePagesidRelationships {
    /// <summary>
    /// Gets or Sets User
    /// </summary>
    [DataMember(Name="user", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "user")]
    public CarrierAccessesRelationshipsUser User { get; set; }

    /// <summary>
    /// Gets or Sets HotKey
    /// </summary>
    [DataMember(Name="hot_key", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hot_key")]
    public FavouritePagesidRelationshipsHotKey HotKey { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class FavouritePagesidRelationships {\n");
      sb.Append("  User: ").Append(User).Append("\n");
      sb.Append("  HotKey: ").Append(HotKey).Append("\n");
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
