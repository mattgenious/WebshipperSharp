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
  public class CsvUploads {
    /// <summary>
    /// A list of ids of the imported records
    /// </summary>
    /// <value>A list of ids of the imported records</value>
    [DataMember(Name="imported", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "imported")]
    public List<string> Imported { get; set; }

    /// <summary>
    /// The raw CSV data
    /// </summary>
    /// <value>The raw CSV data</value>
    [DataMember(Name="input", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "input")]
    public string Input { get; set; }

    /// <summary>
    /// Gets or Sets InputUrl
    /// </summary>
    [DataMember(Name="input_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "input_url")]
    public string InputUrl { get; set; }

    /// <summary>
    /// A list of error messages for items that could not be imported
    /// </summary>
    /// <value>A list of error messages for items that could not be imported</value>
    [DataMember(Name="import_errors", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "import_errors")]
    public List<string> ImportErrors { get; set; }

    /// <summary>
    /// If set to true, the import will be performed in background. Highly recommended for imports larger than 100 rows.
    /// </summary>
    /// <value>If set to true, the import will be performed in background. Highly recommended for imports larger than 100 rows.</value>
    [DataMember(Name="async", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "async")]
    public bool? Async { get; set; }

    /// <summary>
    /// Gets or Sets MakeExportable
    /// </summary>
    [DataMember(Name="make_exportable", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "make_exportable")]
    public bool? MakeExportable { get; set; }

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
      sb.Append("class CsvUploads {\n");
      sb.Append("  Imported: ").Append(Imported).Append("\n");
      sb.Append("  Input: ").Append(Input).Append("\n");
      sb.Append("  InputUrl: ").Append(InputUrl).Append("\n");
      sb.Append("  ImportErrors: ").Append(ImportErrors).Append("\n");
      sb.Append("  Async: ").Append(Async).Append("\n");
      sb.Append("  MakeExportable: ").Append(MakeExportable).Append("\n");
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
