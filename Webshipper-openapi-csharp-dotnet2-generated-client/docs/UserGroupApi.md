# IO.Swagger.Api.UserGroupApi

All URIs are relative to *https://{tenant}.api.webshipper.io/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**UserGroupsGet**](UserGroupApi.md#usergroupsget) | **GET** /user_groups | List all User Groups
[**UserGroupsIdDelete**](UserGroupApi.md#usergroupsiddelete) | **DELETE** /user_groups/{id} | Delete a User Group
[**UserGroupsIdGet**](UserGroupApi.md#usergroupsidget) | **GET** /user_groups/{id} | Show a single User Group
[**UserGroupsIdPatch**](UserGroupApi.md#usergroupsidpatch) | **PATCH** /user_groups/{id} | Update a User Group
[**UserGroupsPost**](UserGroupApi.md#usergroupspost) | **POST** /user_groups | Create a User Group

<a name="usergroupsget"></a>
# **UserGroupsGet**
> InlineResponse200123 UserGroupsGet (string filterId)

List all User Groups

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UserGroupsGetExample
    {
        public void main()
        {


            var apiInstance = new UserGroupApi();
            var filterId = filterId_example;  // string | Filter by id (optional) 

            try
            {
                // List all User Groups
                InlineResponse200123 result = apiInstance.UserGroupsGet(filterId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserGroupApi.UserGroupsGet: " + e.Message );
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

[**InlineResponse200123**](InlineResponse200123.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usergroupsiddelete"></a>
# **UserGroupsIdDelete**
> InlineResponse200122 UserGroupsIdDelete (int? id)

Delete a User Group

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UserGroupsIdDeleteExample
    {
        public void main()
        {


            var apiInstance = new UserGroupApi();
            var id = 56;  // int? | 

            try
            {
                // Delete a User Group
                InlineResponse200122 result = apiInstance.UserGroupsIdDelete(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserGroupApi.UserGroupsIdDelete: " + e.Message );
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

[**InlineResponse200122**](InlineResponse200122.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usergroupsidget"></a>
# **UserGroupsIdGet**
> InlineResponse200122 UserGroupsIdGet (int? id)

Show a single User Group

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UserGroupsIdGetExample
    {
        public void main()
        {


            var apiInstance = new UserGroupApi();
            var id = 56;  // int? | 

            try
            {
                // Show a single User Group
                InlineResponse200122 result = apiInstance.UserGroupsIdGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserGroupApi.UserGroupsIdGet: " + e.Message );
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

[**InlineResponse200122**](InlineResponse200122.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usergroupsidpatch"></a>
# **UserGroupsIdPatch**
> InlineResponse200122 UserGroupsIdPatch (UserGroupsIdBody body, int? id)

Update a User Group

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UserGroupsIdPatchExample
    {
        public void main()
        {


            var apiInstance = new UserGroupApi();
            var body = new UserGroupsIdBody(); // UserGroupsIdBody | 
            var id = 56;  // int? | 

            try
            {
                // Update a User Group
                InlineResponse200122 result = apiInstance.UserGroupsIdPatch(body, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserGroupApi.UserGroupsIdPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UserGroupsIdBody**](UserGroupsIdBody.md)|  | 
 **id** | **int?**|  | 

### Return type

[**InlineResponse200122**](InlineResponse200122.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usergroupspost"></a>
# **UserGroupsPost**
> InlineResponse200122 UserGroupsPost (UserGroupsBody body)

Create a User Group

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UserGroupsPostExample
    {
        public void main()
        {


            var apiInstance = new UserGroupApi();
            var body = new UserGroupsBody(); // UserGroupsBody | 

            try
            {
                // Create a User Group
                InlineResponse200122 result = apiInstance.UserGroupsPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserGroupApi.UserGroupsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UserGroupsBody**](UserGroupsBody.md)|  | 

### Return type

[**InlineResponse200122**](InlineResponse200122.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

