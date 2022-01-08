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
  public class ShipmentsTrackingLinks {
    /// <summary>
    /// Gets or Sets Url
    /// </summary>
    [DataMember(Name="url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "url")]
    public string Url { get; set; }

    /// <summary>
    /// Gets or Sets Number
    /// </summary>
    [DataMember(Name="number", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "number")]
    public string Number { get; set; }

    /// <summary>
    /// Gets or Sets LatestTransitEvent
    /// </summary>
    [DataMember(Name="latest_transit_event", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "latest_transit_event")]
    public string LatestTransitEvent { get; set; }

    /// <summary>
    /// Gets or Sets TrackingEvents
    /// </summary>
    [DataMember(Name="tracking_events", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tracking_events")]
    public string TrackingEvents { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ShipmentsTrackingLinks {\n");
      sb.Append("  Url: ").Append(Url).Append("\n");
      sb.Append("  Number: ").Append(Number).Append("\n");
      sb.Append("  LatestTransitEvent: ").Append(LatestTransitEvent).Append("\n");
      sb.Append("  TrackingEvents: ").Append(TrackingEvents).Append("\n");
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
