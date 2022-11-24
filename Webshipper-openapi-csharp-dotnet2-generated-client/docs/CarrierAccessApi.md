# IO.Swagger.Api.CarrierAccessApi

All URIs are relative to *https://{tenant}.api.webshipper.io/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CarrierAccessesGet**](CarrierAccessApi.md#carrieraccessesget) | **GET** /carrier_accesses | List all Carrier Accesss
[**CarrierAccessesIdDelete**](CarrierAccessApi.md#carrieraccessesiddelete) | **DELETE** /carrier_accesses/{id} | Delete a Carrier Access
[**CarrierAccessesIdGet**](CarrierAccessApi.md#carrieraccessesidget) | **GET** /carrier_accesses/{id} | Show a single Carrier Access
[**CarrierAccessesPost**](CarrierAccessApi.md#carrieraccessespost) | **POST** /carrier_accesses | Create a Carrier Access

<a name="carrieraccessesget"></a>
# **CarrierAccessesGet**
> InlineResponse20025 CarrierAccessesGet (string filterId)

List all Carrier Accesss

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CarrierAccessesGetExample
    {
        public void main()
        {


            var apiInstance = new CarrierAccessApi();
            var filterId = filterId_example;  // string | Filter by id (optional) 

            try
            {
                // List all Carrier Accesss
                InlineResponse20025 result = apiInstance.CarrierAccessesGet(filterId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CarrierAccessApi.CarrierAccessesGet: " + e.Message );
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

[**InlineResponse20025**](InlineResponse20025.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="carrieraccessesiddelete"></a>
# **CarrierAccessesIdDelete**
> InlineResponse20024 CarrierAccessesIdDelete (int? id)

Delete a Carrier Access

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CarrierAccessesIdDeleteExample
    {
        public void main()
        {


            var apiInstance = new CarrierAccessApi();
            var id = 56;  // int? | 

            try
            {
                // Delete a Carrier Access
                InlineResponse20024 result = apiInstance.CarrierAccessesIdDelete(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CarrierAccessApi.CarrierAccessesIdDelete: " + e.Message );
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

[**InlineResponse20024**](InlineResponse20024.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="carrieraccessesidget"></a>
# **CarrierAccessesIdGet**
> InlineResponse20024 CarrierAccessesIdGet (int? id)

Show a single Carrier Access

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CarrierAccessesIdGetExample
    {
        public void main()
        {


            var apiInstance = new CarrierAccessApi();
            var id = 56;  // int? | 

            try
            {
                // Show a single Carrier Access
                InlineResponse20024 result = apiInstance.CarrierAccessesIdGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CarrierAccessApi.CarrierAccessesIdGet: " + e.Message );
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

[**InlineResponse20024**](InlineResponse20024.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="carrieraccessespost"></a>
# **CarrierAccessesPost**
> InlineResponse20024 CarrierAccessesPost (CarrierAccessesBody body)

Create a Carrier Access

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CarrierAccessesPostExample
    {
        public void main()
        {


            var apiInstance = new CarrierAccessApi();
            var body = new CarrierAccessesBody(); // CarrierAccessesBody | 

            try
            {
                // Create a Carrier Access
                InlineResponse20024 result = apiInstance.CarrierAccessesPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CarrierAccessApi.CarrierAccessesPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CarrierAccessesBody**](CarrierAccessesBody.md)|  | 

### Return type

[**InlineResponse20024**](InlineResponse20024.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

