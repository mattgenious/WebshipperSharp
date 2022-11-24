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
  public class ShippingAddresses {
    /// <summary>
    /// Att person. To generate parcels either att_contact <strong>or</strong> company_name is required
    /// </summary>
    /// <value>Att person. To generate parcels either att_contact <strong>or</strong> company_name is required</value>
    [DataMember(Name="att_contact", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "att_contact")]
    public string AttContact { get; set; }

    /// <summary>
    /// Company name. To generate parcels either att_contact <strong>or</strong> company_name is required
    /// </summary>
    /// <value>Company name. To generate parcels either att_contact <strong>or</strong> company_name is required</value>
    [DataMember(Name="company_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "company_name")]
    public string CompanyName { get; set; }

    /// <summary>
    /// Address line 1
    /// </summary>
    /// <value>Address line 1</value>
    [DataMember(Name="address_1", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "address_1")]
    public string Address1 { get; set; }

    /// <summary>
    /// Address line 2
    /// </summary>
    /// <value>Address line 2</value>
    [DataMember(Name="address_2", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "address_2")]
    public string Address2 { get; set; }

    /// <summary>
    /// ISO 3166-1 alpha-2 code
    /// </summary>
    /// <value>ISO 3166-1 alpha-2 code</value>
    [DataMember(Name="country_code", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "country_code")]
    public string CountryCode { get; set; }

    /// <summary>
    /// Sub-division of country, if applicable. State code. ISO 3166-2 alpha-2
    /// </summary>
    /// <value>Sub-division of country, if applicable. State code. ISO 3166-2 alpha-2</value>
    [DataMember(Name="state", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "state")]
    public string State { get; set; }

    /// <summary>
    /// Phone number of the entity. This can be used for SMS notifications.
    /// </summary>
    /// <value>Phone number of the entity. This can be used for SMS notifications.</value>
    [DataMember(Name="phone", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "phone")]
    public string Phone { get; set; }

    /// <summary>
    /// E-mail address of the entity. This can be used for e-mail notifications.
    /// </summary>
    /// <value>E-mail address of the entity. This can be used for e-mail notifications.</value>
    [DataMember(Name="email", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "email")]
    public string Email { get; set; }

    /// <summary>
    /// Postal code of the entity. This is required for most destination countries.
    /// </summary>
    /// <value>Postal code of the entity. This is required for most destination countries.</value>
    [DataMember(Name="zip", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "zip")]
    public string Zip { get; set; }

    /// <summary>
    /// City of the entity. This is required for most destination countries.
    /// </summary>
    /// <value>City of the entity. This is required for most destination countries.</value>
    [DataMember(Name="city", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "city")]
    public string City { get; set; }

    /// <summary>
    /// The VAT number of the entity. This is only required for address_type <code>sold_from</code>
    /// </summary>
    /// <value>The VAT number of the entity. This is only required for address_type <code>sold_from</code></value>
    [DataMember(Name="vat_no", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "vat_no")]
    public string VatNo { get; set; }

    /// <summary>
    /// Used for special addresses for order channels. This will be one of the following: <code>recipient</code>, <code>sender</code>, <code>sold_from</code>, <code>pickup</code>, <code>return</code>, <code>order_address</code>
    /// </summary>
    /// <value>Used for special addresses for order channels. This will be one of the following: <code>recipient</code>, <code>sender</code>, <code>sold_from</code>, <code>pickup</code>, <code>return</code>, <code>order_address</code></value>
    [DataMember(Name="address_type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "address_type")]
    public string AddressType { get; set; }

    /// <summary>
    /// Gets or Sets ExtLocation
    /// </summary>
    [DataMember(Name="ext_location", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ext_location")]
    public string ExtLocation { get; set; }

    /// <summary>
    /// Gets or Sets Voec
    /// </summary>
    [DataMember(Name="voec", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "voec")]
    public string Voec { get; set; }

    /// <summary>
    /// Gets or Sets Eori
    /// </summary>
    [DataMember(Name="eori", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "eori")]
    public string Eori { get; set; }

    /// <summary>
    /// Gets or Sets Sprn
    /// </summary>
    [DataMember(Name="sprn", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sprn")]
    public string Sprn { get; set; }

    /// <summary>
    /// Gets or Sets PersonalCustomsNo
    /// </summary>
    [DataMember(Name="personal_customs_no", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "personal_customs_no")]
    public string PersonalCustomsNo { get; set; }

    /// <summary>
    /// Gets or Sets CompanyCustomsNumbers
    /// </summary>
    [DataMember(Name="company_customs_numbers", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "company_customs_numbers")]
    public string CompanyCustomsNumbers { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ShippingAddresses {\n");
      sb.Append("  AttContact: ").Append(AttContact).Append("\n");
      sb.Append("  CompanyName: ").Append(CompanyName).Append("\n");
      sb.Append("  Address1: ").Append(Address1).Append("\n");
      sb.Append("  Address2: ").Append(Address2).Append("\n");
      sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
      sb.Append("  State: ").Append(State).Append("\n");
      sb.Append("  Phone: ").Append(Phone).Append("\n");
      sb.Append("  Email: ").Append(Email).Append("\n");
      sb.Append("  Zip: ").Append(Zip).Append("\n");
      sb.Append("  City: ").Append(City).Append("\n");
      sb.Append("  VatNo: ").Append(VatNo).Append("\n");
      sb.Append("  AddressType: ").Append(AddressType).Append("\n");
      sb.Append("  ExtLocation: ").Append(ExtLocation).Append("\n");
      sb.Append("  Voec: ").Append(Voec).Append("\n");
      sb.Append("  Eori: ").Append(Eori).Append("\n");
      sb.Append("  Sprn: ").Append(Sprn).Append("\n");
      sb.Append("  PersonalCustomsNo: ").Append(PersonalCustomsNo).Append("\n");
      sb.Append("  CompanyCustomsNumbers: ").Append(CompanyCustomsNumbers).Append("\n");
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
