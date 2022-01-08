# IO.Swagger.Api.CarrierApi

All URIs are relative to *https://{tenant}.api.webshipper.io/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CarriersGet**](CarrierApi.md#carriersget) | **GET** /carriers | List all Carriers
[**CarriersIdDelete**](CarrierApi.md#carriersiddelete) | **DELETE** /carriers/{id} | Delete a Carrier
[**CarriersIdGet**](CarrierApi.md#carriersidget) | **GET** /carriers/{id} | Show a single Carrier
[**CarriersIdPatch**](CarrierApi.md#carriersidpatch) | **PATCH** /carriers/{id} | Update a Carrier
[**CarriersPost**](CarrierApi.md#carrierspost) | **POST** /carriers | Create a Carrier

<a name="carriersget"></a>
# **CarriersGet**
> InlineResponse20023 CarriersGet (string filterId, string filterBillable, string filterCarrierTypeCodes)

List all Carriers

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CarriersGetExample
    {
        public void main()
        {


            var apiInstance = new CarrierApi();
            var filterId = filterId_example;  // string | Filter by id (optional) 
            var filterBillable = filterBillable_example;  // string | Filter by billable (optional) 
            var filterCarrierTypeCodes = filterCarrierTypeCodes_example;  // string | Filter by carrier_type_codes (optional) 

            try
            {
                // List all Carriers
                InlineResponse20023 result = apiInstance.CarriersGet(filterId, filterBillable, filterCarrierTypeCodes);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CarrierApi.CarriersGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filterId** | **string**| Filter by id | [optional] 
 **filterBillable** | **string**| Filter by billable | [optional] 
 **filterCarrierTypeCodes** | **string**| Filter by carrier_type_codes | [optional] 

### Return type

[**InlineResponse20023**](InlineResponse20023.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="carriersiddelete"></a>
# **CarriersIdDelete**
> InlineResponse20022 CarriersIdDelete (int? id)

Delete a Carrier

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CarriersIdDeleteExample
    {
        public void main()
        {


            var apiInstance = new CarrierApi();
            var id = 56;  // int? | 

            try
            {
                // Delete a Carrier
                InlineResponse20022 result = apiInstance.CarriersIdDelete(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CarrierApi.CarriersIdDelete: " + e.Message );
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

[**InlineResponse20022**](InlineResponse20022.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="carriersidget"></a>
# **CarriersIdGet**
> InlineResponse20022 CarriersIdGet (int? id)

Show a single Carrier

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CarriersIdGetExample
    {
        public void main()
        {


            var apiInstance = new CarrierApi();
            var id = 56;  // int? | 

            try
            {
                // Show a single Carrier
                InlineResponse20022 result = apiInstance.CarriersIdGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CarrierApi.CarriersIdGet: " + e.Message );
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

[**InlineResponse20022**](InlineResponse20022.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="carriersidpatch"></a>
# **CarriersIdPatch**
> InlineResponse20022 CarriersIdPatch (CarriersIdBody body, int? id)

Update a Carrier

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CarriersIdPatchExample
    {
        public void main()
        {


            var apiInstance = new CarrierApi();
            var body = new CarriersIdBody(); // CarriersIdBody | 
            var id = 56;  // int? | 

            try
            {
                // Update a Carrier
                InlineResponse20022 result = apiInstance.CarriersIdPatch(body, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CarrierApi.CarriersIdPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CarriersIdBody**](CarriersIdBody.md)|  | 
 **id** | **int?**|  | 

### Return type

[**InlineResponse20022**](InlineResponse20022.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="carrierspost"></a>
# **CarriersPost**
> InlineResponse20022 CarriersPost (CarriersBody body)

Create a Carrier

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CarriersPostExample
    {
        public void main()
        {


            var apiInstance = new CarrierApi();
            var body = new CarriersBody(); // CarriersBody | 

            try
            {
                // Create a Carrier
                InlineResponse20022 result = apiInstance.CarriersPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CarrierApi.CarriersPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CarriersBody**](CarriersBody.md)|  | 

### Return type

[**InlineResponse20022**](InlineResponse20022.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

