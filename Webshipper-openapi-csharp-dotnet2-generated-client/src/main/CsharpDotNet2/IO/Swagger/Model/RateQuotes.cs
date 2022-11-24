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
  public class RateQuotes {
    /// <summary>
    /// Array of quotes
    /// </summary>
    /// <value>Array of quotes</value>
    [DataMember(Name="quotes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "quotes")]
    public List<RateQuotesItems> Quotes { get; set; }

    /// <summary>
    /// DEPRECATED. The request will return an error response if the quote failed.
    /// </summary>
    /// <value>DEPRECATED. The request will return an error response if the quote failed.</value>
    [DataMember(Name="success", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "success")]
    public string Success { get; set; }

    /// <summary>
    /// Delivery address for the quote. Flattened resource of 'Shipping Address'
    /// </summary>
    /// <value>Delivery address for the quote. Flattened resource of 'Shipping Address'</value>
    [DataMember(Name="delivery_address", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "delivery_address")]
    public Object DeliveryAddress { get; set; }

    /// <summary>
    /// The total price of the items
    /// </summary>
    /// <value>The total price of the items</value>
    [DataMember(Name="price", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "price")]
    public int? Price { get; set; }

    /// <summary>
    /// Weight for the quote.
    /// </summary>
    /// <value>Weight for the quote.</value>
    [DataMember(Name="weight", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "weight")]
    public int? Weight { get; set; }

    /// <summary>
    /// The weight unit. Possible values: g, kg, lbs, oz.
    /// </summary>
    /// <value>The weight unit. Possible values: g, kg, lbs, oz.</value>
    [DataMember(Name="weight_unit", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "weight_unit")]
    public string WeightUnit { get; set; }

    /// <summary>
    /// Height for the quote. The unit must match the unit you are using for shipping rate configurations.
    /// </summary>
    /// <value>Height for the quote. The unit must match the unit you are using for shipping rate configurations.</value>
    [DataMember(Name="height", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "height")]
    public int? Height { get; set; }

    /// <summary>
    /// Length for the quote. The unit must match the unit you are using for shipping rate configurations.
    /// </summary>
    /// <value>Length for the quote. The unit must match the unit you are using for shipping rate configurations.</value>
    [DataMember(Name="length", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "length")]
    public int? Length { get; set; }

    /// <summary>
    /// Width for the quote. The unit must match the unit you are using for shipping rate configurations.
    /// </summary>
    /// <value>Width for the quote. The unit must match the unit you are using for shipping rate configurations.</value>
    [DataMember(Name="width", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "width")]
    public int? Width { get; set; }

    /// <summary>
    /// Dimensions unit. Possible values: cm, m, in, ft
    /// </summary>
    /// <value>Dimensions unit. Possible values: cm, m, in, ft</value>
    [DataMember(Name="dimensions_unit", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dimensions_unit")]
    public string DimensionsUnit { get; set; }

    /// <summary>
    /// Delivery address for the quote. Flattened resource of 'Shipping Address'
    /// </summary>
    /// <value>Delivery address for the quote. Flattened resource of 'Shipping Address'</value>
    [DataMember(Name="sender_address", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sender_address")]
    public Object SenderAddress { get; set; }

    /// <summary>
    /// Array of items, each item should have fields <code>quantity</code>, <code>sku</code>, <code>description</code>
    /// </summary>
    /// <value>Array of items, each item should have fields <code>quantity</code>, <code>sku</code>, <code>description</code></value>
    [DataMember(Name="items", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "items")]
    public List<RateQuotesItems1> Items { get; set; }

    /// <summary>
    /// The id of the order channel for which to get shipping rates.
    /// </summary>
    /// <value>The id of the order channel for which to get shipping rates.</value>
    [DataMember(Name="order_channel_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "order_channel_id")]
    public int? OrderChannelId { get; set; }

    /// <summary>
    /// Also include shipping rates which are normally hidden during checkout.
    /// </summary>
    /// <value>Also include shipping rates which are normally hidden during checkout.</value>
    [DataMember(Name="include_hidden", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "include_hidden")]
    public bool? IncludeHidden { get; set; }

    /// <summary>
    /// Set to true to quote for return rates. If false standard rates are quoted. Default: false.
    /// </summary>
    /// <value>Set to true to quote for return rates. If false standard rates are quoted. Default: false.</value>
    [DataMember(Name="is_return", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "is_return")]
    public bool? IsReturn { get; set; }

    /// <summary>
    /// Possibility to add hash of additional attributes for filtering.
    /// </summary>
    /// <value>Possibility to add hash of additional attributes for filtering.</value>
    [DataMember(Name="additional_attributes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "additional_attributes")]
    public string AdditionalAttributes { get; set; }

    /// <summary>
    /// Gets or Sets FilterByCurrency
    /// </summary>
    [DataMember(Name="filter_by_currency", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "filter_by_currency")]
    public string FilterByCurrency { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class RateQuotes {\n");
      sb.Append("  Quotes: ").Append(Quotes).Append("\n");
      sb.Append("  Success: ").Append(Success).Append("\n");
      sb.Append("  DeliveryAddress: ").Append(DeliveryAddress).Append("\n");
      sb.Append("  Price: ").Append(Price).Append("\n");
      sb.Append("  Weight: ").Append(Weight).Append("\n");
      sb.Append("  WeightUnit: ").Append(WeightUnit).Append("\n");
      sb.Append("  Height: ").Append(Height).Append("\n");
      sb.Append("  Length: ").Append(Length).Append("\n");
      sb.Append("  Width: ").Append(Width).Append("\n");
      sb.Append("  DimensionsUnit: ").Append(DimensionsUnit).Append("\n");
      sb.Append("  SenderAddress: ").Append(SenderAddress).Append("\n");
      sb.Append("  Items: ").Append(Items).Append("\n");
      sb.Append("  OrderChannelId: ").Append(OrderChannelId).Append("\n");
      sb.Append("  IncludeHidden: ").Append(IncludeHidden).Append("\n");
      sb.Append("  IsReturn: ").Append(IsReturn).Append("\n");
      sb.Append("  AdditionalAttributes: ").Append(AdditionalAttributes).Append("\n");
      sb.Append("  FilterByCurrency: ").Append(FilterByCurrency).Append("\n");
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
