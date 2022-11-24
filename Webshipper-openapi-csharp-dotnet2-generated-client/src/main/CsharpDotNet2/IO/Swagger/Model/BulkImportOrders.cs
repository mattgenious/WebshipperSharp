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
  public class BulkImportOrders {
    /// <summary>
    /// Order ids to import from the order channel
    /// </summary>
    /// <value>Order ids to import from the order channel</value>
    [DataMember(Name="ids", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ids")]
    public string Ids { get; set; }

    /// <summary>
    /// Id of the order channel to import orders from
    /// </summary>
    /// <value>Id of the order channel to import orders from</value>
    [DataMember(Name="order_channel_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "order_channel_id")]
    public string OrderChannelId { get; set; }

    /// <summary>
    /// Run the import asyncronously, default is false unless importing more than one order or from more than one order channel
    /// </summary>
    /// <value>Run the import asyncronously, default is false unless importing more than one order or from more than one order channel</value>
    [DataMember(Name="async", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "async")]
    public string Async { get; set; }

    /// <summary>
    /// Reimport orders from the order channel. WARNING: This will overwrite any changes to the order made in Webshipper and import the order as it is in the order channel
    /// </summary>
    /// <value>Reimport orders from the order channel. WARNING: This will overwrite any changes to the order made in Webshipper and import the order as it is in the order channel</value>
    [DataMember(Name="reimport", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reimport")]
    public string Reimport { get; set; }

    /// <summary>
    /// Time from when orders should be imported, all orders after this time is imported from the order channel. This option is not supported by all order channels and there might be some limitations depending on the order channel
    /// </summary>
    /// <value>Time from when orders should be imported, all orders after this time is imported from the order channel. This option is not supported by all order channels and there might be some limitations depending on the order channel</value>
    [DataMember(Name="time_start", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "time_start")]
    public string TimeStart { get; set; }

    /// <summary>
    /// Time to when orders should be imported, all orders before this time is imported from the order channel. This option is not supported by all order channels and there might be some limitations depending on the order channel
    /// </summary>
    /// <value>Time to when orders should be imported, all orders before this time is imported from the order channel. This option is not supported by all order channels and there might be some limitations depending on the order channel</value>
    [DataMember(Name="time_end", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "time_end")]
    public string TimeEnd { get; set; }

    /// <summary>
    /// Statuses of orders to import, all orders with the given statuses are imported from the order channel. This option is not supported by all order channels and there might be some limitations depending on the order channel
    /// </summary>
    /// <value>Statuses of orders to import, all orders with the given statuses are imported from the order channel. This option is not supported by all order channels and there might be some limitations depending on the order channel</value>
    [DataMember(Name="statuses", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "statuses")]
    public string Statuses { get; set; }

    /// <summary>
    /// List of bulk imports with the same attributes as above. This can be used to import multiple orders from multiple order channels at once. Options specified in the root object is used globally, but is overridable by specififying the option for specific bulk_import in the list.
    /// </summary>
    /// <value>List of bulk imports with the same attributes as above. This can be used to import multiple orders from multiple order channels at once. Options specified in the root object is used globally, but is overridable by specififying the option for specific bulk_import in the list.</value>
    [DataMember(Name="bulk_imports", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bulk_imports")]
    public string BulkImports { get; set; }

    /// <summary>
    /// Source of the orders to import. This will default to API
    /// </summary>
    /// <value>Source of the orders to import. This will default to API</value>
    [DataMember(Name="source", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "source")]
    public string Source { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class BulkImportOrders {\n");
      sb.Append("  Ids: ").Append(Ids).Append("\n");
      sb.Append("  OrderChannelId: ").Append(OrderChannelId).Append("\n");
      sb.Append("  Async: ").Append(Async).Append("\n");
      sb.Append("  Reimport: ").Append(Reimport).Append("\n");
      sb.Append("  TimeStart: ").Append(TimeStart).Append("\n");
      sb.Append("  TimeEnd: ").Append(TimeEnd).Append("\n");
      sb.Append("  Statuses: ").Append(Statuses).Append("\n");
      sb.Append("  BulkImports: ").Append(BulkImports).Append("\n");
      sb.Append("  Source: ").Append(Source).Append("\n");
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
