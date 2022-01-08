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
  public class SlipTemplates {
    /// <summary>
    /// Name to identify the template.
    /// </summary>
    /// <value>Name to identify the template.</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Size of the parcel slip. Possible values: <code>A4</code> and <code>4X6</code>
    /// </summary>
    /// <value>Size of the parcel slip. Possible values: <code>A4</code> and <code>4X6</code></value>
    [DataMember(Name="slip_size", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "slip_size")]
    public int? SlipSize { get; set; }

    /// <summary>
    /// Content after the table of order lines for A4-based parcel slips.
    /// </summary>
    /// <value>Content after the table of order lines for A4-based parcel slips.</value>
    [DataMember(Name="additional_content", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "additional_content")]
    public string AdditionalContent { get; set; }

    /// <summary>
    /// Alignment of additional_content. Possible values: <code>center</code>, <code>right</code>, <code>left</code>
    /// </summary>
    /// <value>Alignment of additional_content. Possible values: <code>center</code>, <code>right</code>, <code>left</code></value>
    [DataMember(Name="additional_content_align", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "additional_content_align")]
    public int? AdditionalContentAlign { get; set; }

    /// <summary>
    /// Content of the barcode
    /// </summary>
    /// <value>Content of the barcode</value>
    [DataMember(Name="barcode_content", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "barcode_content")]
    public string BarcodeContent { get; set; }

    /// <summary>
    /// Content of the slip header
    /// </summary>
    /// <value>Content of the slip header</value>
    [DataMember(Name="header_content", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "header_content")]
    public string HeaderContent { get; set; }

    /// <summary>
    /// Header of the top left corner
    /// </summary>
    /// <value>Header of the top left corner</value>
    [DataMember(Name="top_left_content_header", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "top_left_content_header")]
    public string TopLeftContentHeader { get; set; }

    /// <summary>
    /// Header of the top right corner
    /// </summary>
    /// <value>Header of the top right corner</value>
    [DataMember(Name="top_right_content_header", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "top_right_content_header")]
    public string TopRightContentHeader { get; set; }

    /// <summary>
    /// Content of the top left corner
    /// </summary>
    /// <value>Content of the top left corner</value>
    [DataMember(Name="top_left_content", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "top_left_content")]
    public string TopLeftContent { get; set; }

    /// <summary>
    /// Content of the top right corner
    /// </summary>
    /// <value>Content of the top right corner</value>
    [DataMember(Name="top_right_content", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "top_right_content")]
    public string TopRightContent { get; set; }

    /// <summary>
    /// Content of the footer
    /// </summary>
    /// <value>Content of the footer</value>
    [DataMember(Name="footer_content", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "footer_content")]
    public string FooterContent { get; set; }

    /// <summary>
    /// Array of columns. Column objects contains: <code>name</code><code>content</code>, <code>text_alignment</code>(right, left, center), <code>width</code> (in percentage)
    /// </summary>
    /// <value>Array of columns. Column objects contains: <code>name</code><code>content</code>, <code>text_alignment</code>(right, left, center), <code>width</code> (in percentage)</value>
    [DataMember(Name="slip_template_columns", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "slip_template_columns")]
    public string SlipTemplateColumns { get; set; }

    /// <summary>
    /// HEX color including #
    /// </summary>
    /// <value>HEX color including #</value>
    [DataMember(Name="table_color", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "table_color")]
    public string TableColor { get; set; }

    /// <summary>
    /// HEX color including #
    /// </summary>
    /// <value>HEX color including #</value>
    [DataMember(Name="table_text_color", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "table_text_color")]
    public string TableTextColor { get; set; }

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
    /// The key to sort the order-lines by
    /// </summary>
    /// <value>The key to sort the order-lines by</value>
    [DataMember(Name="sort_key", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sort_key")]
    public string SortKey { get; set; }

    /// <summary>
    /// Gets or Sets ReturnsOnly
    /// </summary>
    [DataMember(Name="returns_only", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "returns_only")]
    public bool? ReturnsOnly { get; set; }

    /// <summary>
    /// Gets or Sets DisableInlineFormatting
    /// </summary>
    [DataMember(Name="disable_inline_formatting", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "disable_inline_formatting")]
    public bool? DisableInlineFormatting { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SlipTemplates {\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  SlipSize: ").Append(SlipSize).Append("\n");
      sb.Append("  AdditionalContent: ").Append(AdditionalContent).Append("\n");
      sb.Append("  AdditionalContentAlign: ").Append(AdditionalContentAlign).Append("\n");
      sb.Append("  BarcodeContent: ").Append(BarcodeContent).Append("\n");
      sb.Append("  HeaderContent: ").Append(HeaderContent).Append("\n");
      sb.Append("  TopLeftContentHeader: ").Append(TopLeftContentHeader).Append("\n");
      sb.Append("  TopRightContentHeader: ").Append(TopRightContentHeader).Append("\n");
      sb.Append("  TopLeftContent: ").Append(TopLeftContent).Append("\n");
      sb.Append("  TopRightContent: ").Append(TopRightContent).Append("\n");
      sb.Append("  FooterContent: ").Append(FooterContent).Append("\n");
      sb.Append("  SlipTemplateColumns: ").Append(SlipTemplateColumns).Append("\n");
      sb.Append("  TableColor: ").Append(TableColor).Append("\n");
      sb.Append("  TableTextColor: ").Append(TableTextColor).Append("\n");
      sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
      sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
      sb.Append("  SortKey: ").Append(SortKey).Append("\n");
      sb.Append("  ReturnsOnly: ").Append(ReturnsOnly).Append("\n");
      sb.Append("  DisableInlineFormatting: ").Append(DisableInlineFormatting).Append("\n");
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
