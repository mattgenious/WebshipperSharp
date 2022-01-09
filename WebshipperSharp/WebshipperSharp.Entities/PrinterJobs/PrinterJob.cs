using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace WebshipperSharp.Entities.PrinterJobs
{

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class PrinterJob
    {
        /// <summary>
        /// The time when the resource was created
        /// </summary>
        /// <value>The time when the resource was created</value>
        [DataMember(Name = "created_at", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// The time when resource was last updated or when it was created if it was never updated
        /// </summary>
        /// <value>The time when resource was last updated or when it was created if it was never updated</value>
        [DataMember(Name = "updated_at", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "updated_at")]
        public string? UpdatedAt { get; set; }

        /// <summary>
        /// This will return as <code>true</code> when the printer client has accepted the job.
        /// </summary>
        /// <value>This will return as <code>true</code> when the printer client has accepted the job.</value>
        [DataMember(Name = "completed", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "completed")]
        public bool? Completed { get; set; }

        /// <summary>
        /// Any error message that resulted.
        /// </summary>
        /// <value>Any error message that resulted.</value>
        [DataMember(Name = "error", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "error")]
        public string? Error { get; set; }

        /// <summary>
        /// Base64 encoding if the associated printable, must the explicitly included in <em>fields</em> query parameter to be included
        /// </summary>
        /// <value>Base64 encoding if the associated printable, must the explicitly included in <em>fields</em> query parameter to be included</value>
        [DataMember(Name = "base64", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "base64")]
        public string? Base64 { get; set; }

        /// <summary>
        /// Gets or Sets TryCount
        /// </summary>
        [DataMember(Name = "try_count", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "try_count")]
        public int? TryCount { get; set; }

        /// <summary>
        /// Gets or Sets Initiator
        /// </summary>
        [DataMember(Name = "initiator", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "initiator")]
        public string? Initiator { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PrinterJob {\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append('\n');
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append('\n');
            sb.Append("  Completed: ").Append(Completed).Append('\n');
            sb.Append("  Error: ").Append(Error).Append('\n');
            sb.Append("  Base64: ").Append(Base64).Append('\n');
            sb.Append("  TryCount: ").Append(TryCount).Append('\n');
            sb.Append("  Initiator: ").Append(Initiator).Append('\n');
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
