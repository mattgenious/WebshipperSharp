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
  public class MailTemplatePreviews {
    /// <summary>
    /// Gets or Sets Mail
    /// </summary>
    [DataMember(Name="mail", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "mail")]
    public string Mail { get; set; }

    /// <summary>
    /// Gets or Sets MailTemplate
    /// </summary>
    [DataMember(Name="mail_template", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "mail_template")]
    public string MailTemplate { get; set; }

    /// <summary>
    /// Gets or Sets MailLocale
    /// </summary>
    [DataMember(Name="mail_locale", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "mail_locale")]
    public string MailLocale { get; set; }

    /// <summary>
    /// Gets or Sets Locale
    /// </summary>
    [DataMember(Name="locale", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "locale")]
    public string Locale { get; set; }

    /// <summary>
    /// Gets or Sets ShipmentId
    /// </summary>
    [DataMember(Name="shipment_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "shipment_id")]
    public string ShipmentId { get; set; }

    /// <summary>
    /// Gets or Sets ReturnId
    /// </summary>
    [DataMember(Name="return_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "return_id")]
    public string ReturnId { get; set; }

    /// <summary>
    /// Gets or Sets OrderId
    /// </summary>
    [DataMember(Name="order_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "order_id")]
    public string OrderId { get; set; }

    /// <summary>
    /// Gets or Sets BrandId
    /// </summary>
    [DataMember(Name="brand_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "brand_id")]
    public string BrandId { get; set; }

    /// <summary>
    /// Gets or Sets Hook
    /// </summary>
    [DataMember(Name="hook", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hook")]
    public string Hook { get; set; }

    /// <summary>
    /// Gets or Sets Overrides
    /// </summary>
    [DataMember(Name="overrides", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "overrides")]
    public string Overrides { get; set; }

    /// <summary>
    /// Gets or Sets Lang
    /// </summary>
    [DataMember(Name="lang", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lang")]
    public string Lang { get; set; }

    /// <summary>
    /// Gets or Sets Defaults
    /// </summary>
    [DataMember(Name="defaults", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "defaults")]
    public string Defaults { get; set; }

    /// <summary>
    /// Gets or Sets To
    /// </summary>
    [DataMember(Name="to", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "to")]
    public string To { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class MailTemplatePreviews {\n");
      sb.Append("  Mail: ").Append(Mail).Append("\n");
      sb.Append("  MailTemplate: ").Append(MailTemplate).Append("\n");
      sb.Append("  MailLocale: ").Append(MailLocale).Append("\n");
      sb.Append("  Locale: ").Append(Locale).Append("\n");
      sb.Append("  ShipmentId: ").Append(ShipmentId).Append("\n");
      sb.Append("  ReturnId: ").Append(ReturnId).Append("\n");
      sb.Append("  OrderId: ").Append(OrderId).Append("\n");
      sb.Append("  BrandId: ").Append(BrandId).Append("\n");
      sb.Append("  Hook: ").Append(Hook).Append("\n");
      sb.Append("  Overrides: ").Append(Overrides).Append("\n");
      sb.Append("  Lang: ").Append(Lang).Append("\n");
      sb.Append("  Defaults: ").Append(Defaults).Append("\n");
      sb.Append("  To: ").Append(To).Append("\n");
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
