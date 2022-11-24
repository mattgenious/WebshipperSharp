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
  public class Packages {
    /// <summary>
    /// Weight of the package
    /// </summary>
    /// <value>Weight of the package</value>
    [DataMember(Name="weight", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "weight")]
    public decimal? Weight { get; set; }

    /// <summary>
    /// One of 'g', 'oz', 'lbs' and 'kg' 
    /// </summary>
    /// <value>One of 'g', 'oz', 'lbs' and 'kg' </value>
    [DataMember(Name="weight_unit", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "weight_unit")]
    public string WeightUnit { get; set; }

    /// <summary>
    /// Gets or Sets Dimensions
    /// </summary>
    [DataMember(Name="dimensions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dimensions")]
    public string Dimensions { get; set; }

    /// <summary>
    /// Gets or Sets ServiceAttributes
    /// </summary>
    [DataMember(Name="service_attributes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "service_attributes")]
    public string ServiceAttributes { get; set; }

    /// <summary>
    /// Gets or Sets AddOns
    /// </summary>
    [DataMember(Name="add_ons", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "add_ons")]
    public string AddOns { get; set; }

    /// <summary>
    /// Colli type of the package. Can be used to specify if the colli is a pallet, package, letter, etc. Should use values from the supported_colli_types field from the service quote/list response for the given service.
    /// </summary>
    /// <value>Colli type of the package. Can be used to specify if the colli is a pallet, package, letter, etc. Should use values from the supported_colli_types field from the service quote/list response for the given service.</value>
    [DataMember(Name="colli_type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "colli_type")]
    public string ColliType { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Packages {\n");
      sb.Append("  Weight: ").Append(Weight).Append("\n");
      sb.Append("  WeightUnit: ").Append(WeightUnit).Append("\n");
      sb.Append("  Dimensions: ").Append(Dimensions).Append("\n");
      sb.Append("  ServiceAttributes: ").Append(ServiceAttributes).Append("\n");
      sb.Append("  AddOns: ").Append(AddOns).Append("\n");
      sb.Append("  ColliType: ").Append(ColliType).Append("\n");
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
