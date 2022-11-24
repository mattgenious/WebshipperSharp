using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using WebshipperSharp.Entities.Relationships.PrinterClients;

namespace WebshipperSharp.Entities.PrinterClients
{

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class PrinterClientIdBody
    {
        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name = "data", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "data")]
        public PrinterClientidData? Data { get; set; }

        /// <summary>
        /// Gets or Sets Relationships
        /// </summary>
        [DataMember(Name = "relationships", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "relationships")]
        public PrinterClientidRelationships? Relationships { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PrinterClientIdBody {\n");
            sb.Append("  Data: ").Append(Data).Append('\n');
            sb.Append("  Relationships: ").Append(Relationships).Append('\n');
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Get the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

    }
}
