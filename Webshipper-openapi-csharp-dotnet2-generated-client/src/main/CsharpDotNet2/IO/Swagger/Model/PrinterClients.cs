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
  public class PrinterClients {
    /// <summary>
    /// Unique ID of the printer client
    /// </summary>
    /// <value>Unique ID of the printer client</value>
    [DataMember(Name="uuid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "uuid")]
    public string Uuid { get; set; }

    /// <summary>
    /// DEPRECATED
    /// </summary>
    /// <value>DEPRECATED</value>
    [DataMember(Name="approved", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "approved")]
    public bool? Approved { get; set; }

    /// <summary>
    /// Defaults to the host name of the machine running the client 
    /// </summary>
    /// <value>Defaults to the host name of the machine running the client </value>
    [DataMember(Name="alias", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "alias")]
    public string Alias { get; set; }

    /// <summary>
    /// Shows if the printer client is online
    /// </summary>
    /// <value>Shows if the printer client is online</value>
    [DataMember(Name="is_online", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "is_online")]
    public bool? IsOnline { get; set; }

    /// <summary>
    /// Shows when the printer client was last connected
    /// </summary>
    /// <value>Shows when the printer client was last connected</value>
    [DataMember(Name="last_connected", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "last_connected")]
    public string LastConnected { get; set; }

    /// <summary>
    /// Gets or Sets PreventMultipleShipments
    /// </summary>
    [DataMember(Name="prevent_multiple_shipments", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "prevent_multiple_shipments")]
    public bool? PreventMultipleShipments { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PrinterClients {\n");
      sb.Append("  Uuid: ").Append(Uuid).Append("\n");
      sb.Append("  Approved: ").Append(Approved).Append("\n");
      sb.Append("  Alias: ").Append(Alias).Append("\n");
      sb.Append("  IsOnline: ").Append(IsOnline).Append("\n");
      sb.Append("  LastConnected: ").Append(LastConnected).Append("\n");
      sb.Append("  PreventMultipleShipments: ").Append(PreventMultipleShipments).Append("\n");
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
