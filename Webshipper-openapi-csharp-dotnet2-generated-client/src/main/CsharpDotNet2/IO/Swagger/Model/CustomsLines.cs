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
  public class CustomsLines {
    /// <summary>
    /// Stock Keeping Unit
    /// </summary>
    /// <value>Stock Keeping Unit</value>
    [DataMember(Name="sku", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sku")]
    public string Sku { get; set; }

    /// <summary>
    /// Goods description
    /// </summary>
    /// <value>Goods description</value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// Quantity of the customs line
    /// </summary>
    /// <value>Quantity of the customs line</value>
    [DataMember(Name="quantity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "quantity")]
    public int? Quantity { get; set; }

    /// <summary>
    /// Tariff number / HS code
    /// </summary>
    /// <value>Tariff number / HS code</value>
    [DataMember(Name="tarif_number", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tarif_number")]
    public string TarifNumber { get; set; }

    /// <summary>
    /// Country of origin of the customs line - ISO 3166-1 alpha-2
    /// </summary>
    /// <value>Country of origin of the customs line - ISO 3166-1 alpha-2</value>
    [DataMember(Name="country_of_origin", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "country_of_origin")]
    public string CountryOfOrigin { get; set; }

    /// <summary>
    /// Unit price of a single quantity customs line
    /// </summary>
    /// <value>Unit price of a single quantity customs line</value>
    [DataMember(Name="unit_price", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "unit_price")]
    public decimal? UnitPrice { get; set; }

    /// <summary>
    /// Vat percent of the customs line
    /// </summary>
    /// <value>Vat percent of the customs line</value>
    [DataMember(Name="vat_percent", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "vat_percent")]
    public decimal? VatPercent { get; set; }

    /// <summary>
    /// Currency ISO-4217
    /// </summary>
    /// <value>Currency ISO-4217</value>
    [DataMember(Name="currency", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "currency")]
    public string Currency { get; set; }

    /// <summary>
    /// Weight of a single quantity customs line
    /// </summary>
    /// <value>Weight of a single quantity customs line</value>
    [DataMember(Name="weight", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "weight")]
    public decimal? Weight { get; set; }

    /// <summary>
    /// Weight unit of the customs line - One of 'g', 'oz', 'lbs' or 'kg'
    /// </summary>
    /// <value>Weight unit of the customs line - One of 'g', 'oz', 'lbs' or 'kg'</value>
    [DataMember(Name="weight_unit", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "weight_unit")]
    public int? WeightUnit { get; set; }

    /// <summary>
    /// Discount of a single quantity customs line
    /// </summary>
    /// <value>Discount of a single quantity customs line</value>
    [DataMember(Name="discount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "discount")]
    public decimal? Discount { get; set; }

    /// <summary>
    /// Optional object of key value pairs used for providing information of dangerous goods. For use with DGOffice, use keys: article_no, package_type_id and packaging_instruction_type.
    /// </summary>
    /// <value>Optional object of key value pairs used for providing information of dangerous goods. For use with DGOffice, use keys: article_no, package_type_id and packaging_instruction_type.</value>
    [DataMember(Name="dangerous_goods_details", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dangerous_goods_details")]
    public Object DangerousGoodsDetails { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CustomsLines {\n");
      sb.Append("  Sku: ").Append(Sku).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  Quantity: ").Append(Quantity).Append("\n");
      sb.Append("  TarifNumber: ").Append(TarifNumber).Append("\n");
      sb.Append("  CountryOfOrigin: ").Append(CountryOfOrigin).Append("\n");
      sb.Append("  UnitPrice: ").Append(UnitPrice).Append("\n");
      sb.Append("  VatPercent: ").Append(VatPercent).Append("\n");
      sb.Append("  Currency: ").Append(Currency).Append("\n");
      sb.Append("  Weight: ").Append(Weight).Append("\n");
      sb.Append("  WeightUnit: ").Append(WeightUnit).Append("\n");
      sb.Append("  Discount: ").Append(Discount).Append("\n");
      sb.Append("  DangerousGoodsDetails: ").Append(DangerousGoodsDetails).Append("\n");
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
