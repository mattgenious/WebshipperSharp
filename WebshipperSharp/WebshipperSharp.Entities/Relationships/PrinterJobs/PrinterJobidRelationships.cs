using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using WebshipperSharp.Entities.Relationships.Orders;
using WebshipperSharp.Entities.Relationships.PrinterClients;

namespace WebshipperSharp.Entities.Relationships.PrinterJobs
{

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class PrinterJobidRelationships
    {
        /// <summary>
        /// Gets or Sets PrinterClient
        /// </summary>
        [DataMember(Name = "printer_client", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "printer_client")]
        public OrdersidRelationshipsPrinterClient? PrinterClient { get; set; }

        /// <summary>
        /// Gets or Sets Printer
        /// </summary>
        [DataMember(Name = "printer", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "printer")]
        public PrinterClientidRelationshipsLabelPrinter? Printer { get; set; }

        /// <summary>
        /// Gets or Sets Printable
        /// </summary>
        [DataMember(Name = "printable", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "printable")]
        public PrinterJobidRelationshipsPrintable? Printable { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PrinterJobidRelationships {\n");
            sb.Append("  PrinterClient: ").Append(PrinterClient).Append('\n');
            sb.Append("  Printer: ").Append(Printer).Append('\n');
            sb.Append("  Printable: ").Append(Printable).Append('\n');
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
