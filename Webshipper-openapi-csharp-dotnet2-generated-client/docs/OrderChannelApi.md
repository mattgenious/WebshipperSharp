# IO.Swagger.Api.OrderChannelApi

All URIs are relative to *https://{tenant}.api.webshipper.io/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**OrderChannelsGet**](OrderChannelApi.md#orderchannelsget) | **GET** /order_channels | List all Order Channels
[**OrderChannelsIdDelete**](OrderChannelApi.md#orderchannelsiddelete) | **DELETE** /order_channels/{id} | Delete a Order Channel
[**OrderChannelsIdGet**](OrderChannelApi.md#orderchannelsidget) | **GET** /order_channels/{id} | Show a single Order Channel
[**OrderChannelsIdPatch**](OrderChannelApi.md#orderchannelsidpatch) | **PATCH** /order_channels/{id} | Update a Order Channel
[**OrderChannelsPost**](OrderChannelApi.md#orderchannelspost) | **POST** /order_channels | Create a Order Channel

<a name="orderchannelsget"></a>
# **OrderChannelsGet**
> InlineResponse20066 OrderChannelsGet (string filterId, string filterAttr)

List all Order Channels

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class OrderChannelsGetExample
    {
        public void main()
        {


            var apiInstance = new OrderChannelApi();
            var filterId = filterId_example;  // string | Filter by id (optional) 
            var filterAttr = filterAttr_example;  // string | Filter by attr (optional) 

            try
            {
                // List all Order Channels
                InlineResponse20066 result = apiInstance.OrderChannelsGet(filterId, filterAttr);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderChannelApi.OrderChannelsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filterId** | **string**| Filter by id | [optional] 
 **filterAttr** | **string**| Filter by attr | [optional] 

### Return type

[**InlineResponse20066**](InlineResponse20066.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="orderchannelsiddelete"></a>
# **OrderChannelsIdDelete**
> InlineResponse20065 OrderChannelsIdDelete (int? id)

Delete a Order Channel

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class OrderChannelsIdDeleteExample
    {
        public void main()
        {


            var apiInstance = new OrderChannelApi();
            var id = 56;  // int? | 

            try
            {
                // Delete a Order Channel
                InlineResponse20065 result = apiInstance.OrderChannelsIdDelete(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderChannelApi.OrderChannelsIdDelete: " + e.Message );
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

[**InlineResponse20065**](InlineResponse20065.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="orderchannelsidget"></a>
# **OrderChannelsIdGet**
> InlineResponse20065 OrderChannelsIdGet (int? id)

Show a single Order Channel

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class OrderChannelsIdGetExample
    {
        public void main()
        {


            var apiInstance = new OrderChannelApi();
            var id = 56;  // int? | 

            try
            {
                // Show a single Order Channel
                InlineResponse20065 result = apiInstance.OrderChannelsIdGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderChannelApi.OrderChannelsIdGet: " + e.Message );
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

[**InlineResponse20065**](InlineResponse20065.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="orderchannelsidpatch"></a>
# **OrderChannelsIdPatch**
> InlineResponse20065 OrderChannelsIdPatch (OrderChannelsIdBody body, int? id)

Update a Order Channel

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class OrderChannelsIdPatchExample
    {
        public void main()
        {


            var apiInstance = new OrderChannelApi();
            var body = new OrderChannelsIdBody(); // OrderChannelsIdBody | 
            var id = 56;  // int? | 

            try
            {
                // Update a Order Channel
                InlineResponse20065 result = apiInstance.OrderChannelsIdPatch(body, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderChannelApi.OrderChannelsIdPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**OrderChannelsIdBody**](OrderChannelsIdBody.md)|  | 
 **id** | **int?**|  | 

### Return type

[**InlineResponse20065**](InlineResponse20065.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="orderchannelspost"></a>
# **OrderChannelsPost**
> InlineResponse20065 OrderChannelsPost (OrderChannelsBody body)

Create a Order Channel

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class OrderChannelsPostExample
    {
        public void main()
        {


            var apiInstance = new OrderChannelApi();
            var body = new OrderChannelsBody(); // OrderChannelsBody | 

            try
            {
                // Create a Order Channel
                InlineResponse20065 result = apiInstance.OrderChannelsPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderChannelApi.OrderChannelsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**OrderChannelsBody**](OrderChannelsBody.md)|  | 

### Return type

[**InlineResponse20065**](InlineResponse20065.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

