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
  public class Reports {
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
    /// Gets or Sets StartTime
    /// </summary>
    [DataMember(Name="start_time", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "start_time")]
    public string StartTime { get; set; }

    /// <summary>
    /// Gets or Sets EndTime
    /// </summary>
    [DataMember(Name="end_time", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "end_time")]
    public string EndTime { get; set; }

    /// <summary>
    /// Gets or Sets OutputFormats
    /// </summary>
    [DataMember(Name="output_formats", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "output_formats")]
    public List<string> OutputFormats { get; set; }

    /// <summary>
    /// Gets or Sets Parameters
    /// </summary>
    [DataMember(Name="parameters", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "parameters")]
    public Object Parameters { get; set; }

    /// <summary>
    /// Gets or Sets Base64
    /// </summary>
    [DataMember(Name="base64", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "base64")]
    public string Base64 { get; set; }

    /// <summary>
    /// Gets or Sets PdfDownloadUrl
    /// </summary>
    [DataMember(Name="pdf_download_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pdf_download_url")]
    public string PdfDownloadUrl { get; set; }

    /// <summary>
    /// Gets or Sets XmlDownloadUrl
    /// </summary>
    [DataMember(Name="xml_download_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "xml_download_url")]
    public string XmlDownloadUrl { get; set; }

    /// <summary>
    /// Gets or Sets CsvDownloadUrl
    /// </summary>
    [DataMember(Name="csv_download_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "csv_download_url")]
    public string CsvDownloadUrl { get; set; }

    /// <summary>
    /// Gets or Sets JsonDownloadUrl
    /// </summary>
    [DataMember(Name="json_download_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "json_download_url")]
    public string JsonDownloadUrl { get; set; }

    /// <summary>
    /// Gets or Sets XlsxDownloadUrl
    /// </summary>
    [DataMember(Name="xlsx_download_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "xlsx_download_url")]
    public string XlsxDownloadUrl { get; set; }

    /// <summary>
    /// Gets or Sets Failed
    /// </summary>
    [DataMember(Name="failed", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "failed")]
    public bool? Failed { get; set; }

    /// <summary>
    /// Gets or Sets OrderIds
    /// </summary>
    [DataMember(Name="order_ids", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "order_ids")]
    public string OrderIds { get; set; }

    /// <summary>
    /// Gets or Sets ErrorMessage
    /// </summary>
    [DataMember(Name="error_message", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "error_message")]
    public string ErrorMessage { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Reports {\n");
      sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
      sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
      sb.Append("  StartTime: ").Append(StartTime).Append("\n");
      sb.Append("  EndTime: ").Append(EndTime).Append("\n");
      sb.Append("  OutputFormats: ").Append(OutputFormats).Append("\n");
      sb.Append("  Parameters: ").Append(Parameters).Append("\n");
      sb.Append("  Base64: ").Append(Base64).Append("\n");
      sb.Append("  PdfDownloadUrl: ").Append(PdfDownloadUrl).Append("\n");
      sb.Append("  XmlDownloadUrl: ").Append(XmlDownloadUrl).Append("\n");
      sb.Append("  CsvDownloadUrl: ").Append(CsvDownloadUrl).Append("\n");
      sb.Append("  JsonDownloadUrl: ").Append(JsonDownloadUrl).Append("\n");
      sb.Append("  XlsxDownloadUrl: ").Append(XlsxDownloadUrl).Append("\n");
      sb.Append("  Failed: ").Append(Failed).Append("\n");
      sb.Append("  OrderIds: ").Append(OrderIds).Append("\n");
      sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append("\n");
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
