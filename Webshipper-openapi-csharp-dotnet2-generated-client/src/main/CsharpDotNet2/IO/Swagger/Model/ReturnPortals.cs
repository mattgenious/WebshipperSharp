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
  public class ReturnPortals {
    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets CustomStyle
    /// </summary>
    [DataMember(Name="custom_style", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "custom_style")]
    public string CustomStyle { get; set; }

    /// <summary>
    /// Gets or Sets ShippingMethods
    /// </summary>
    [DataMember(Name="shipping_methods", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "shipping_methods")]
    public string ShippingMethods { get; set; }

    /// <summary>
    /// Gets or Sets Translations
    /// </summary>
    [DataMember(Name="translations", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "translations")]
    public string Translations { get; set; }

    /// <summary>
    /// Gets or Sets Locale
    /// </summary>
    [DataMember(Name="locale", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "locale")]
    public string Locale { get; set; }

    /// <summary>
    /// Gets or Sets AllowedDaysSinceDispatch
    /// </summary>
    [DataMember(Name="allowed_days_since_dispatch", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "allowed_days_since_dispatch")]
    public int? AllowedDaysSinceDispatch { get; set; }

    /// <summary>
    /// Gets or Sets SendImmediately
    /// </summary>
    [DataMember(Name="send_immediately", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "send_immediately")]
    public bool? SendImmediately { get; set; }

    /// <summary>
    /// Gets or Sets StaticNoticeEmail
    /// </summary>
    [DataMember(Name="static_notice_email", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "static_notice_email")]
    public string StaticNoticeEmail { get; set; }

    /// <summary>
    /// Gets or Sets OrderChannelLogo
    /// </summary>
    [DataMember(Name="order_channel_logo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "order_channel_logo")]
    public string OrderChannelLogo { get; set; }

    /// <summary>
    /// Gets or Sets Logo
    /// </summary>
    [DataMember(Name="logo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "logo")]
    public string Logo { get; set; }

    /// <summary>
    /// Gets or Sets ForceSinglePage
    /// </summary>
    [DataMember(Name="force_single_page", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "force_single_page")]
    public bool? ForceSinglePage { get; set; }

    /// <summary>
    /// Gets or Sets OrderChannelId
    /// </summary>
    [DataMember(Name="order_channel_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "order_channel_id")]
    public int? OrderChannelId { get; set; }

    /// <summary>
    /// Gets or Sets OptionalReturnCause
    /// </summary>
    [DataMember(Name="optional_return_cause", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "optional_return_cause")]
    public bool? OptionalReturnCause { get; set; }

    /// <summary>
    /// Gets or Sets NewMailTemplate
    /// </summary>
    [DataMember(Name="new_mail_template", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "new_mail_template")]
    public string NewMailTemplate { get; set; }

    /// <summary>
    /// Gets or Sets NewConfirmationMailTemplate
    /// </summary>
    [DataMember(Name="new_confirmation_mail_template", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "new_confirmation_mail_template")]
    public string NewConfirmationMailTemplate { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ReturnPortals {\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  CustomStyle: ").Append(CustomStyle).Append("\n");
      sb.Append("  ShippingMethods: ").Append(ShippingMethods).Append("\n");
      sb.Append("  Translations: ").Append(Translations).Append("\n");
      sb.Append("  Locale: ").Append(Locale).Append("\n");
      sb.Append("  AllowedDaysSinceDispatch: ").Append(AllowedDaysSinceDispatch).Append("\n");
      sb.Append("  SendImmediately: ").Append(SendImmediately).Append("\n");
      sb.Append("  StaticNoticeEmail: ").Append(StaticNoticeEmail).Append("\n");
      sb.Append("  OrderChannelLogo: ").Append(OrderChannelLogo).Append("\n");
      sb.Append("  Logo: ").Append(Logo).Append("\n");
      sb.Append("  ForceSinglePage: ").Append(ForceSinglePage).Append("\n");
      sb.Append("  OrderChannelId: ").Append(OrderChannelId).Append("\n");
      sb.Append("  OptionalReturnCause: ").Append(OptionalReturnCause).Append("\n");
      sb.Append("  NewMailTemplate: ").Append(NewMailTemplate).Append("\n");
      sb.Append("  NewConfirmationMailTemplate: ").Append(NewConfirmationMailTemplate).Append("\n");
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
