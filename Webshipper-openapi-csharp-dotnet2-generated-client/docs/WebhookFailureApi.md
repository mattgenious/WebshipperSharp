# IO.Swagger.Api.WebhookFailureApi

All URIs are relative to *https://{tenant}.api.webshipper.io/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**WebhookFailuresGet**](WebhookFailureApi.md#webhookfailuresget) | **GET** /webhook_failures | List all Webhook Failures
[**WebhookFailuresIdDelete**](WebhookFailureApi.md#webhookfailuresiddelete) | **DELETE** /webhook_failures/{id} | Delete a Webhook Failure
[**WebhookFailuresIdGet**](WebhookFailureApi.md#webhookfailuresidget) | **GET** /webhook_failures/{id} | Show a single Webhook Failure
[**WebhookFailuresIdPatch**](WebhookFailureApi.md#webhookfailuresidpatch) | **PATCH** /webhook_failures/{id} | Update a Webhook Failure
[**WebhookFailuresPost**](WebhookFailureApi.md#webhookfailurespost) | **POST** /webhook_failures | Create a Webhook Failure

<a name="webhookfailuresget"></a>
# **WebhookFailuresGet**
> InlineResponse200129 WebhookFailuresGet (string filterId)

List all Webhook Failures

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class WebhookFailuresGetExample
    {
        public void main()
        {


            var apiInstance = new WebhookFailureApi();
            var filterId = filterId_example;  // string | Filter by id (optional) 

            try
            {
                // List all Webhook Failures
                InlineResponse200129 result = apiInstance.WebhookFailuresGet(filterId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebhookFailureApi.WebhookFailuresGet: " + e.Message );
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

[**InlineResponse200129**](InlineResponse200129.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="webhookfailuresiddelete"></a>
# **WebhookFailuresIdDelete**
> InlineResponse200128 WebhookFailuresIdDelete (int? id)

Delete a Webhook Failure

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class WebhookFailuresIdDeleteExample
    {
        public void main()
        {


            var apiInstance = new WebhookFailureApi();
            var id = 56;  // int? | 

            try
            {
                // Delete a Webhook Failure
                InlineResponse200128 result = apiInstance.WebhookFailuresIdDelete(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebhookFailureApi.WebhookFailuresIdDelete: " + e.Message );
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

[**InlineResponse200128**](InlineResponse200128.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="webhookfailuresidget"></a>
# **WebhookFailuresIdGet**
> InlineResponse200128 WebhookFailuresIdGet (int? id)

Show a single Webhook Failure

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class WebhookFailuresIdGetExample
    {
        public void main()
        {


            var apiInstance = new WebhookFailureApi();
            var id = 56;  // int? | 

            try
            {
                // Show a single Webhook Failure
                InlineResponse200128 result = apiInstance.WebhookFailuresIdGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebhookFailureApi.WebhookFailuresIdGet: " + e.Message );
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

[**InlineResponse200128**](InlineResponse200128.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="webhookfailuresidpatch"></a>
# **WebhookFailuresIdPatch**
> InlineResponse200128 WebhookFailuresIdPatch (WebhookFailuresIdBody body, int? id)

Update a Webhook Failure

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class WebhookFailuresIdPatchExample
    {
        public void main()
        {


            var apiInstance = new WebhookFailureApi();
            var body = new WebhookFailuresIdBody(); // WebhookFailuresIdBody | 
            var id = 56;  // int? | 

            try
            {
                // Update a Webhook Failure
                InlineResponse200128 result = apiInstance.WebhookFailuresIdPatch(body, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebhookFailureApi.WebhookFailuresIdPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**WebhookFailuresIdBody**](WebhookFailuresIdBody.md)|  | 
 **id** | **int?**|  | 

### Return type

[**InlineResponse200128**](InlineResponse200128.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="webhookfailurespost"></a>
# **WebhookFailuresPost**
> InlineResponse200128 WebhookFailuresPost (WebhookFailuresBody body)

Create a Webhook Failure

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class WebhookFailuresPostExample
    {
        public void main()
        {


            var apiInstance = new WebhookFailureApi();
            var body = new WebhookFailuresBody(); // WebhookFailuresBody | 

            try
            {
                // Create a Webhook Failure
                InlineResponse200128 result = apiInstance.WebhookFailuresPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebhookFailureApi.WebhookFailuresPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**WebhookFailuresBody**](WebhookFailuresBody.md)|  | 

### Return type

[**InlineResponse200128**](InlineResponse200128.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

