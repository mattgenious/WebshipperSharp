# IO.Swagger.Api.ShippingMappingApi

All URIs are relative to *https://{tenant}.api.webshipper.io/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ShippingMappingsGet**](ShippingMappingApi.md#shippingmappingsget) | **GET** /shipping_mappings | List all Shipping Mappings
[**ShippingMappingsIdDelete**](ShippingMappingApi.md#shippingmappingsiddelete) | **DELETE** /shipping_mappings/{id} | Delete a Shipping Mapping
[**ShippingMappingsIdGet**](ShippingMappingApi.md#shippingmappingsidget) | **GET** /shipping_mappings/{id} | Show a single Shipping Mapping
[**ShippingMappingsIdPatch**](ShippingMappingApi.md#shippingmappingsidpatch) | **PATCH** /shipping_mappings/{id} | Update a Shipping Mapping
[**ShippingMappingsPost**](ShippingMappingApi.md#shippingmappingspost) | **POST** /shipping_mappings | Create a Shipping Mapping

<a name="shippingmappingsget"></a>
# **ShippingMappingsGet**
> InlineResponse200102 ShippingMappingsGet (string filterId, string filterOrderChannelId, string filterOrderChannel, string filterShippingCode)

List all Shipping Mappings

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ShippingMappingsGetExample
    {
        public void main()
        {


            var apiInstance = new ShippingMappingApi();
            var filterId = filterId_example;  // string | Filter by id (optional) 
            var filterOrderChannelId = filterOrderChannelId_example;  // string | Filter by order_channel_id (optional) 
            var filterOrderChannel = filterOrderChannel_example;  // string | Filter by order_channel (optional) 
            var filterShippingCode = filterShippingCode_example;  // string | Filter by shipping_code (optional) 

            try
            {
                // List all Shipping Mappings
                InlineResponse200102 result = apiInstance.ShippingMappingsGet(filterId, filterOrderChannelId, filterOrderChannel, filterShippingCode);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ShippingMappingApi.ShippingMappingsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filterId** | **string**| Filter by id | [optional] 
 **filterOrderChannelId** | **string**| Filter by order_channel_id | [optional] 
 **filterOrderChannel** | **string**| Filter by order_channel | [optional] 
 **filterShippingCode** | **string**| Filter by shipping_code | [optional] 

### Return type

[**InlineResponse200102**](InlineResponse200102.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="shippingmappingsiddelete"></a>
# **ShippingMappingsIdDelete**
> InlineResponse200101 ShippingMappingsIdDelete (int? id)

Delete a Shipping Mapping

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ShippingMappingsIdDeleteExample
    {
        public void main()
        {


            var apiInstance = new ShippingMappingApi();
            var id = 56;  // int? | 

            try
            {
                // Delete a Shipping Mapping
                InlineResponse200101 result = apiInstance.ShippingMappingsIdDelete(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ShippingMappingApi.ShippingMappingsIdDelete: " + e.Message );
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

[**InlineResponse200101**](InlineResponse200101.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="shippingmappingsidget"></a>
# **ShippingMappingsIdGet**
> InlineResponse200101 ShippingMappingsIdGet (int? id)

Show a single Shipping Mapping

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ShippingMappingsIdGetExample
    {
        public void main()
        {


            var apiInstance = new ShippingMappingApi();
            var id = 56;  // int? | 

            try
            {
                // Show a single Shipping Mapping
                InlineResponse200101 result = apiInstance.ShippingMappingsIdGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ShippingMappingApi.ShippingMappingsIdGet: " + e.Message );
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

[**InlineResponse200101**](InlineResponse200101.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="shippingmappingsidpatch"></a>
# **ShippingMappingsIdPatch**
> InlineResponse200101 ShippingMappingsIdPatch (ShippingMappingsIdBody body, int? id)

Update a Shipping Mapping

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ShippingMappingsIdPatchExample
    {
        public void main()
        {


            var apiInstance = new ShippingMappingApi();
            var body = new ShippingMappingsIdBody(); // ShippingMappingsIdBody | 
            var id = 56;  // int? | 

            try
            {
                // Update a Shipping Mapping
                InlineResponse200101 result = apiInstance.ShippingMappingsIdPatch(body, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ShippingMappingApi.ShippingMappingsIdPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ShippingMappingsIdBody**](ShippingMappingsIdBody.md)|  | 
 **id** | **int?**|  | 

### Return type

[**InlineResponse200101**](InlineResponse200101.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="shippingmappingspost"></a>
# **ShippingMappingsPost**
> InlineResponse200101 ShippingMappingsPost (ShippingMappingsBody body)

Create a Shipping Mapping

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ShippingMappingsPostExample
    {
        public void main()
        {


            var apiInstance = new ShippingMappingApi();
            var body = new ShippingMappingsBody(); // ShippingMappingsBody | 

            try
            {
                // Create a Shipping Mapping
                InlineResponse200101 result = apiInstance.ShippingMappingsPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ShippingMappingApi.ShippingMappingsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ShippingMappingsBody**](ShippingMappingsBody.md)|  | 

### Return type

[**InlineResponse200101**](InlineResponse200101.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

