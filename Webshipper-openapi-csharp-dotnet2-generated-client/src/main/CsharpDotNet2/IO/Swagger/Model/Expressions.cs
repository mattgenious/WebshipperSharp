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
  public class Expressions {
    /// <summary>
    /// Is the actual WEL expression to be evaluated
    /// </summary>
    /// <value>Is the actual WEL expression to be evaluated</value>
    [DataMember(Name="expression", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "expression")]
    public string Expression { get; set; }

    /// <summary>
    /// VAT rate in percentage which must be added to the price.
    /// </summary>
    /// <value>VAT rate in percentage which must be added to the price.</value>
    [DataMember(Name="vat_percent", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "vat_percent")]
    public decimal? VatPercent { get; set; }

    /// <summary>
    /// Currency of the price
    /// </summary>
    /// <value>Currency of the price</value>
    [DataMember(Name="currency", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "currency")]
    public string Currency { get; set; }

    /// <summary>
    /// The cost price displayed to the end user
    /// </summary>
    /// <value>The cost price displayed to the end user</value>
    [DataMember(Name="price", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "price")]
    public decimal? Price { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Expressions {\n");
      sb.Append("  Expression: ").Append(Expression).Append("\n");
      sb.Append("  VatPercent: ").Append(VatPercent).Append("\n");
      sb.Append("  Currency: ").Append(Currency).Append("\n");
      sb.Append("  Price: ").Append(Price).Append("\n");
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
