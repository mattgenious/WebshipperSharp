# IO.Swagger.Api.WebhookApi

All URIs are relative to *https://{tenant}.api.webshipper.io/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**WebhooksGet**](WebhookApi.md#webhooksget) | **GET** /webhooks | List all Webhooks
[**WebhooksIdDelete**](WebhookApi.md#webhooksiddelete) | **DELETE** /webhooks/{id} | Delete a Webhook
[**WebhooksIdGet**](WebhookApi.md#webhooksidget) | **GET** /webhooks/{id} | Show a single Webhook
[**WebhooksIdPatch**](WebhookApi.md#webhooksidpatch) | **PATCH** /webhooks/{id} | Update a Webhook
[**WebhooksPost**](WebhookApi.md#webhookspost) | **POST** /webhooks | Create a Webhook

<a name="webhooksget"></a>
# **WebhooksGet**
> InlineResponse200127 WebhooksGet (string filterId)

List all Webhooks

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class WebhooksGetExample
    {
        public void main()
        {


            var apiInstance = new WebhookApi();
            var filterId = filterId_example;  // string | Filter by id (optional) 

            try
            {
                // List all Webhooks
                InlineResponse200127 result = apiInstance.WebhooksGet(filterId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebhookApi.WebhooksGet: " + e.Message );
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

[**InlineResponse200127**](InlineResponse200127.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="webhooksiddelete"></a>
# **WebhooksIdDelete**
> InlineResponse200126 WebhooksIdDelete (int? id)

Delete a Webhook

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class WebhooksIdDeleteExample
    {
        public void main()
        {


            var apiInstance = new WebhookApi();
            var id = 56;  // int? | 

            try
            {
                // Delete a Webhook
                InlineResponse200126 result = apiInstance.WebhooksIdDelete(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebhookApi.WebhooksIdDelete: " + e.Message );
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

[**InlineResponse200126**](InlineResponse200126.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="webhooksidget"></a>
# **WebhooksIdGet**
> InlineResponse200126 WebhooksIdGet (int? id)

Show a single Webhook

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class WebhooksIdGetExample
    {
        public void main()
        {


            var apiInstance = new WebhookApi();
            var id = 56;  // int? | 

            try
            {
                // Show a single Webhook
                InlineResponse200126 result = apiInstance.WebhooksIdGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebhookApi.WebhooksIdGet: " + e.Message );
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

[**InlineResponse200126**](InlineResponse200126.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="webhooksidpatch"></a>
# **WebhooksIdPatch**
> InlineResponse200126 WebhooksIdPatch (WebhooksIdBody body, int? id)

Update a Webhook

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class WebhooksIdPatchExample
    {
        public void main()
        {


            var apiInstance = new WebhookApi();
            var body = new WebhooksIdBody(); // WebhooksIdBody | 
            var id = 56;  // int? | 

            try
            {
                // Update a Webhook
                InlineResponse200126 result = apiInstance.WebhooksIdPatch(body, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebhookApi.WebhooksIdPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**WebhooksIdBody**](WebhooksIdBody.md)|  | 
 **id** | **int?**|  | 

### Return type

[**InlineResponse200126**](InlineResponse200126.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="webhookspost"></a>
# **WebhooksPost**
> InlineResponse200126 WebhooksPost (WebhooksBody body)

Create a Webhook

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class WebhooksPostExample
    {
        public void main()
        {


            var apiInstance = new WebhookApi();
            var body = new WebhooksBody(); // WebhooksBody | 

            try
            {
                // Create a Webhook
                InlineResponse200126 result = apiInstance.WebhooksPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebhookApi.WebhooksPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**WebhooksBody**](WebhooksBody.md)|  | 

### Return type

[**InlineResponse200126**](InlineResponse200126.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

