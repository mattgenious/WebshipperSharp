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
  public class OauthAccessTokens {
    /// <summary>
    /// The scopes to which access is granted by the access token.
    /// </summary>
    /// <value>The scopes to which access is granted by the access token.</value>
    [DataMember(Name="scopes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "scopes")]
    public string Scopes { get; set; }

    /// <summary>
    /// The time when the resource was created
    /// </summary>
    /// <value>The time when the resource was created</value>
    [DataMember(Name="created_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "created_at")]
    public string CreatedAt { get; set; }

    /// <summary>
    /// Id of the owner
    /// </summary>
    /// <value>Id of the owner</value>
    [DataMember(Name="resource_owner_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "resource_owner_id")]
    public int? ResourceOwnerId { get; set; }

    /// <summary>
    /// Epoch timestamp of the expiration date for the token
    /// </summary>
    /// <value>Epoch timestamp of the expiration date for the token</value>
    [DataMember(Name="expires_in", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "expires_in")]
    public int? ExpiresIn { get; set; }

    /// <summary>
    /// Gets or Sets Expired
    /// </summary>
    [DataMember(Name="expired", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "expired")]
    public string Expired { get; set; }

    /// <summary>
    /// The access token
    /// </summary>
    /// <value>The access token</value>
    [DataMember(Name="token", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "token")]
    public string Token { get; set; }

    /// <summary>
    /// Datetime of the time the token was revoked - if revoked
    /// </summary>
    /// <value>Datetime of the time the token was revoked - if revoked</value>
    [DataMember(Name="revoked_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "revoked_at")]
    public string RevokedAt { get; set; }

    /// <summary>
    /// Gets or Sets ResourceOwner
    /// </summary>
    [DataMember(Name="resource_owner", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "resource_owner")]
    public string ResourceOwner { get; set; }

    /// <summary>
    /// Gets or Sets ApplicationId
    /// </summary>
    [DataMember(Name="application_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "application_id")]
    public int? ApplicationId { get; set; }

    /// <summary>
    /// The application to which this tokens grants access
    /// </summary>
    /// <value>The application to which this tokens grants access</value>
    [DataMember(Name="application", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "application")]
    public string Application { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class OauthAccessTokens {\n");
      sb.Append("  Scopes: ").Append(Scopes).Append("\n");
      sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
      sb.Append("  ResourceOwnerId: ").Append(ResourceOwnerId).Append("\n");
      sb.Append("  ExpiresIn: ").Append(ExpiresIn).Append("\n");
      sb.Append("  Expired: ").Append(Expired).Append("\n");
      sb.Append("  Token: ").Append(Token).Append("\n");
      sb.Append("  RevokedAt: ").Append(RevokedAt).Append("\n");
      sb.Append("  ResourceOwner: ").Append(ResourceOwner).Append("\n");
      sb.Append("  ApplicationId: ").Append(ApplicationId).Append("\n");
      sb.Append("  Application: ").Append(Application).Append("\n");
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
