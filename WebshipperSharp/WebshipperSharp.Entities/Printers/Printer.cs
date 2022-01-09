using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace WebshipperSharp.Entities.Printers
{

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class Printer
    {
        /// <summary>
        /// Name of the printer.
        /// </summary>
        /// <value>Name of the printer.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "name")]
        public string? Name { get; set; }

        /// <summary>
        /// Determines if the printer is configured on the printer station
        /// </summary>
        /// <value>Determines if the printer is configured on the printer station</value>
        [DataMember(Name = "active", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "active")]
        public bool? Active { get; set; }

        /// <summary>
        /// Last connection time
        /// </summary>
        /// <value>Last connection time</value>
        [DataMember(Name = "last_connected", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "last_connected")]
        public string? LastConnected { get; set; }

        /// <summary>
        /// Paper width
        /// </summary>
        /// <value>Paper width</value>
        [DataMember(Name = "paper_width", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "paper_width")]
        public decimal? PaperWidth { get; set; }

        /// <summary>
        /// Paper height
        /// </summary>
        /// <value>Paper height</value>
        [DataMember(Name = "paper_height", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "paper_height")]
        public decimal? PaperHeight { get; set; }

        /// <summary>
        /// Gets or Sets RotatePrint180
        /// </summary>
        [DataMember(Name = "rotate_print_180", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "rotate_print_180")]
        public bool? RotatePrint180 { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Printers {\n");
            sb.Append("  Name: ").Append(Name).Append('\n');
            sb.Append("  Active: ").Append(Active).Append('\n');
            sb.Append("  LastConnected: ").Append(LastConnected).Append('\n');
            sb.Append("  PaperWidth: ").Append(PaperWidth).Append('\n');
            sb.Append("  PaperHeight: ").Append(PaperHeight).Append('\n');
            sb.Append("  RotatePrint180: ").Append(RotatePrint180).Append('\n');
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
