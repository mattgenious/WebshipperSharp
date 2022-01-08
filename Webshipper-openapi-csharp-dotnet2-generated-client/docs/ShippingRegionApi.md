# IO.Swagger.Api.ShippingRegionApi

All URIs are relative to *https://{tenant}.api.webshipper.io/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**RegionsGet**](ShippingRegionApi.md#regionsget) | **GET** /regions | List all Shipping Regions
[**RegionsIdDelete**](ShippingRegionApi.md#regionsiddelete) | **DELETE** /regions/{id} | Delete a Shipping Region
[**RegionsIdGet**](ShippingRegionApi.md#regionsidget) | **GET** /regions/{id} | Show a single Shipping Region
[**RegionsIdPatch**](ShippingRegionApi.md#regionsidpatch) | **PATCH** /regions/{id} | Update a Shipping Region
[**RegionsPost**](ShippingRegionApi.md#regionspost) | **POST** /regions | Create a Shipping Region

<a name="regionsget"></a>
# **RegionsGet**
> InlineResponse200108 RegionsGet (string filterId)

List all Shipping Regions

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RegionsGetExample
    {
        public void main()
        {


            var apiInstance = new ShippingRegionApi();
            var filterId = filterId_example;  // string | Filter by id (optional) 

            try
            {
                // List all Shipping Regions
                InlineResponse200108 result = apiInstance.RegionsGet(filterId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ShippingRegionApi.RegionsGet: " + e.Message );
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

[**InlineResponse200108**](InlineResponse200108.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="regionsiddelete"></a>
# **RegionsIdDelete**
> InlineResponse200107 RegionsIdDelete (int? id)

Delete a Shipping Region

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RegionsIdDeleteExample
    {
        public void main()
        {


            var apiInstance = new ShippingRegionApi();
            var id = 56;  // int? | 

            try
            {
                // Delete a Shipping Region
                InlineResponse200107 result = apiInstance.RegionsIdDelete(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ShippingRegionApi.RegionsIdDelete: " + e.Message );
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

[**InlineResponse200107**](InlineResponse200107.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="regionsidget"></a>
# **RegionsIdGet**
> InlineResponse200107 RegionsIdGet (int? id)

Show a single Shipping Region

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RegionsIdGetExample
    {
        public void main()
        {


            var apiInstance = new ShippingRegionApi();
            var id = 56;  // int? | 

            try
            {
                // Show a single Shipping Region
                InlineResponse200107 result = apiInstance.RegionsIdGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ShippingRegionApi.RegionsIdGet: " + e.Message );
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

[**InlineResponse200107**](InlineResponse200107.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="regionsidpatch"></a>
# **RegionsIdPatch**
> InlineResponse200107 RegionsIdPatch (RegionsIdBody body, int? id)

Update a Shipping Region

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RegionsIdPatchExample
    {
        public void main()
        {


            var apiInstance = new ShippingRegionApi();
            var body = new RegionsIdBody(); // RegionsIdBody | 
            var id = 56;  // int? | 

            try
            {
                // Update a Shipping Region
                InlineResponse200107 result = apiInstance.RegionsIdPatch(body, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ShippingRegionApi.RegionsIdPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RegionsIdBody**](RegionsIdBody.md)|  | 
 **id** | **int?**|  | 

### Return type

[**InlineResponse200107**](InlineResponse200107.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="regionspost"></a>
# **RegionsPost**
> InlineResponse200107 RegionsPost (RegionsBody body)

Create a Shipping Region

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RegionsPostExample
    {
        public void main()
        {


            var apiInstance = new ShippingRegionApi();
            var body = new RegionsBody(); // RegionsBody | 

            try
            {
                // Create a Shipping Region
                InlineResponse200107 result = apiInstance.RegionsPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ShippingRegionApi.RegionsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RegionsBody**](RegionsBody.md)|  | 

### Return type

[**InlineResponse200107**](InlineResponse200107.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

