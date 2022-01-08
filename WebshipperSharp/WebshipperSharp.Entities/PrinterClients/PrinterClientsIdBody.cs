using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace WebshipperSharp.Entities.PrinterClients
{

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class PrinterClientsIdBody
    {
        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name = "data", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "data")]
        public PrinterClientsidData? Data { get; set; }

        /// <summary>
        /// Gets or Sets Relationships
        /// </summary>
        [DataMember(Name = "relationships", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "relationships")]
        public PrinterClientsidRelationships? Relationships { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PrinterClientsIdBody {\n");
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
