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
  public class DropPoints {
    /// <summary>
    /// The carriers ID of the drop point.
    /// </summary>
    /// <value>The carriers ID of the drop point.</value>
    [DataMember(Name="drop_point_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "drop_point_id")]
    public string DropPointId { get; set; }

    /// <summary>
    /// Name of the drop point
    /// </summary>
    /// <value>Name of the drop point</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Address line 1 of the drop point
    /// </summary>
    /// <value>Address line 1 of the drop point</value>
    [DataMember(Name="address_1", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "address_1")]
    public string Address1 { get; set; }

    /// <summary>
    /// Address line 2 of the drop point
    /// </summary>
    /// <value>Address line 2 of the drop point</value>
    [DataMember(Name="address_2", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "address_2")]
    public string Address2 { get; set; }

    /// <summary>
    /// Zip code for the drop point
    /// </summary>
    /// <value>Zip code for the drop point</value>
    [DataMember(Name="zip", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "zip")]
    public string Zip { get; set; }

    /// <summary>
    /// City for the drop point
    /// </summary>
    /// <value>City for the drop point</value>
    [DataMember(Name="city", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "city")]
    public string City { get; set; }

    /// <summary>
    /// Country Code for the drop point. ISO 3166-1 Alfa 2 
    /// </summary>
    /// <value>Country Code for the drop point. ISO 3166-1 Alfa 2 </value>
    [DataMember(Name="country_code", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "country_code")]
    public string CountryCode { get; set; }

    /// <summary>
    /// State code. ISO 3166-2 Alfa 2
    /// </summary>
    /// <value>State code. ISO 3166-2 Alfa 2</value>
    [DataMember(Name="state", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "state")]
    public string State { get; set; }

    /// <summary>
    /// Phone of the drop point
    /// </summary>
    /// <value>Phone of the drop point</value>
    [DataMember(Name="phone", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "phone")]
    public string Phone { get; set; }

    /// <summary>
    /// Text base code to identify the carrier of the drop point ( not mandatory )
    /// </summary>
    /// <value>Text base code to identify the carrier of the drop point ( not mandatory )</value>
    [DataMember(Name="carrier_code", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "carrier_code")]
    public string CarrierCode { get; set; }

    /// <summary>
    /// Routing code for the drop point.
    /// </summary>
    /// <value>Routing code for the drop point.</value>
    [DataMember(Name="routing_code", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "routing_code")]
    public string RoutingCode { get; set; }

    /// <summary>
    /// Longitude
    /// </summary>
    /// <value>Longitude</value>
    [DataMember(Name="longitude", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "longitude")]
    public string Longitude { get; set; }

    /// <summary>
    /// Latitude
    /// </summary>
    /// <value>Latitude</value>
    [DataMember(Name="latitude", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "latitude")]
    public string Latitude { get; set; }

    /// <summary>
    /// The time when the resource was created
    /// </summary>
    /// <value>The time when the resource was created</value>
    [DataMember(Name="created_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "created_at")]
    public string CreatedAt { get; set; }

    /// <summary>
    /// The time when resource was last updated or when it was created if it was never updated
    /// </summary>
    /// <value>The time when resource was last updated or when it was created if it was never updated</value>
    [DataMember(Name="updated_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "updated_at")]
    public string UpdatedAt { get; set; }

    /// <summary>
    /// Opening hours for the drop point. Days are 0-indexed, starting with Monday as 0
    /// </summary>
    /// <value>Opening hours for the drop point. Days are 0-indexed, starting with Monday as 0</value>
    [DataMember(Name="opening_hours", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "opening_hours")]
    public string OpeningHours { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DropPoints {\n");
      sb.Append("  DropPointId: ").Append(DropPointId).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Address1: ").Append(Address1).Append("\n");
      sb.Append("  Address2: ").Append(Address2).Append("\n");
      sb.Append("  Zip: ").Append(Zip).Append("\n");
      sb.Append("  City: ").Append(City).Append("\n");
      sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
      sb.Append("  State: ").Append(State).Append("\n");
      sb.Append("  Phone: ").Append(Phone).Append("\n");
      sb.Append("  CarrierCode: ").Append(CarrierCode).Append("\n");
      sb.Append("  RoutingCode: ").Append(RoutingCode).Append("\n");
      sb.Append("  Longitude: ").Append(Longitude).Append("\n");
      sb.Append("  Latitude: ").Append(Latitude).Append("\n");
      sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
      sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
      sb.Append("  OpeningHours: ").Append(OpeningHours).Append("\n");
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
