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
  public class UsersidRelationships {
    /// <summary>
    /// Gets or Sets UserGroup
    /// </summary>
    [DataMember(Name="user_group", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "user_group")]
    public UsersidRelationshipsUserGroup UserGroup { get; set; }

    /// <summary>
    /// Gets or Sets PrinterClient
    /// </summary>
    [DataMember(Name="printer_client", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "printer_client")]
    public OrdersidRelationshipsPrinterClient PrinterClient { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UsersidRelationships {\n");
      sb.Append("  UserGroup: ").Append(UserGroup).Append("\n");
      sb.Append("  PrinterClient: ").Append(PrinterClient).Append("\n");
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
