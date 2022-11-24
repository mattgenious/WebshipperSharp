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
  public class HotKeys {
    /// <summary>
    /// Key combination of the hotkey
    /// </summary>
    /// <value>Key combination of the hotkey</value>
    [DataMember(Name="hot_key", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hot_key")]
    public string HotKey { get; set; }

    /// <summary>
    /// Path the hotkey is assigned to
    /// </summary>
    /// <value>Path the hotkey is assigned to</value>
    [DataMember(Name="path", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "path")]
    public string Path { get; set; }

    /// <summary>
    /// Gets or Sets FavouritePageId
    /// </summary>
    [DataMember(Name="favourite_page_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "favourite_page_id")]
    public int? FavouritePageId { get; set; }

    /// <summary>
    /// Gets or Sets UserId
    /// </summary>
    [DataMember(Name="user_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "user_id")]
    public int? UserId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class HotKeys {\n");
      sb.Append("  HotKey: ").Append(HotKey).Append("\n");
      sb.Append("  Path: ").Append(Path).Append("\n");
      sb.Append("  FavouritePageId: ").Append(FavouritePageId).Append("\n");
      sb.Append("  UserId: ").Append(UserId).Append("\n");
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
