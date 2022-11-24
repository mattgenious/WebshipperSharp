# IO.Swagger.Api.ShippingRateApi

All URIs are relative to *https://{tenant}.api.webshipper.io/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ShippingRatesGet**](ShippingRateApi.md#shippingratesget) | **GET** /shipping_rates | List all Shipping Rates
[**ShippingRatesIdDelete**](ShippingRateApi.md#shippingratesiddelete) | **DELETE** /shipping_rates/{id} | Delete a Shipping Rate
[**ShippingRatesIdGet**](ShippingRateApi.md#shippingratesidget) | **GET** /shipping_rates/{id} | Show a single Shipping Rate
[**ShippingRatesIdPatch**](ShippingRateApi.md#shippingratesidpatch) | **PATCH** /shipping_rates/{id} | Update a Shipping Rate
[**ShippingRatesPost**](ShippingRateApi.md#shippingratespost) | **POST** /shipping_rates | Create a Shipping Rate

<a name="shippingratesget"></a>
# **ShippingRatesGet**
> InlineResponse200104 ShippingRatesGet (string filterId, string filterOrderChannelId, string filterIsReturn, string filterIsHidden, string filterServiceCode)

List all Shipping Rates

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ShippingRatesGetExample
    {
        public void main()
        {


            var apiInstance = new ShippingRateApi();
            var filterId = filterId_example;  // string | Filter by id (optional) 
            var filterOrderChannelId = filterOrderChannelId_example;  // string | Filter by order_channel_id (optional) 
            var filterIsReturn = filterIsReturn_example;  // string | Filter by is_return (optional) 
            var filterIsHidden = filterIsHidden_example;  // string | Filter by is_hidden (optional) 
            var filterServiceCode = filterServiceCode_example;  // string | Filter by service_code (optional) 

            try
            {
                // List all Shipping Rates
                InlineResponse200104 result = apiInstance.ShippingRatesGet(filterId, filterOrderChannelId, filterIsReturn, filterIsHidden, filterServiceCode);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ShippingRateApi.ShippingRatesGet: " + e.Message );
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
 **filterIsReturn** | **string**| Filter by is_return | [optional] 
 **filterIsHidden** | **string**| Filter by is_hidden | [optional] 
 **filterServiceCode** | **string**| Filter by service_code | [optional] 

### Return type

[**InlineResponse200104**](InlineResponse200104.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="shippingratesiddelete"></a>
# **ShippingRatesIdDelete**
> InlineResponse200103 ShippingRatesIdDelete (int? id)

Delete a Shipping Rate

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ShippingRatesIdDeleteExample
    {
        public void main()
        {


            var apiInstance = new ShippingRateApi();
            var id = 56;  // int? | 

            try
            {
                // Delete a Shipping Rate
                InlineResponse200103 result = apiInstance.ShippingRatesIdDelete(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ShippingRateApi.ShippingRatesIdDelete: " + e.Message );
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

[**InlineResponse200103**](InlineResponse200103.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="shippingratesidget"></a>
# **ShippingRatesIdGet**
> InlineResponse200103 ShippingRatesIdGet (int? id)

Show a single Shipping Rate

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ShippingRatesIdGetExample
    {
        public void main()
        {


            var apiInstance = new ShippingRateApi();
            var id = 56;  // int? | 

            try
            {
                // Show a single Shipping Rate
                InlineResponse200103 result = apiInstance.ShippingRatesIdGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ShippingRateApi.ShippingRatesIdGet: " + e.Message );
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

[**InlineResponse200103**](InlineResponse200103.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="shippingratesidpatch"></a>
# **ShippingRatesIdPatch**
> InlineResponse200103 ShippingRatesIdPatch (ShippingRatesIdBody body, int? id)

Update a Shipping Rate

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ShippingRatesIdPatchExample
    {
        public void main()
        {


            var apiInstance = new ShippingRateApi();
            var body = new ShippingRatesIdBody(); // ShippingRatesIdBody | 
            var id = 56;  // int? | 

            try
            {
                // Update a Shipping Rate
                InlineResponse200103 result = apiInstance.ShippingRatesIdPatch(body, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ShippingRateApi.ShippingRatesIdPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ShippingRatesIdBody**](ShippingRatesIdBody.md)|  | 
 **id** | **int?**|  | 

### Return type

[**InlineResponse200103**](InlineResponse200103.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="shippingratespost"></a>
# **ShippingRatesPost**
> InlineResponse200103 ShippingRatesPost (ShippingRatesBody body)

Create a Shipping Rate

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ShippingRatesPostExample
    {
        public void main()
        {


            var apiInstance = new ShippingRateApi();
            var body = new ShippingRatesBody(); // ShippingRatesBody | 

            try
            {
                // Create a Shipping Rate
                InlineResponse200103 result = apiInstance.ShippingRatesPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ShippingRateApi.ShippingRatesPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ShippingRatesBody**](ShippingRatesBody.md)|  | 

### Return type

[**InlineResponse200103**](InlineResponse200103.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

