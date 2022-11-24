# IO.Swagger.Api.OrderChannelTypeApi

All URIs are relative to *https://{tenant}.api.webshipper.io/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**OrderChannelTypesGet**](OrderChannelTypeApi.md#orderchanneltypesget) | **GET** /order_channel_types | List all Order Channel Types
[**OrderChannelTypesIdGet**](OrderChannelTypeApi.md#orderchanneltypesidget) | **GET** /order_channel_types/{id} | Show a single Order Channel Type

<a name="orderchanneltypesget"></a>
# **OrderChannelTypesGet**
> InlineResponse20070 OrderChannelTypesGet (string filterId)

List all Order Channel Types

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class OrderChannelTypesGetExample
    {
        public void main()
        {


            var apiInstance = new OrderChannelTypeApi();
            var filterId = filterId_example;  // string | Filter by id (optional) 

            try
            {
                // List all Order Channel Types
                InlineResponse20070 result = apiInstance.OrderChannelTypesGet(filterId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderChannelTypeApi.OrderChannelTypesGet: " + e.Message );
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

[**InlineResponse20070**](InlineResponse20070.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="orderchanneltypesidget"></a>
# **OrderChannelTypesIdGet**
> InlineResponse20069 OrderChannelTypesIdGet (int? id)

Show a single Order Channel Type

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class OrderChannelTypesIdGetExample
    {
        public void main()
        {


            var apiInstance = new OrderChannelTypeApi();
            var id = 56;  // int? | 

            try
            {
                // Show a single Order Channel Type
                InlineResponse20069 result = apiInstance.OrderChannelTypesIdGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderChannelTypeApi.OrderChannelTypesIdGet: " + e.Message );
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

[**InlineResponse20069**](InlineResponse20069.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

