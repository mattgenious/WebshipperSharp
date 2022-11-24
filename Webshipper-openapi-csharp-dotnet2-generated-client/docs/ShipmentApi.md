# IO.Swagger.Api.ShipmentApi

All URIs are relative to *https://{tenant}.api.webshipper.io/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ShipmentsGet**](ShipmentApi.md#shipmentsget) | **GET** /shipments | List all Shipments
[**ShipmentsIdGet**](ShipmentApi.md#shipmentsidget) | **GET** /shipments/{id} | Show a single Shipment
[**ShipmentsPost**](ShipmentApi.md#shipmentspost) | **POST** /shipments | Create a Shipment

<a name="shipmentsget"></a>
# **ShipmentsGet**
> InlineResponse20098 ShipmentsGet (string filterId, string filterReference, string filterSortingId, string filterCreatedAt, string filterUpdatedAt, string filterOrder, string filterCarrier, string filterSendTime, string filterStatus, string filterIsReturn, string filterPrinterClient, string filterDeliveryAddress, string filterTrackingNumber, string filterFreeText, string filterHasPickup)

List all Shipments

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ShipmentsGetExample
    {
        public void main()
        {


            var apiInstance = new ShipmentApi();
            var filterId = filterId_example;  // string | Filter by id (optional) 
            var filterReference = filterReference_example;  // string | Filter by reference (optional) 
            var filterSortingId = filterSortingId_example;  // string | Filter by sorting_id (optional) 
            var filterCreatedAt = filterCreatedAt_example;  // string | Filter by created_at (optional) 
            var filterUpdatedAt = filterUpdatedAt_example;  // string | Filter by updated_at (optional) 
            var filterOrder = filterOrder_example;  // string | Filter by order (optional) 
            var filterCarrier = filterCarrier_example;  // string | Filter by carrier (optional) 
            var filterSendTime = filterSendTime_example;  // string | Filter by send_time (optional) 
            var filterStatus = filterStatus_example;  // string | Filter by status (optional) 
            var filterIsReturn = filterIsReturn_example;  // string | Filter by is_return (optional) 
            var filterPrinterClient = filterPrinterClient_example;  // string | Filter by printer_client (optional) 
            var filterDeliveryAddress = filterDeliveryAddress_example;  // string | Filter by delivery_address (optional) 
            var filterTrackingNumber = filterTrackingNumber_example;  // string | Filter by tracking_number (optional) 
            var filterFreeText = filterFreeText_example;  // string | Filter by free_text (optional) 
            var filterHasPickup = filterHasPickup_example;  // string | Filter by has_pickup (optional) 

            try
            {
                // List all Shipments
                InlineResponse20098 result = apiInstance.ShipmentsGet(filterId, filterReference, filterSortingId, filterCreatedAt, filterUpdatedAt, filterOrder, filterCarrier, filterSendTime, filterStatus, filterIsReturn, filterPrinterClient, filterDeliveryAddress, filterTrackingNumber, filterFreeText, filterHasPickup);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ShipmentApi.ShipmentsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filterId** | **string**| Filter by id | [optional] 
 **filterReference** | **string**| Filter by reference | [optional] 
 **filterSortingId** | **string**| Filter by sorting_id | [optional] 
 **filterCreatedAt** | **string**| Filter by created_at | [optional] 
 **filterUpdatedAt** | **string**| Filter by updated_at | [optional] 
 **filterOrder** | **string**| Filter by order | [optional] 
 **filterCarrier** | **string**| Filter by carrier | [optional] 
 **filterSendTime** | **string**| Filter by send_time | [optional] 
 **filterStatus** | **string**| Filter by status | [optional] 
 **filterIsReturn** | **string**| Filter by is_return | [optional] 
 **filterPrinterClient** | **string**| Filter by printer_client | [optional] 
 **filterDeliveryAddress** | **string**| Filter by delivery_address | [optional] 
 **filterTrackingNumber** | **string**| Filter by tracking_number | [optional] 
 **filterFreeText** | **string**| Filter by free_text | [optional] 
 **filterHasPickup** | **string**| Filter by has_pickup | [optional] 

### Return type

[**InlineResponse20098**](InlineResponse20098.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="shipmentsidget"></a>
# **ShipmentsIdGet**
> InlineResponse20097 ShipmentsIdGet (int? id)

Show a single Shipment

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ShipmentsIdGetExample
    {
        public void main()
        {


            var apiInstance = new ShipmentApi();
            var id = 56;  // int? | 

            try
            {
                // Show a single Shipment
                InlineResponse20097 result = apiInstance.ShipmentsIdGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ShipmentApi.ShipmentsIdGet: " + e.Message );
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

[**InlineResponse20097**](InlineResponse20097.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="shipmentspost"></a>
# **ShipmentsPost**
> InlineResponse20097 ShipmentsPost (ShipmentsBody body)

Create a Shipment

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ShipmentsPostExample
    {
        public void main()
        {


            var apiInstance = new ShipmentApi();
            var body = new ShipmentsBody(); // ShipmentsBody | 

            try
            {
                // Create a Shipment
                InlineResponse20097 result = apiInstance.ShipmentsPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ShipmentApi.ShipmentsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ShipmentsBody**](ShipmentsBody.md)|  | 

### Return type

[**InlineResponse20097**](InlineResponse20097.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

