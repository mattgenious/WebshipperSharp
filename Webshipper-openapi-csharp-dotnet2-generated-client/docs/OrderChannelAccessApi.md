# IO.Swagger.Api.OrderChannelAccessApi

All URIs are relative to *https://{tenant}.api.webshipper.io/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**OrderChannelAccessesGet**](OrderChannelAccessApi.md#orderchannelaccessesget) | **GET** /order_channel_accesses | List all Order Channel Accesss
[**OrderChannelAccessesIdDelete**](OrderChannelAccessApi.md#orderchannelaccessesiddelete) | **DELETE** /order_channel_accesses/{id} | Delete a Order Channel Access
[**OrderChannelAccessesIdGet**](OrderChannelAccessApi.md#orderchannelaccessesidget) | **GET** /order_channel_accesses/{id} | Show a single Order Channel Access
[**OrderChannelAccessesIdPatch**](OrderChannelAccessApi.md#orderchannelaccessesidpatch) | **PATCH** /order_channel_accesses/{id} | Update a Order Channel Access
[**OrderChannelAccessesPost**](OrderChannelAccessApi.md#orderchannelaccessespost) | **POST** /order_channel_accesses | Create a Order Channel Access

<a name="orderchannelaccessesget"></a>
# **OrderChannelAccessesGet**
> InlineResponse20068 OrderChannelAccessesGet (string filterId)

List all Order Channel Accesss

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class OrderChannelAccessesGetExample
    {
        public void main()
        {


            var apiInstance = new OrderChannelAccessApi();
            var filterId = filterId_example;  // string | Filter by id (optional) 

            try
            {
                // List all Order Channel Accesss
                InlineResponse20068 result = apiInstance.OrderChannelAccessesGet(filterId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderChannelAccessApi.OrderChannelAccessesGet: " + e.Message );
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

[**InlineResponse20068**](InlineResponse20068.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="orderchannelaccessesiddelete"></a>
# **OrderChannelAccessesIdDelete**
> InlineResponse20067 OrderChannelAccessesIdDelete (int? id)

Delete a Order Channel Access

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class OrderChannelAccessesIdDeleteExample
    {
        public void main()
        {


            var apiInstance = new OrderChannelAccessApi();
            var id = 56;  // int? | 

            try
            {
                // Delete a Order Channel Access
                InlineResponse20067 result = apiInstance.OrderChannelAccessesIdDelete(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderChannelAccessApi.OrderChannelAccessesIdDelete: " + e.Message );
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

[**InlineResponse20067**](InlineResponse20067.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="orderchannelaccessesidget"></a>
# **OrderChannelAccessesIdGet**
> InlineResponse20067 OrderChannelAccessesIdGet (int? id)

Show a single Order Channel Access

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class OrderChannelAccessesIdGetExample
    {
        public void main()
        {


            var apiInstance = new OrderChannelAccessApi();
            var id = 56;  // int? | 

            try
            {
                // Show a single Order Channel Access
                InlineResponse20067 result = apiInstance.OrderChannelAccessesIdGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderChannelAccessApi.OrderChannelAccessesIdGet: " + e.Message );
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

[**InlineResponse20067**](InlineResponse20067.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="orderchannelaccessesidpatch"></a>
# **OrderChannelAccessesIdPatch**
> InlineResponse20067 OrderChannelAccessesIdPatch (OrderChannelAccessesIdBody body, int? id)

Update a Order Channel Access

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class OrderChannelAccessesIdPatchExample
    {
        public void main()
        {


            var apiInstance = new OrderChannelAccessApi();
            var body = new OrderChannelAccessesIdBody(); // OrderChannelAccessesIdBody | 
            var id = 56;  // int? | 

            try
            {
                // Update a Order Channel Access
                InlineResponse20067 result = apiInstance.OrderChannelAccessesIdPatch(body, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderChannelAccessApi.OrderChannelAccessesIdPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**OrderChannelAccessesIdBody**](OrderChannelAccessesIdBody.md)|  | 
 **id** | **int?**|  | 

### Return type

[**InlineResponse20067**](InlineResponse20067.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="orderchannelaccessespost"></a>
# **OrderChannelAccessesPost**
> InlineResponse20067 OrderChannelAccessesPost (OrderChannelAccessesBody body)

Create a Order Channel Access

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class OrderChannelAccessesPostExample
    {
        public void main()
        {


            var apiInstance = new OrderChannelAccessApi();
            var body = new OrderChannelAccessesBody(); // OrderChannelAccessesBody | 

            try
            {
                // Create a Order Channel Access
                InlineResponse20067 result = apiInstance.OrderChannelAccessesPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderChannelAccessApi.OrderChannelAccessesPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**OrderChannelAccessesBody**](OrderChannelAccessesBody.md)|  | 

### Return type

[**InlineResponse20067**](InlineResponse20067.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

