using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace WebshipperSharp.Entities.PrinterClients
{

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class PrinterClientsidRelationshipsLabelPrinter
    {
        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name = "data", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "data")]
        public PrinterClientsidRelationshipsLabelPrinterData? Data { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PrinterClientsidRelationshipsLabelPrinter {\n");
            sb.Append("  Data: ").Append(Data).Append('\n');
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
