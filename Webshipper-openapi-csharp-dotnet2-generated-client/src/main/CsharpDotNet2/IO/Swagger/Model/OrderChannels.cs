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
  public class OrderChannels {
    /// <summary>
    /// Label to identify the order channel.
    /// </summary>
    /// <value>Label to identify the order channel.</value>
    [DataMember(Name="channel_label", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "channel_label")]
    public string ChannelLabel { get; set; }

    /// <summary>
    /// Array of hashed with keys: <code>attr_key</code>, <code>attr_value</code>, <code>attr_name</code>, <code>attr_type</code>, <code>is_required</code>, </code>enums</code>. See       documentation for Local Attributes
    /// </summary>
    /// <value>Array of hashed with keys: <code>attr_key</code>, <code>attr_value</code>, <code>attr_name</code>, <code>attr_type</code>, <code>is_required</code>, </code>enums</code>. See       documentation for Local Attributes</value>
    [DataMember(Name="attrs", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "attrs")]
    public List<string> Attrs { get; set; }

    /// <summary>
    /// Optional hash, this is used when creating new order channels.
    /// </summary>
    /// <value>Optional hash, this is used when creating new order channels.</value>
    [DataMember(Name="additional_parameters", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "additional_parameters")]
    public Object AdditionalParameters { get; set; }

    /// <summary>
    /// Possible values: 'dont_print', 'print_immediately' or 'print_with_shipment'.
    /// </summary>
    /// <value>Possible values: 'dont_print', 'print_immediately' or 'print_with_shipment'.</value>
    [DataMember(Name="slip_print_mode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "slip_print_mode")]
    public string SlipPrintMode { get; set; }

    /// <summary>
    /// Possible values: 'dont_print', 'print_immediately'.
    /// </summary>
    /// <value>Possible values: 'dont_print', 'print_immediately'.</value>
    [DataMember(Name="return_label_print_mode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "return_label_print_mode")]
    public string ReturnLabelPrintMode { get; set; }

    /// <summary>
    /// Possible values: 'dont_print', 'print_immediately'.
    /// </summary>
    /// <value>Possible values: 'dont_print', 'print_immediately'.</value>
    [DataMember(Name="shipping_label_print_mode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "shipping_label_print_mode")]
    public string ShippingLabelPrintMode { get; set; }

    /// <summary>
    /// Possible values: 'dont_print', 'print_immediately'.
    /// </summary>
    /// <value>Possible values: 'dont_print', 'print_immediately'.</value>
    [DataMember(Name="document_print_mode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "document_print_mode")]
    public string DocumentPrintMode { get; set; }

    /// <summary>
    /// Base64 representation of the logo of the order channel.
    /// </summary>
    /// <value>Base64 representation of the logo of the order channel.</value>
    [DataMember(Name="logo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "logo")]
    public string Logo { get; set; }

    /// <summary>
    /// Token to use for Webshipper modules. Tokens will only be generated for modules that require a configuration token.
    /// </summary>
    /// <value>Token to use for Webshipper modules. Tokens will only be generated for modules that require a configuration token.</value>
    [DataMember(Name="configuration_token", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "configuration_token")]
    public string ConfigurationToken { get; set; }

    /// <summary>
    /// Determines if the order channel is currently synchronising. Possible values are: <code>synchronize</code>, <code>suspended</code>, <code>paused</code>.
    /// </summary>
    /// <value>Determines if the order channel is currently synchronising. Possible values are: <code>synchronize</code>, <code>suspended</code>, <code>paused</code>.</value>
    [DataMember(Name="sync_status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sync_status")]
    public int? SyncStatus { get; set; }

    /// <summary>
    /// Shows if recent synchronisation events have failed.
    /// </summary>
    /// <value>Shows if recent synchronisation events have failed.</value>
    [DataMember(Name="failed_sync_count", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "failed_sync_count")]
    public int? FailedSyncCount { get; set; }

    /// <summary>
    /// Whether or not to fulfill the order in the original order channel when a shipment is created. Default: true
    /// </summary>
    /// <value>Whether or not to fulfill the order in the original order channel when a shipment is created. Default: true</value>
    [DataMember(Name="fulfill_automatically", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fulfill_automatically")]
    public bool? FulfillAutomatically { get; set; }

    /// <summary>
    /// Gets or Sets DropPointLimit
    /// </summary>
    [DataMember(Name="drop_point_limit", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "drop_point_limit")]
    public int? DropPointLimit { get; set; }

    /// <summary>
    /// Gets or Sets CreateShipmentAutomatically
    /// </summary>
    [DataMember(Name="create_shipment_automatically", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "create_shipment_automatically")]
    public bool? CreateShipmentAutomatically { get; set; }

    /// <summary>
    /// Gets or Sets Health
    /// </summary>
    [DataMember(Name="health", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "health")]
    public string Health { get; set; }

    /// <summary>
    /// Gets or Sets ConvertCurrencyOnRateQuotes
    /// </summary>
    [DataMember(Name="convert_currency_on_rate_quotes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "convert_currency_on_rate_quotes")]
    public bool? ConvertCurrencyOnRateQuotes { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class OrderChannels {\n");
      sb.Append("  ChannelLabel: ").Append(ChannelLabel).Append("\n");
      sb.Append("  Attrs: ").Append(Attrs).Append("\n");
      sb.Append("  AdditionalParameters: ").Append(AdditionalParameters).Append("\n");
      sb.Append("  SlipPrintMode: ").Append(SlipPrintMode).Append("\n");
      sb.Append("  ReturnLabelPrintMode: ").Append(ReturnLabelPrintMode).Append("\n");
      sb.Append("  ShippingLabelPrintMode: ").Append(ShippingLabelPrintMode).Append("\n");
      sb.Append("  DocumentPrintMode: ").Append(DocumentPrintMode).Append("\n");
      sb.Append("  Logo: ").Append(Logo).Append("\n");
      sb.Append("  ConfigurationToken: ").Append(ConfigurationToken).Append("\n");
      sb.Append("  SyncStatus: ").Append(SyncStatus).Append("\n");
      sb.Append("  FailedSyncCount: ").Append(FailedSyncCount).Append("\n");
      sb.Append("  FulfillAutomatically: ").Append(FulfillAutomatically).Append("\n");
      sb.Append("  DropPointLimit: ").Append(DropPointLimit).Append("\n");
      sb.Append("  CreateShipmentAutomatically: ").Append(CreateShipmentAutomatically).Append("\n");
      sb.Append("  Health: ").Append(Health).Append("\n");
      sb.Append("  ConvertCurrencyOnRateQuotes: ").Append(ConvertCurrencyOnRateQuotes).Append("\n");
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
