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
  public class Documents {
    /// <summary>
    /// Id of the shipment it belongs to
    /// </summary>
    /// <value>Id of the shipment it belongs to</value>
    [DataMember(Name="shipment_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "shipment_id")]
    public int? ShipmentId { get; set; }

    /// <summary>
    /// Enum for the paper size. valid values: <code>A4</code>
    /// </summary>
    /// <value>Enum for the paper size. valid values: <code>A4</code></value>
    [DataMember(Name="document_size", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "document_size")]
    public string DocumentSize { get; set; }

    /// <summary>
    /// Enum for the document format. Valid values: <code>PDF</code>
    /// </summary>
    /// <value>Enum for the document format. Valid values: <code>PDF</code></value>
    [DataMember(Name="document_format", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "document_format")]
    public string DocumentFormat { get; set; }

    /// <summary>
    /// Base64 representation of the document. Only required when creating.
    /// </summary>
    /// <value>Base64 representation of the document. Only required when creating.</value>
    [DataMember(Name="base64", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "base64")]
    public string Base64 { get; set; }

    /// <summary>
    /// Used to indicate if this document is a special document, like static customs documents. Special documents will be displayed in Webshipper under Settings > Documents.
    /// </summary>
    /// <value>Used to indicate if this document is a special document, like static customs documents. Special documents will be displayed in Webshipper under Settings > Documents.</value>
    [DataMember(Name="is_special", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "is_special")]
    public bool? IsSpecial { get; set; }

    /// <summary>
    /// Used for special documents
    /// </summary>
    /// <value>Used for special documents</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Used for special documents
    /// </summary>
    /// <value>Used for special documents</value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// One of: 'shipping_document', 'other', 'customs_document', 'invoice', 'certificate', 'proforma', 'nafta_certificate', 'commercial', 'awb'. Documents returned from the carrier are always shipping_document. 
    /// </summary>
    /// <value>One of: 'shipping_document', 'other', 'customs_document', 'invoice', 'certificate', 'proforma', 'nafta_certificate', 'commercial', 'awb'. Documents returned from the carrier are always shipping_document. </value>
    [DataMember(Name="document_type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "document_type")]
    public int? DocumentType { get; set; }

    /// <summary>
    /// Used to indicate if a shipment is paperless
    /// </summary>
    /// <value>Used to indicate if a shipment is paperless</value>
    [DataMember(Name="is_paperless", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "is_paperless")]
    public bool? IsPaperless { get; set; }

    /// <summary>
    /// The time when resource was last updated or when it was created if it was never updated
    /// </summary>
    /// <value>The time when resource was last updated or when it was created if it was never updated</value>
    [DataMember(Name="updated_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "updated_at")]
    public string UpdatedAt { get; set; }

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
      sb.Append("class Documents {\n");
      sb.Append("  ShipmentId: ").Append(ShipmentId).Append("\n");
      sb.Append("  DocumentSize: ").Append(DocumentSize).Append("\n");
      sb.Append("  DocumentFormat: ").Append(DocumentFormat).Append("\n");
      sb.Append("  Base64: ").Append(Base64).Append("\n");
      sb.Append("  IsSpecial: ").Append(IsSpecial).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  DocumentType: ").Append(DocumentType).Append("\n");
      sb.Append("  IsPaperless: ").Append(IsPaperless).Append("\n");
      sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
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
