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
  public class Triggers {
    /// <summary>
    /// WEL expression for the trigger
    /// </summary>
    /// <value>WEL expression for the trigger</value>
    [DataMember(Name="expression", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "expression")]
    public string Expression { get; set; }

    /// <summary>
    /// Gets or Sets ExpressionAst
    /// </summary>
    [DataMember(Name="expression_ast", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "expression_ast")]
    public string ExpressionAst { get; set; }

    /// <summary>
    /// Model for the trigger. E.g. Order
    /// </summary>
    /// <value>Model for the trigger. E.g. Order</value>
    [DataMember(Name="model_type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "model_type")]
    public string ModelType { get; set; }

    /// <summary>
    /// <code>created</code> or <code>updated</code>
    /// </summary>
    /// <value><code>created</code> or <code>updated</code></value>
    [DataMember(Name="event", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "event")]
    public string _Event { get; set; }

    /// <summary>
    /// Gets or Sets Timing
    /// </summary>
    [DataMember(Name="timing", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "timing")]
    public int? Timing { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Triggers {\n");
      sb.Append("  Expression: ").Append(Expression).Append("\n");
      sb.Append("  ExpressionAst: ").Append(ExpressionAst).Append("\n");
      sb.Append("  ModelType: ").Append(ModelType).Append("\n");
      sb.Append("  _Event: ").Append(_Event).Append("\n");
      sb.Append("  Timing: ").Append(Timing).Append("\n");
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
