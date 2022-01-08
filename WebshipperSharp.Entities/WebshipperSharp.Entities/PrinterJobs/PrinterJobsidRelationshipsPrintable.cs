using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace WebshipperSharp.Entities.PrinterJobs
{

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class PrinterJobsidRelationshipsPrintable
    {
        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name = "data", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "data")]
        public PrinterJobsidRelationshipsPrintableData? Data { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PrinterJobsidRelationshipsPrintable {\n");
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
