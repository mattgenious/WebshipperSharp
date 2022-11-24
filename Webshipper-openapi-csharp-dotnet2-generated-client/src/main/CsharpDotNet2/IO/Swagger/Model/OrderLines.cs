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
  public class OrderLines {
    /// <summary>
    /// Stock Keeping Unit of the order line
    /// </summary>
    /// <value>Stock Keeping Unit of the order line</value>
    [DataMember(Name="sku", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sku")]
    public string Sku { get; set; }

    /// <summary>
    /// Description of the goods
    /// </summary>
    /// <value>Description of the goods</value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// Quantity of goods
    /// </summary>
    /// <value>Quantity of goods</value>
    [DataMember(Name="quantity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "quantity")]
    public int? Quantity { get; set; }

    /// <summary>
    /// The warehouse location of the items.
    /// </summary>
    /// <value>The warehouse location of the items.</value>
    [DataMember(Name="location", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "location")]
    public string Location { get; set; }

    /// <summary>
    /// HS Tarif code for paperless customs
    /// </summary>
    /// <value>HS Tarif code for paperless customs</value>
    [DataMember(Name="tarif_number", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tarif_number")]
    public string TarifNumber { get; set; }

    /// <summary>
    /// The country of origin of the goods.
    /// </summary>
    /// <value>The country of origin of the goods.</value>
    [DataMember(Name="country_of_origin", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "country_of_origin")]
    public string CountryOfOrigin { get; set; }

    /// <summary>
    /// The unit price of goods in the currency of the order
    /// </summary>
    /// <value>The unit price of goods in the currency of the order</value>
    [DataMember(Name="unit_price", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "unit_price")]
    public decimal? UnitPrice { get; set; }

    /// <summary>
    /// Whether the items are associated with a parcel of a shipment.
    /// </summary>
    /// <value>Whether the items are associated with a parcel of a shipment.</value>
    [DataMember(Name="package_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "package_id")]
    public int? PackageId { get; set; }

    /// <summary>
    /// The unit price after discounts has been applied in the currency of the order
    /// </summary>
    /// <value>The unit price after discounts has been applied in the currency of the order</value>
    [DataMember(Name="discounted_unit_price", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "discounted_unit_price")]
    public string DiscountedUnitPrice { get; set; }

    /// <summary>
    /// The discount for the order line, in the type given by discount_type
    /// </summary>
    /// <value>The discount for the order line, in the type given by discount_type</value>
    [DataMember(Name="discount_value", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "discount_value")]
    public decimal? DiscountValue { get; set; }

    /// <summary>
    /// The type of discount, eg. percent or fixed
    /// </summary>
    /// <value>The type of discount, eg. percent or fixed</value>
    [DataMember(Name="discount_type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "discount_type")]
    public int? DiscountType { get; set; }

    /// <summary>
    /// The VAT rate in percentage.
    /// </summary>
    /// <value>The VAT rate in percentage.</value>
    [DataMember(Name="vat_percent", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "vat_percent")]
    public decimal? VatPercent { get; set; }

    /// <summary>
    /// Gets or Sets OrderId
    /// </summary>
    [DataMember(Name="order_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "order_id")]
    public int? OrderId { get; set; }

    /// <summary>
    /// Possible enum values: pending, dispatched or returned
    /// </summary>
    /// <value>Possible enum values: pending, dispatched or returned</value>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public int? Status { get; set; }

    /// <summary>
    /// External reference of the order line.
    /// </summary>
    /// <value>External reference of the order line.</value>
    [DataMember(Name="ext_ref", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ext_ref")]
    public string ExtRef { get; set; }

    /// <summary>
    /// Weight per unit.
    /// </summary>
    /// <value>Weight per unit.</value>
    [DataMember(Name="weight", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "weight")]
    public decimal? Weight { get; set; }

    /// <summary>
    /// Weight unit. Possible values: <code>oz</code>, <code>g</code>, <code>lbs</code>, <code>kg</code>. Defaults to <code>g</code>
    /// </summary>
    /// <value>Weight unit. Possible values: <code>oz</code>, <code>g</code>, <code>lbs</code>, <code>kg</code>. Defaults to <code>g</code></value>
    [DataMember(Name="weight_unit", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "weight_unit")]
    public string WeightUnit { get; set; }

    /// <summary>
    /// The time when the resource was created
    /// </summary>
    /// <value>The time when the resource was created</value>
    [DataMember(Name="created_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "created_at")]
    public string CreatedAt { get; set; }

    /// <summary>
    /// The time when resource was last updated or when it was created if it was never updated
    /// </summary>
    /// <value>The time when resource was last updated or when it was created if it was never updated</value>
    [DataMember(Name="updated_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "updated_at")]
    public string UpdatedAt { get; set; }

    /// <summary>
    /// Gets or Sets IsVirtual
    /// </summary>
    [DataMember(Name="is_virtual", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "is_virtual")]
    public bool? IsVirtual { get; set; }

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
      sb.Append("class OrderLines {\n");
      sb.Append("  Sku: ").Append(Sku).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  Quantity: ").Append(Quantity).Append("\n");
      sb.Append("  Location: ").Append(Location).Append("\n");
      sb.Append("  TarifNumber: ").Append(TarifNumber).Append("\n");
      sb.Append("  CountryOfOrigin: ").Append(CountryOfOrigin).Append("\n");
      sb.Append("  UnitPrice: ").Append(UnitPrice).Append("\n");
      sb.Append("  PackageId: ").Append(PackageId).Append("\n");
      sb.Append("  DiscountedUnitPrice: ").Append(DiscountedUnitPrice).Append("\n");
      sb.Append("  DiscountValue: ").Append(DiscountValue).Append("\n");
      sb.Append("  DiscountType: ").Append(DiscountType).Append("\n");
      sb.Append("  VatPercent: ").Append(VatPercent).Append("\n");
      sb.Append("  OrderId: ").Append(OrderId).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  ExtRef: ").Append(ExtRef).Append("\n");
      sb.Append("  Weight: ").Append(Weight).Append("\n");
      sb.Append("  WeightUnit: ").Append(WeightUnit).Append("\n");
      sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
      sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
      sb.Append("  IsVirtual: ").Append(IsVirtual).Append("\n");
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
