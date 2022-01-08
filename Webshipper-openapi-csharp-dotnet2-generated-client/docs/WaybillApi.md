# IO.Swagger.Api.WaybillApi

All URIs are relative to *https://{tenant}.api.webshipper.io/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**WaybillsGet**](WaybillApi.md#waybillsget) | **GET** /waybills | List all Waybills
[**WaybillsIdDelete**](WaybillApi.md#waybillsiddelete) | **DELETE** /waybills/{id} | Delete a Waybill
[**WaybillsIdGet**](WaybillApi.md#waybillsidget) | **GET** /waybills/{id} | Show a single Waybill
[**WaybillsIdPatch**](WaybillApi.md#waybillsidpatch) | **PATCH** /waybills/{id} | Update a Waybill
[**WaybillsPost**](WaybillApi.md#waybillspost) | **POST** /waybills | Create a Waybill

<a name="waybillsget"></a>
# **WaybillsGet**
> InlineResponse200125 WaybillsGet (string filterId)

List all Waybills

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class WaybillsGetExample
    {
        public void main()
        {


            var apiInstance = new WaybillApi();
            var filterId = filterId_example;  // string | Filter by id (optional) 

            try
            {
                // List all Waybills
                InlineResponse200125 result = apiInstance.WaybillsGet(filterId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WaybillApi.WaybillsGet: " + e.Message );
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

[**InlineResponse200125**](InlineResponse200125.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="waybillsiddelete"></a>
# **WaybillsIdDelete**
> InlineResponse200124 WaybillsIdDelete (int? id)

Delete a Waybill

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class WaybillsIdDeleteExample
    {
        public void main()
        {


            var apiInstance = new WaybillApi();
            var id = 56;  // int? | 

            try
            {
                // Delete a Waybill
                InlineResponse200124 result = apiInstance.WaybillsIdDelete(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WaybillApi.WaybillsIdDelete: " + e.Message );
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

[**InlineResponse200124**](InlineResponse200124.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="waybillsidget"></a>
# **WaybillsIdGet**
> InlineResponse200124 WaybillsIdGet (int? id)

Show a single Waybill

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class WaybillsIdGetExample
    {
        public void main()
        {


            var apiInstance = new WaybillApi();
            var id = 56;  // int? | 

            try
            {
                // Show a single Waybill
                InlineResponse200124 result = apiInstance.WaybillsIdGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WaybillApi.WaybillsIdGet: " + e.Message );
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

[**InlineResponse200124**](InlineResponse200124.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="waybillsidpatch"></a>
# **WaybillsIdPatch**
> InlineResponse200124 WaybillsIdPatch (WaybillsIdBody body, int? id)

Update a Waybill

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class WaybillsIdPatchExample
    {
        public void main()
        {


            var apiInstance = new WaybillApi();
            var body = new WaybillsIdBody(); // WaybillsIdBody | 
            var id = 56;  // int? | 

            try
            {
                // Update a Waybill
                InlineResponse200124 result = apiInstance.WaybillsIdPatch(body, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WaybillApi.WaybillsIdPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**WaybillsIdBody**](WaybillsIdBody.md)|  | 
 **id** | **int?**|  | 

### Return type

[**InlineResponse200124**](InlineResponse200124.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="waybillspost"></a>
# **WaybillsPost**
> InlineResponse200124 WaybillsPost (WaybillsBody body)

Create a Waybill

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class WaybillsPostExample
    {
        public void main()
        {


            var apiInstance = new WaybillApi();
            var body = new WaybillsBody(); // WaybillsBody | 

            try
            {
                // Create a Waybill
                InlineResponse200124 result = apiInstance.WaybillsPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WaybillApi.WaybillsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**WaybillsBody**](WaybillsBody.md)|  | 

### Return type

[**InlineResponse200124**](InlineResponse200124.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

