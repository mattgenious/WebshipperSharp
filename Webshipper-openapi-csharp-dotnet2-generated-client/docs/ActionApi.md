# IO.Swagger.Api.ActionApi

All URIs are relative to *https://{tenant}.api.webshipper.io/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ActionsGet**](ActionApi.md#actionsget) | **GET** /actions | List all Actions
[**ActionsIdDelete**](ActionApi.md#actionsiddelete) | **DELETE** /actions/{id} | Delete a Action
[**ActionsIdGet**](ActionApi.md#actionsidget) | **GET** /actions/{id} | Show a single Action
[**ActionsIdPatch**](ActionApi.md#actionsidpatch) | **PATCH** /actions/{id} | Update a Action
[**ActionsPost**](ActionApi.md#actionspost) | **POST** /actions | Create a Action

<a name="actionsget"></a>
# **ActionsGet**
> InlineResponse2005 ActionsGet (string filterId)

List all Actions

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ActionsGetExample
    {
        public void main()
        {


            var apiInstance = new ActionApi();
            var filterId = filterId_example;  // string | Filter by id (optional) 

            try
            {
                // List all Actions
                InlineResponse2005 result = apiInstance.ActionsGet(filterId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActionApi.ActionsGet: " + e.Message );
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

[**InlineResponse2005**](InlineResponse2005.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionsiddelete"></a>
# **ActionsIdDelete**
> InlineResponse2004 ActionsIdDelete (int? id)

Delete a Action

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ActionsIdDeleteExample
    {
        public void main()
        {


            var apiInstance = new ActionApi();
            var id = 56;  // int? | 

            try
            {
                // Delete a Action
                InlineResponse2004 result = apiInstance.ActionsIdDelete(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActionApi.ActionsIdDelete: " + e.Message );
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

[**InlineResponse2004**](InlineResponse2004.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionsidget"></a>
# **ActionsIdGet**
> InlineResponse2004 ActionsIdGet (int? id)

Show a single Action

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ActionsIdGetExample
    {
        public void main()
        {


            var apiInstance = new ActionApi();
            var id = 56;  // int? | 

            try
            {
                // Show a single Action
                InlineResponse2004 result = apiInstance.ActionsIdGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActionApi.ActionsIdGet: " + e.Message );
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

[**InlineResponse2004**](InlineResponse2004.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionsidpatch"></a>
# **ActionsIdPatch**
> InlineResponse2004 ActionsIdPatch (ActionsIdBody body, int? id)

Update a Action

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ActionsIdPatchExample
    {
        public void main()
        {


            var apiInstance = new ActionApi();
            var body = new ActionsIdBody(); // ActionsIdBody | 
            var id = 56;  // int? | 

            try
            {
                // Update a Action
                InlineResponse2004 result = apiInstance.ActionsIdPatch(body, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActionApi.ActionsIdPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ActionsIdBody**](ActionsIdBody.md)|  | 
 **id** | **int?**|  | 

### Return type

[**InlineResponse2004**](InlineResponse2004.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionspost"></a>
# **ActionsPost**
> InlineResponse2004 ActionsPost (ActionsBody body)

Create a Action

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ActionsPostExample
    {
        public void main()
        {


            var apiInstance = new ActionApi();
            var body = new ActionsBody(); // ActionsBody | 

            try
            {
                // Create a Action
                InlineResponse2004 result = apiInstance.ActionsPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActionApi.ActionsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ActionsBody**](ActionsBody.md)|  | 

### Return type

[**InlineResponse2004**](InlineResponse2004.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

