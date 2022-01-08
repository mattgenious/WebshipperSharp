# IO.Swagger.Api.EDIApi

All URIs are relative to *https://{tenant}.api.webshipper.io/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**EdisGet**](EDIApi.md#edisget) | **GET** /edis | List all EDIs
[**EdisIdGet**](EDIApi.md#edisidget) | **GET** /edis/{id} | Show a single EDI

<a name="edisget"></a>
# **EdisGet**
> InlineResponse20033 EdisGet (string filterId, string filterShipmentId, string filterWaybillId)

List all EDIs

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class EdisGetExample
    {
        public void main()
        {


            var apiInstance = new EDIApi();
            var filterId = filterId_example;  // string | Filter by id (optional) 
            var filterShipmentId = filterShipmentId_example;  // string | Filter by shipment_id (optional) 
            var filterWaybillId = filterWaybillId_example;  // string | Filter by waybill_id (optional) 

            try
            {
                // List all EDIs
                InlineResponse20033 result = apiInstance.EdisGet(filterId, filterShipmentId, filterWaybillId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EDIApi.EdisGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filterId** | **string**| Filter by id | [optional] 
 **filterShipmentId** | **string**| Filter by shipment_id | [optional] 
 **filterWaybillId** | **string**| Filter by waybill_id | [optional] 

### Return type

[**InlineResponse20033**](InlineResponse20033.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="edisidget"></a>
# **EdisIdGet**
> InlineResponse20032 EdisIdGet (int? id)

Show a single EDI

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class EdisIdGetExample
    {
        public void main()
        {


            var apiInstance = new EDIApi();
            var id = 56;  // int? | 

            try
            {
                // Show a single EDI
                InlineResponse20032 result = apiInstance.EdisIdGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EDIApi.EdisIdGet: " + e.Message );
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

[**InlineResponse20032**](InlineResponse20032.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

