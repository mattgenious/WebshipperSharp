# IO.Swagger.Api.OrderApi

All URIs are relative to *https://{tenant}.api.webshipper.io/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**OrdersGet**](OrderApi.md#ordersget) | **GET** /orders | List all Orders
[**OrdersIdDelete**](OrderApi.md#ordersiddelete) | **DELETE** /orders/{id} | Delete a Order
[**OrdersIdGet**](OrderApi.md#ordersidget) | **GET** /orders/{id} | Show a single Order
[**OrdersIdPatch**](OrderApi.md#ordersidpatch) | **PATCH** /orders/{id} | Update a Order
[**OrdersPost**](OrderApi.md#orderspost) | **POST** /orders | Create a Order

<a name="ordersget"></a>
# **OrdersGet**
> InlineResponse20064 OrdersGet (string filterId, string filterExtRef, string filterSortingId, string filterCreatedAt, string filterUpdatedAt, string filterStatus, string filterVisibleRef, string filterSlipPrinted, string filterLabelPrinted, string filterLockState, string filterOrderChannel, string filterOrderChannelId, string filterShippingRate, string filterShippingRateId, string filterCarrier, string filterSku, string filterFreeText, string filterTag, string filterDeliveryCountryCode)

List all Orders

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class OrdersGetExample
    {
        public void main()
        {


            var apiInstance = new OrderApi();
            var filterId = filterId_example;  // string | Filter by id (optional) 
            var filterExtRef = filterExtRef_example;  // string | Filter by ext_ref (optional) 
            var filterSortingId = filterSortingId_example;  // string | Filter by sorting_id (optional) 
            var filterCreatedAt = filterCreatedAt_example;  // string | Filter by created_at (optional) 
            var filterUpdatedAt = filterUpdatedAt_example;  // string | Filter by updated_at (optional) 
            var filterStatus = filterStatus_example;  // string | Filter by status (optional) 
            var filterVisibleRef = filterVisibleRef_example;  // string | Filter by visible_ref (optional) 
            var filterSlipPrinted = filterSlipPrinted_example;  // string | Filter by slip_printed (optional) 
            var filterLabelPrinted = filterLabelPrinted_example;  // string | Filter by label_printed (optional) 
            var filterLockState = filterLockState_example;  // string | Filter by lock_state (optional) 
            var filterOrderChannel = filterOrderChannel_example;  // string | Filter by order_channel (optional) 
            var filterOrderChannelId = filterOrderChannelId_example;  // string | Filter by order_channel_id (optional) 
            var filterShippingRate = filterShippingRate_example;  // string | Filter by shipping_rate (optional) 
            var filterShippingRateId = filterShippingRateId_example;  // string | Filter by shipping_rate_id (optional) 
            var filterCarrier = filterCarrier_example;  // string | Filter by carrier (optional) 
            var filterSku = filterSku_example;  // string | Filter by sku (optional) 
            var filterFreeText = filterFreeText_example;  // string | Filter by free_text (optional) 
            var filterTag = filterTag_example;  // string | Filter by tag (optional) 
            var filterDeliveryCountryCode = filterDeliveryCountryCode_example;  // string | Filter by delivery_country_code (optional) 

            try
            {
                // List all Orders
                InlineResponse20064 result = apiInstance.OrdersGet(filterId, filterExtRef, filterSortingId, filterCreatedAt, filterUpdatedAt, filterStatus, filterVisibleRef, filterSlipPrinted, filterLabelPrinted, filterLockState, filterOrderChannel, filterOrderChannelId, filterShippingRate, filterShippingRateId, filterCarrier, filterSku, filterFreeText, filterTag, filterDeliveryCountryCode);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderApi.OrdersGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filterId** | **string**| Filter by id | [optional] 
 **filterExtRef** | **string**| Filter by ext_ref | [optional] 
 **filterSortingId** | **string**| Filter by sorting_id | [optional] 
 **filterCreatedAt** | **string**| Filter by created_at | [optional] 
 **filterUpdatedAt** | **string**| Filter by updated_at | [optional] 
 **filterStatus** | **string**| Filter by status | [optional] 
 **filterVisibleRef** | **string**| Filter by visible_ref | [optional] 
 **filterSlipPrinted** | **string**| Filter by slip_printed | [optional] 
 **filterLabelPrinted** | **string**| Filter by label_printed | [optional] 
 **filterLockState** | **string**| Filter by lock_state | [optional] 
 **filterOrderChannel** | **string**| Filter by order_channel | [optional] 
 **filterOrderChannelId** | **string**| Filter by order_channel_id | [optional] 
 **filterShippingRate** | **string**| Filter by shipping_rate | [optional] 
 **filterShippingRateId** | **string**| Filter by shipping_rate_id | [optional] 
 **filterCarrier** | **string**| Filter by carrier | [optional] 
 **filterSku** | **string**| Filter by sku | [optional] 
 **filterFreeText** | **string**| Filter by free_text | [optional] 
 **filterTag** | **string**| Filter by tag | [optional] 
 **filterDeliveryCountryCode** | **string**| Filter by delivery_country_code | [optional] 

### Return type

[**InlineResponse20064**](InlineResponse20064.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ordersiddelete"></a>
# **OrdersIdDelete**
> InlineResponse20063 OrdersIdDelete (int? id)

Delete a Order

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class OrdersIdDeleteExample
    {
        public void main()
        {


            var apiInstance = new OrderApi();
            var id = 56;  // int? | 

            try
            {
                // Delete a Order
                InlineResponse20063 result = apiInstance.OrdersIdDelete(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderApi.OrdersIdDelete: " + e.Message );
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

[**InlineResponse20063**](InlineResponse20063.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ordersidget"></a>
# **OrdersIdGet**
> InlineResponse20063 OrdersIdGet (int? id)

Show a single Order

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class OrdersIdGetExample
    {
        public void main()
        {


            var apiInstance = new OrderApi();
            var id = 56;  // int? | 

            try
            {
                // Show a single Order
                InlineResponse20063 result = apiInstance.OrdersIdGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderApi.OrdersIdGet: " + e.Message );
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

[**InlineResponse20063**](InlineResponse20063.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ordersidpatch"></a>
# **OrdersIdPatch**
> InlineResponse20063 OrdersIdPatch (OrdersIdBody body, int? id)

Update a Order

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class OrdersIdPatchExample
    {
        public void main()
        {


            var apiInstance = new OrderApi();
            var body = new OrdersIdBody(); // OrdersIdBody | 
            var id = 56;  // int? | 

            try
            {
                // Update a Order
                InlineResponse20063 result = apiInstance.OrdersIdPatch(body, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderApi.OrdersIdPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**OrdersIdBody**](OrdersIdBody.md)|  | 
 **id** | **int?**|  | 

### Return type

[**InlineResponse20063**](InlineResponse20063.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="orderspost"></a>
# **OrdersPost**
> InlineResponse20063 OrdersPost (OrdersBody body)

Create a Order

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class OrdersPostExample
    {
        public void main()
        {


            var apiInstance = new OrderApi();
            var body = new OrdersBody(); // OrdersBody | 

            try
            {
                // Create a Order
                InlineResponse20063 result = apiInstance.OrdersPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderApi.OrdersPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**OrdersBody**](OrdersBody.md)|  | 

### Return type

[**InlineResponse20063**](InlineResponse20063.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

