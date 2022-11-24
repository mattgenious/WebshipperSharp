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
  public class TrackingEvents {
    /// <summary>
    /// One of <em>information_received</em>, <em>in_transit</em>, <em>out_for_delivery</em>, <em>customs_clearance_delayed</em>, <em>attempted_delivery</em>, <em>ready_for_pickup</em>, <em>delivered_to_drop_point</em>, <em>delivered</em>, <em>returned</em>, <em>undeliverable</em> or <em>unknown</em>
    /// </summary>
    /// <value>One of <em>information_received</em>, <em>in_transit</em>, <em>out_for_delivery</em>, <em>customs_clearance_delayed</em>, <em>attempted_delivery</em>, <em>ready_for_pickup</em>, <em>delivered_to_drop_point</em>, <em>delivered</em>, <em>returned</em>, <em>undeliverable</em> or <em>unknown</em></value>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

    /// <summary>
    /// Time the event occured at the carrier
    /// </summary>
    /// <value>Time the event occured at the carrier</value>
    [DataMember(Name="time", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "time")]
    public string Time { get; set; }

    /// <summary>
    /// Readable description of the event
    /// </summary>
    /// <value>Readable description of the event</value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// Gets or Sets Location
    /// </summary>
    [DataMember(Name="location", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "location")]
    public string Location { get; set; }

    /// <summary>
    /// Gets or Sets Latitude
    /// </summary>
    [DataMember(Name="latitude", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "latitude")]
    public decimal? Latitude { get; set; }

    /// <summary>
    /// Gets or Sets Longitude
    /// </summary>
    [DataMember(Name="longitude", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "longitude")]
    public decimal? Longitude { get; set; }

    /// <summary>
    /// The tracking number for this event, if availiable
    /// </summary>
    /// <value>The tracking number for this event, if availiable</value>
    [DataMember(Name="tracking_number", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tracking_number")]
    public string TrackingNumber { get; set; }

    /// <summary>
    /// Unique event of the id
    /// </summary>
    /// <value>Unique event of the id</value>
    [DataMember(Name="event_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "event_id")]
    public string EventId { get; set; }

    /// <summary>
    /// Gets or Sets TrackingLinkId
    /// </summary>
    [DataMember(Name="tracking_link_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tracking_link_id")]
    public int? TrackingLinkId { get; set; }

    /// <summary>
    /// The tracking link for this event, if availiable
    /// </summary>
    /// <value>The tracking link for this event, if availiable</value>
    [DataMember(Name="tracking_link_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tracking_link_url")]
    public string TrackingLinkUrl { get; set; }

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
      sb.Append("class TrackingEvents {\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  Time: ").Append(Time).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  Location: ").Append(Location).Append("\n");
      sb.Append("  Latitude: ").Append(Latitude).Append("\n");
      sb.Append("  Longitude: ").Append(Longitude).Append("\n");
      sb.Append("  TrackingNumber: ").Append(TrackingNumber).Append("\n");
      sb.Append("  EventId: ").Append(EventId).Append("\n");
      sb.Append("  TrackingLinkId: ").Append(TrackingLinkId).Append("\n");
      sb.Append("  TrackingLinkUrl: ").Append(TrackingLinkUrl).Append("\n");
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
