# IO.Swagger.Model.Users
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FirstName** | **string** | The user&#x27;s first name. | [optional] 
**LastName** | **string** | The user&#x27;s last name. | [optional] 
**Email** | **string** | The user&#x27;s e-mail address. | [optional] 
**Password** | **int?** | The user&#x27;s password. This can only be used for changing the password. | [optional] 
**UpdatedAt** | **string** | The time when resource was last updated or when it was created if it was never updated | [optional] 
**CreatedAt** | **string** | The time when the resource was created | [optional] 
**LastSignInAt** | **string** | The time of the most recent sign-in by the user. | [optional] 
**AllOrderChannels** | **bool?** | Specifies whether the user has access to all order channels on the tenant. | [optional] 
**AllCarriers** | **bool?** | Specifies whether the user has access to all of the carriers for tenant. | [optional] 
**Hidden** | **bool?** | Specifies whether the user should be hidden in the user interface. | [optional] 
**CurrentPassword** | **string** | This must be set when changing the password of the user. | [optional] 
**Locale** | **int?** | Locale enum. &lt;code&gt;da&lt;/code&gt; or &lt;code&gt;en&lt;/code&gt; | [optional] 
**LockedUntil** | **string** | Locked until specified datetime | [optional] 
**FailedCount** | **int?** | Amount of failed login attempts since last login | [optional] 
**IsLocked** | **string** | Read only. Will be true when the user is temporarily locked due to too many login attempts | [optional] 
**UserStatus** | **int?** |  | [optional] 
**HomePage** | **string** | The home page set by the user | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

