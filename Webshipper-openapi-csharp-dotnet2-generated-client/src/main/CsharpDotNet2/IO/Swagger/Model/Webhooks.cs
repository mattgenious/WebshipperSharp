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
  public class Webhooks {
    /// <summary>
    /// The HTTP endpoint to be called. Webhooks always use POST as the request method.
    /// </summary>
    /// <value>The HTTP endpoint to be called. Webhooks always use POST as the request method.</value>
    [DataMember(Name="url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "url")]
    public string Url { get; set; }

    /// <summary>
    /// Which event should trigger the webhooks. Supported topics:     <ul>       <li><strong>order/created</strong> triggered when an order is created.</li>       <li><strong>order/updated</strong> triggered when an order is updated.</li>       <li><strong>order/deleted</strong> triggered when an order was deleted.</li>       <li><strong>shipment/created</strong> triggered when a shipment is created.</li>       <li><strong>shipment/updated</strong> triggered when a shipment is updated.</li>       <li><strong>shipment/deleted</strong> triggered when a shipment was deleted.</li>       <li><strong>return/created</strong> triggered when a return is created.</li>       <li><strong>return/updated</strong> triggered when a return is updated.</li>       <li><strong>return/deleted</strong> triggered when a return was deleted.</li>       <li><strong>report/created</strong> triggered when a report is created.</li>       <li><strong>report/updated</strong> triggered when a report is updated.</li>       <li><strong>report/deleted</strong> triggered when a report was deleted.</li>       <li><strong>trackingevent/created</strong> triggered when a tracking event is created.</li>       <li><strong>trackingevent/updated</strong> triggered when a tracking event is updated.</li>       <li><strong>trackingevent/deleted</strong> triggered when a tracking event was deleted.</li>     </ul>
    /// </summary>
    /// <value>Which event should trigger the webhooks. Supported topics:     <ul>       <li><strong>order/created</strong> triggered when an order is created.</li>       <li><strong>order/updated</strong> triggered when an order is updated.</li>       <li><strong>order/deleted</strong> triggered when an order was deleted.</li>       <li><strong>shipment/created</strong> triggered when a shipment is created.</li>       <li><strong>shipment/updated</strong> triggered when a shipment is updated.</li>       <li><strong>shipment/deleted</strong> triggered when a shipment was deleted.</li>       <li><strong>return/created</strong> triggered when a return is created.</li>       <li><strong>return/updated</strong> triggered when a return is updated.</li>       <li><strong>return/deleted</strong> triggered when a return was deleted.</li>       <li><strong>report/created</strong> triggered when a report is created.</li>       <li><strong>report/updated</strong> triggered when a report is updated.</li>       <li><strong>report/deleted</strong> triggered when a report was deleted.</li>       <li><strong>trackingevent/created</strong> triggered when a tracking event is created.</li>       <li><strong>trackingevent/updated</strong> triggered when a tracking event is updated.</li>       <li><strong>trackingevent/deleted</strong> triggered when a tracking event was deleted.</li>     </ul></value>
    [DataMember(Name="topic", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "topic")]
    public string Topic { get; set; }

    /// <summary>
    /// This is a boolean attribute that specifies whether the webhook is active.
    /// </summary>
    /// <value>This is a boolean attribute that specifies whether the webhook is active.</value>
    [DataMember(Name="enabled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// The secret used to sign the HMAC.
    /// </summary>
    /// <value>The secret used to sign the HMAC.</value>
    [DataMember(Name="secret", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "secret")]
    public string Secret { get; set; }

    /// <summary>
    /// Gets or Sets Health
    /// </summary>
    [DataMember(Name="health", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "health")]
    public string Health { get; set; }

    /// <summary>
    /// The most recent error message.
    /// </summary>
    /// <value>The most recent error message.</value>
    [DataMember(Name="latest_error", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "latest_error")]
    public string LatestError { get; set; }

    /// <summary>
    /// Gets or Sets Condition
    /// </summary>
    [DataMember(Name="condition", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "condition")]
    public string Condition { get; set; }

    /// <summary>
    /// The time when the resource was created
    /// </summary>
    /// <value>The time when the resource was created</value>
    [DataMember(Name="created_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "created_at")]
    public string CreatedAt { get; set; }

    /// <summary>
    /// The time when resource was last updated or when it was created if it was never updated
    /// </summary>
    /// <value>The time when resource was last updated or when it was created if it was never updated</value>
    [DataMember(Name="updated_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "updated_at")]
    public string UpdatedAt { get; set; }

    /// <summary>
    /// Gets or Sets Carriers
    /// </summary>
    [DataMember(Name="carriers", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "carriers")]
    public string Carriers { get; set; }

    /// <summary>
    /// Array of objects containing keys id and channel_label if condition describes a list of allowed order channels, <code>null</code> otherwise. 
    /// </summary>
    /// <value>Array of objects containing keys id and channel_label if condition describes a list of allowed order channels, <code>null</code> otherwise. </value>
    [DataMember(Name="order_channels", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "order_channels")]
    public List<string> OrderChannels { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Webhooks {\n");
      sb.Append("  Url: ").Append(Url).Append("\n");
      sb.Append("  Topic: ").Append(Topic).Append("\n");
      sb.Append("  Enabled: ").Append(Enabled).Append("\n");
      sb.Append("  Secret: ").Append(Secret).Append("\n");
      sb.Append("  Health: ").Append(Health).Append("\n");
      sb.Append("  LatestError: ").Append(LatestError).Append("\n");
      sb.Append("  Condition: ").Append(Condition).Append("\n");
      sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
      sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
      sb.Append("  Carriers: ").Append(Carriers).Append("\n");
      sb.Append("  OrderChannels: ").Append(OrderChannels).Append("\n");
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
