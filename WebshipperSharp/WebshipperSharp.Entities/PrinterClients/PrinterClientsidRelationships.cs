using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using WebshipperSharp.Entities.Relationships.Carriers;

namespace WebshipperSharp.Entities.PrinterClients
{

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class PrinterClientsidRelationships
    {
        /// <summary>
        /// Gets or Sets LabelPrinter
        /// </summary>
        [DataMember(Name = "label_printer", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "label_printer")]
        public PrinterClientsidRelationshipsLabelPrinter? LabelPrinter { get; set; }

        /// <summary>
        /// Gets or Sets ZplPrinter
        /// </summary>
        [DataMember(Name = "zpl_printer", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "zpl_printer")]
        public PrinterClientsidRelationshipsLabelPrinter? ZplPrinter { get; set; }

        /// <summary>
        /// Gets or Sets DocumentPrinter
        /// </summary>
        [DataMember(Name = "document_printer", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "document_printer")]
        public PrinterClientsidRelationshipsLabelPrinter? DocumentPrinter { get; set; }

        /// <summary>
        /// Gets or Sets Location
        /// </summary>
        [DataMember(Name = "location", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "location")]
        public CarriersidRelationshipsSenderAddress? Location { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PrinterClientsidRelationships {\n");
            sb.Append("  LabelPrinter: ").Append(LabelPrinter).Append('\n');
            sb.Append("  ZplPrinter: ").Append(ZplPrinter).Append('\n');
            sb.Append("  DocumentPrinter: ").Append(DocumentPrinter).Append('\n');
            sb.Append("  Location: ").Append(Location).Append('\n');
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
