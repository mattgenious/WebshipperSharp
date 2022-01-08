# IO.Swagger.Api.UserApi

All URIs are relative to *https://{tenant}.api.webshipper.io/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**UsersGet**](UserApi.md#usersget) | **GET** /users | List all Users
[**UsersIdDelete**](UserApi.md#usersiddelete) | **DELETE** /users/{id} | Delete a User
[**UsersIdGet**](UserApi.md#usersidget) | **GET** /users/{id} | Show a single User
[**UsersIdPatch**](UserApi.md#usersidpatch) | **PATCH** /users/{id} | Update a User
[**UsersPost**](UserApi.md#userspost) | **POST** /users | Create a User

<a name="usersget"></a>
# **UsersGet**
> InlineResponse200121 UsersGet (string filterId)

List all Users

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UsersGetExample
    {
        public void main()
        {


            var apiInstance = new UserApi();
            var filterId = filterId_example;  // string | Filter by id (optional) 

            try
            {
                // List all Users
                InlineResponse200121 result = apiInstance.UsersGet(filterId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.UsersGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filterId** | **string**| Filter by id | [optional] 

### Return type

[**InlineResponse200121**](InlineResponse200121.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersiddelete"></a>
# **UsersIdDelete**
> InlineResponse200120 UsersIdDelete (int? id)

Delete a User

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UsersIdDeleteExample
    {
        public void main()
        {


            var apiInstance = new UserApi();
            var id = 56;  // int? | 

            try
            {
                // Delete a User
                InlineResponse200120 result = apiInstance.UsersIdDelete(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.UsersIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**|  | 

### Return type

[**InlineResponse200120**](InlineResponse200120.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersidget"></a>
# **UsersIdGet**
> InlineResponse200120 UsersIdGet (int? id)

Show a single User

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UsersIdGetExample
    {
        public void main()
        {


            var apiInstance = new UserApi();
            var id = 56;  // int? | 

            try
            {
                // Show a single User
                InlineResponse200120 result = apiInstance.UsersIdGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.UsersIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**|  | 

### Return type

[**InlineResponse200120**](InlineResponse200120.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersidpatch"></a>
# **UsersIdPatch**
> InlineResponse200120 UsersIdPatch (UsersIdBody body, int? id)

Update a User

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UsersIdPatchExample
    {
        public void main()
        {


            var apiInstance = new UserApi();
            var body = new UsersIdBody(); // UsersIdBody | 
            var id = 56;  // int? | 

            try
            {
                // Update a User
                InlineResponse200120 result = apiInstance.UsersIdPatch(body, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.UsersIdPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UsersIdBody**](UsersIdBody.md)|  | 
 **id** | **int?**|  | 

### Return type

[**InlineResponse200120**](InlineResponse200120.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="userspost"></a>
# **UsersPost**
> InlineResponse200120 UsersPost (UsersBody body)

Create a User

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UsersPostExample
    {
        public void main()
        {


            var apiInstance = new UserApi();
            var body = new UsersBody(); // UsersBody | 

            try
            {
                // Create a User
                InlineResponse200120 result = apiInstance.UsersPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.UsersPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UsersBody**](UsersBody.md)|  | 

### Return type

[**InlineResponse200120**](InlineResponse200120.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

