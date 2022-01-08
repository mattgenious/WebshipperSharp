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
  public class Users {
    /// <summary>
    /// The user's first name.
    /// </summary>
    /// <value>The user's first name.</value>
    [DataMember(Name="first_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "first_name")]
    public string FirstName { get; set; }

    /// <summary>
    /// The user's last name.
    /// </summary>
    /// <value>The user's last name.</value>
    [DataMember(Name="last_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "last_name")]
    public string LastName { get; set; }

    /// <summary>
    /// The user's e-mail address.
    /// </summary>
    /// <value>The user's e-mail address.</value>
    [DataMember(Name="email", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "email")]
    public string Email { get; set; }

    /// <summary>
    /// The user's password. This can only be used for changing the password.
    /// </summary>
    /// <value>The user's password. This can only be used for changing the password.</value>
    [DataMember(Name="password", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "password")]
    public int? Password { get; set; }

    /// <summary>
    /// The time when resource was last updated or when it was created if it was never updated
    /// </summary>
    /// <value>The time when resource was last updated or when it was created if it was never updated</value>
    [DataMember(Name="updated_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "updated_at")]
    public string UpdatedAt { get; set; }

    /// <summary>
    /// The time when the resource was created
    /// </summary>
    /// <value>The time when the resource was created</value>
    [DataMember(Name="created_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "created_at")]
    public string CreatedAt { get; set; }

    /// <summary>
    /// The time of the most recent sign-in by the user.
    /// </summary>
    /// <value>The time of the most recent sign-in by the user.</value>
    [DataMember(Name="last_sign_in_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "last_sign_in_at")]
    public string LastSignInAt { get; set; }

    /// <summary>
    /// Specifies whether the user has access to all order channels on the tenant.
    /// </summary>
    /// <value>Specifies whether the user has access to all order channels on the tenant.</value>
    [DataMember(Name="all_order_channels", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "all_order_channels")]
    public bool? AllOrderChannels { get; set; }

    /// <summary>
    /// Specifies whether the user has access to all of the carriers for tenant.
    /// </summary>
    /// <value>Specifies whether the user has access to all of the carriers for tenant.</value>
    [DataMember(Name="all_carriers", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "all_carriers")]
    public bool? AllCarriers { get; set; }

    /// <summary>
    /// Specifies whether the user should be hidden in the user interface.
    /// </summary>
    /// <value>Specifies whether the user should be hidden in the user interface.</value>
    [DataMember(Name="hidden", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hidden")]
    public bool? Hidden { get; set; }

    /// <summary>
    /// This must be set when changing the password of the user.
    /// </summary>
    /// <value>This must be set when changing the password of the user.</value>
    [DataMember(Name="current_password", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "current_password")]
    public string CurrentPassword { get; set; }

    /// <summary>
    /// Locale enum. <code>da</code> or <code>en</code>
    /// </summary>
    /// <value>Locale enum. <code>da</code> or <code>en</code></value>
    [DataMember(Name="locale", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "locale")]
    public int? Locale { get; set; }

    /// <summary>
    /// Locked until specified datetime
    /// </summary>
    /// <value>Locked until specified datetime</value>
    [DataMember(Name="locked_until", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "locked_until")]
    public string LockedUntil { get; set; }

    /// <summary>
    /// Amount of failed login attempts since last login
    /// </summary>
    /// <value>Amount of failed login attempts since last login</value>
    [DataMember(Name="failed_count", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "failed_count")]
    public int? FailedCount { get; set; }

    /// <summary>
    /// Read only. Will be true when the user is temporarily locked due to too many login attempts
    /// </summary>
    /// <value>Read only. Will be true when the user is temporarily locked due to too many login attempts</value>
    [DataMember(Name="is_locked", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "is_locked")]
    public string IsLocked { get; set; }

    /// <summary>
    /// Gets or Sets UserStatus
    /// </summary>
    [DataMember(Name="user_status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "user_status")]
    public int? UserStatus { get; set; }

    /// <summary>
    /// The home page set by the user
    /// </summary>
    /// <value>The home page set by the user</value>
    [DataMember(Name="home_page", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "home_page")]
    public string HomePage { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Users {\n");
      sb.Append("  FirstName: ").Append(FirstName).Append("\n");
      sb.Append("  LastName: ").Append(LastName).Append("\n");
      sb.Append("  Email: ").Append(Email).Append("\n");
      sb.Append("  Password: ").Append(Password).Append("\n");
      sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
      sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
      sb.Append("  LastSignInAt: ").Append(LastSignInAt).Append("\n");
      sb.Append("  AllOrderChannels: ").Append(AllOrderChannels).Append("\n");
      sb.Append("  AllCarriers: ").Append(AllCarriers).Append("\n");
      sb.Append("  Hidden: ").Append(Hidden).Append("\n");
      sb.Append("  CurrentPassword: ").Append(CurrentPassword).Append("\n");
      sb.Append("  Locale: ").Append(Locale).Append("\n");
      sb.Append("  LockedUntil: ").Append(LockedUntil).Append("\n");
      sb.Append("  FailedCount: ").Append(FailedCount).Append("\n");
      sb.Append("  IsLocked: ").Append(IsLocked).Append("\n");
      sb.Append("  UserStatus: ").Append(UserStatus).Append("\n");
      sb.Append("  HomePage: ").Append(HomePage).Append("\n");
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
