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
  public class CsvMappings {
    /// <summary>
    /// The seperator in the file. Normally ';' or ','
    /// </summary>
    /// <value>The seperator in the file. Normally ';' or ','</value>
    [DataMember(Name="separator", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "separator")]
    public string Separator { get; set; }

    /// <summary>
    /// Must be one of the models <code>Order</code> or <code>Shipment</code>
    /// </summary>
    /// <value>Must be one of the models <code>Order</code> or <code>Shipment</code></value>
    [DataMember(Name="target_class", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "target_class")]
    public string TargetClass { get; set; }

    /// <summary>
    /// Must be the index of the Order ID
    /// </summary>
    /// <value>Must be the index of the Order ID</value>
    [DataMember(Name="grouped_by", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "grouped_by")]
    public int? GroupedBy { get; set; }

    /// <summary>
    /// The sub-model which you are grouping. For order: order_lines_attributes
    /// </summary>
    /// <value>The sub-model which you are grouping. For order: order_lines_attributes</value>
    [DataMember(Name="grouped_path", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "grouped_path")]
    public string GroupedPath { get; set; }

    /// <summary>
    /// Determines if there is an ignorable header line in the file
    /// </summary>
    /// <value>Determines if there is an ignorable header line in the file</value>
    [DataMember(Name="includes_header", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "includes_header")]
    public bool? IncludesHeader { get; set; }

    /// <summary>
    /// Gets or Sets LinesAsPackage
    /// </summary>
    [DataMember(Name="lines_as_package", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lines_as_package")]
    public bool? LinesAsPackage { get; set; }

    /// <summary>
    /// Gets or Sets RecreateOrderLines
    /// </summary>
    [DataMember(Name="recreate_order_lines", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "recreate_order_lines")]
    public bool? RecreateOrderLines { get; set; }

    /// <summary>
    /// Gets or Sets SeparateOrderLineMapping
    /// </summary>
    [DataMember(Name="separate_order_line_mapping", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "separate_order_line_mapping")]
    public bool? SeparateOrderLineMapping { get; set; }

    /// <summary>
    /// Name of the configuration
    /// </summary>
    /// <value>Name of the configuration</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Example input to make it easier to create the mapping in the UI.
    /// </summary>
    /// <value>Example input to make it easier to create the mapping in the UI.</value>
    [DataMember(Name="example_input", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "example_input")]
    public string ExampleInput { get; set; }

    /// <summary>
    /// Gets or Sets LineExampleInput
    /// </summary>
    [DataMember(Name="line_example_input", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "line_example_input")]
    public string LineExampleInput { get; set; }

    /// <summary>
    /// Array of flattened resources of the type CSV Rule
    /// </summary>
    /// <value>Array of flattened resources of the type CSV Rule</value>
    [DataMember(Name="rules", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "rules")]
    public List<string> Rules { get; set; }

    /// <summary>
    /// Gets or Sets ShipmentExportFormat
    /// </summary>
    [DataMember(Name="shipment_export_format", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "shipment_export_format")]
    public string ShipmentExportFormat { get; set; }

    /// <summary>
    /// Gets or Sets OrderExportFormat
    /// </summary>
    [DataMember(Name="order_export_format", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "order_export_format")]
    public string OrderExportFormat { get; set; }

    /// <summary>
    /// Gets or Sets CreateShipmentAutomatically
    /// </summary>
    [DataMember(Name="create_shipment_automatically", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "create_shipment_automatically")]
    public bool? CreateShipmentAutomatically { get; set; }

    /// <summary>
    /// Gets or Sets ForceAsync
    /// </summary>
    [DataMember(Name="force_async", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "force_async")]
    public bool? ForceAsync { get; set; }

    /// <summary>
    /// Gets or Sets ConcatPaths
    /// </summary>
    [DataMember(Name="concat_paths", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "concat_paths")]
    public bool? ConcatPaths { get; set; }

    /// <summary>
    /// Gets or Sets SplitLargeRecords
    /// </summary>
    [DataMember(Name="split_large_records", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "split_large_records")]
    public bool? SplitLargeRecords { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CsvMappings {\n");
      sb.Append("  Separator: ").Append(Separator).Append("\n");
      sb.Append("  TargetClass: ").Append(TargetClass).Append("\n");
      sb.Append("  GroupedBy: ").Append(GroupedBy).Append("\n");
      sb.Append("  GroupedPath: ").Append(GroupedPath).Append("\n");
      sb.Append("  IncludesHeader: ").Append(IncludesHeader).Append("\n");
      sb.Append("  LinesAsPackage: ").Append(LinesAsPackage).Append("\n");
      sb.Append("  RecreateOrderLines: ").Append(RecreateOrderLines).Append("\n");
      sb.Append("  SeparateOrderLineMapping: ").Append(SeparateOrderLineMapping).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  ExampleInput: ").Append(ExampleInput).Append("\n");
      sb.Append("  LineExampleInput: ").Append(LineExampleInput).Append("\n");
      sb.Append("  Rules: ").Append(Rules).Append("\n");
      sb.Append("  ShipmentExportFormat: ").Append(ShipmentExportFormat).Append("\n");
      sb.Append("  OrderExportFormat: ").Append(OrderExportFormat).Append("\n");
      sb.Append("  CreateShipmentAutomatically: ").Append(CreateShipmentAutomatically).Append("\n");
      sb.Append("  ForceAsync: ").Append(ForceAsync).Append("\n");
      sb.Append("  ConcatPaths: ").Append(ConcatPaths).Append("\n");
      sb.Append("  SplitLargeRecords: ").Append(SplitLargeRecords).Append("\n");
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
