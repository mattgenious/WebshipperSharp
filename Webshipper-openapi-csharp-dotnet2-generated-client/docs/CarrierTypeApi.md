# IO.Swagger.Api.CarrierTypeApi

All URIs are relative to *https://{tenant}.api.webshipper.io/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CarrierTypesGet**](CarrierTypeApi.md#carriertypesget) | **GET** /carrier_types | List all Carrier Types
[**CarrierTypesIdGet**](CarrierTypeApi.md#carriertypesidget) | **GET** /carrier_types/{id} | Show a single Carrier Type

<a name="carriertypesget"></a>
# **CarrierTypesGet**
> InlineResponse20027 CarrierTypesGet (string filterId, string filterCarrierCode)

List all Carrier Types

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CarrierTypesGetExample
    {
        public void main()
        {


            var apiInstance = new CarrierTypeApi();
            var filterId = filterId_example;  // string | Filter by id (optional) 
            var filterCarrierCode = filterCarrierCode_example;  // string | Filter by carrier_code (optional) 

            try
            {
                // List all Carrier Types
                InlineResponse20027 result = apiInstance.CarrierTypesGet(filterId, filterCarrierCode);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CarrierTypeApi.CarrierTypesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filterId** | **string**| Filter by id | [optional] 
 **filterCarrierCode** | **string**| Filter by carrier_code | [optional] 

### Return type

[**InlineResponse20027**](InlineResponse20027.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="carriertypesidget"></a>
# **CarrierTypesIdGet**
> InlineResponse20026 CarrierTypesIdGet (int? id)

Show a single Carrier Type

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CarrierTypesIdGetExample
    {
        public void main()
        {


            var apiInstance = new CarrierTypeApi();
            var id = 56;  // int? | 

            try
            {
                // Show a single Carrier Type
                InlineResponse20026 result = apiInstance.CarrierTypesIdGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CarrierTypeApi.CarrierTypesIdGet: " + e.Message );
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

[**InlineResponse20026**](InlineResponse20026.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

