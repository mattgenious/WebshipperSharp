# IO.Swagger.Api.TriggerApi

All URIs are relative to *https://{tenant}.api.webshipper.io/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**TriggersGet**](TriggerApi.md#triggersget) | **GET** /triggers | List all Triggers
[**TriggersIdDelete**](TriggerApi.md#triggersiddelete) | **DELETE** /triggers/{id} | Delete a Trigger
[**TriggersIdGet**](TriggerApi.md#triggersidget) | **GET** /triggers/{id} | Show a single Trigger
[**TriggersIdPatch**](TriggerApi.md#triggersidpatch) | **PATCH** /triggers/{id} | Update a Trigger
[**TriggersPost**](TriggerApi.md#triggerspost) | **POST** /triggers | Create a Trigger

<a name="triggersget"></a>
# **TriggersGet**
> InlineResponse200119 TriggersGet (string filterId)

List all Triggers

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TriggersGetExample
    {
        public void main()
        {


            var apiInstance = new TriggerApi();
            var filterId = filterId_example;  // string | Filter by id (optional) 

            try
            {
                // List all Triggers
                InlineResponse200119 result = apiInstance.TriggersGet(filterId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TriggerApi.TriggersGet: " + e.Message );
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

[**InlineResponse200119**](InlineResponse200119.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="triggersiddelete"></a>
# **TriggersIdDelete**
> InlineResponse200118 TriggersIdDelete (int? id)

Delete a Trigger

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TriggersIdDeleteExample
    {
        public void main()
        {


            var apiInstance = new TriggerApi();
            var id = 56;  // int? | 

            try
            {
                // Delete a Trigger
                InlineResponse200118 result = apiInstance.TriggersIdDelete(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TriggerApi.TriggersIdDelete: " + e.Message );
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

[**InlineResponse200118**](InlineResponse200118.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="triggersidget"></a>
# **TriggersIdGet**
> InlineResponse200118 TriggersIdGet (int? id)

Show a single Trigger

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TriggersIdGetExample
    {
        public void main()
        {


            var apiInstance = new TriggerApi();
            var id = 56;  // int? | 

            try
            {
                // Show a single Trigger
                InlineResponse200118 result = apiInstance.TriggersIdGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TriggerApi.TriggersIdGet: " + e.Message );
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

[**InlineResponse200118**](InlineResponse200118.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="triggersidpatch"></a>
# **TriggersIdPatch**
> InlineResponse200118 TriggersIdPatch (TriggersIdBody body, int? id)

Update a Trigger

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TriggersIdPatchExample
    {
        public void main()
        {


            var apiInstance = new TriggerApi();
            var body = new TriggersIdBody(); // TriggersIdBody | 
            var id = 56;  // int? | 

            try
            {
                // Update a Trigger
                InlineResponse200118 result = apiInstance.TriggersIdPatch(body, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TriggerApi.TriggersIdPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**TriggersIdBody**](TriggersIdBody.md)|  | 
 **id** | **int?**|  | 

### Return type

[**InlineResponse200118**](InlineResponse200118.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="triggerspost"></a>
# **TriggersPost**
> InlineResponse200118 TriggersPost (TriggersBody body)

Create a Trigger

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TriggersPostExample
    {
        public void main()
        {


            var apiInstance = new TriggerApi();
            var body = new TriggersBody(); // TriggersBody | 

            try
            {
                // Create a Trigger
                InlineResponse200118 result = apiInstance.TriggersPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TriggerApi.TriggersPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**TriggersBody**](TriggersBody.md)|  | 

### Return type

[**InlineResponse200118**](InlineResponse200118.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

