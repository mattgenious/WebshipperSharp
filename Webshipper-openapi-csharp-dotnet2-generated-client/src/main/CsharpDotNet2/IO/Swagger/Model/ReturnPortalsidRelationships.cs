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
  public class ReturnPortalsidRelationships {
    /// <summary>
    /// Gets or Sets OrderChannel
    /// </summary>
    [DataMember(Name="order_channel", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "order_channel")]
    public CsvMappingsidRelationshipsOrderChannel OrderChannel { get; set; }

    /// <summary>
    /// Gets or Sets SlipTemplate
    /// </summary>
    [DataMember(Name="slip_template", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "slip_template")]
    public OrderChannelsidRelationshipsSlipTemplate SlipTemplate { get; set; }

    /// <summary>
    /// Gets or Sets MailTemplate
    /// </summary>
    [DataMember(Name="mail_template", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "mail_template")]
    public ReturnPortalsidRelationshipsMailTemplate MailTemplate { get; set; }

    /// <summary>
    /// Gets or Sets ConfirmationMailTemplate
    /// </summary>
    [DataMember(Name="confirmation_mail_template", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "confirmation_mail_template")]
    public ReturnPortalsidRelationshipsMailTemplate ConfirmationMailTemplate { get; set; }

    /// <summary>
    /// Gets or Sets ReturnAddress
    /// </summary>
    [DataMember(Name="return_address", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "return_address")]
    public CarriersidRelationshipsSenderAddress ReturnAddress { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ReturnPortalsidRelationships {\n");
      sb.Append("  OrderChannel: ").Append(OrderChannel).Append("\n");
      sb.Append("  SlipTemplate: ").Append(SlipTemplate).Append("\n");
      sb.Append("  MailTemplate: ").Append(MailTemplate).Append("\n");
      sb.Append("  ConfirmationMailTemplate: ").Append(ConfirmationMailTemplate).Append("\n");
      sb.Append("  ReturnAddress: ").Append(ReturnAddress).Append("\n");
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
