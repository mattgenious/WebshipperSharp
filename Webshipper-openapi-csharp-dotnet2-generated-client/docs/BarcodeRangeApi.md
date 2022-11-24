# IO.Swagger.Api.BarcodeRangeApi

All URIs are relative to *https://{tenant}.api.webshipper.io/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**BarcodeRangesGet**](BarcodeRangeApi.md#barcoderangesget) | **GET** /barcode_ranges | List all Barcode Ranges
[**BarcodeRangesIdDelete**](BarcodeRangeApi.md#barcoderangesiddelete) | **DELETE** /barcode_ranges/{id} | Delete a Barcode Range
[**BarcodeRangesIdGet**](BarcodeRangeApi.md#barcoderangesidget) | **GET** /barcode_ranges/{id} | Show a single Barcode Range
[**BarcodeRangesIdPatch**](BarcodeRangeApi.md#barcoderangesidpatch) | **PATCH** /barcode_ranges/{id} | Update a Barcode Range
[**BarcodeRangesPost**](BarcodeRangeApi.md#barcoderangespost) | **POST** /barcode_ranges | Create a Barcode Range

<a name="barcoderangesget"></a>
# **BarcodeRangesGet**
> InlineResponse20015 BarcodeRangesGet (string filterId)

List all Barcode Ranges

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class BarcodeRangesGetExample
    {
        public void main()
        {


            var apiInstance = new BarcodeRangeApi();
            var filterId = filterId_example;  // string | Filter by id (optional) 

            try
            {
                // List all Barcode Ranges
                InlineResponse20015 result = apiInstance.BarcodeRangesGet(filterId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BarcodeRangeApi.BarcodeRangesGet: " + e.Message );
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

[**InlineResponse20015**](InlineResponse20015.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="barcoderangesiddelete"></a>
# **BarcodeRangesIdDelete**
> InlineResponse20014 BarcodeRangesIdDelete (int? id)

Delete a Barcode Range

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class BarcodeRangesIdDeleteExample
    {
        public void main()
        {


            var apiInstance = new BarcodeRangeApi();
            var id = 56;  // int? | 

            try
            {
                // Delete a Barcode Range
                InlineResponse20014 result = apiInstance.BarcodeRangesIdDelete(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BarcodeRangeApi.BarcodeRangesIdDelete: " + e.Message );
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

[**InlineResponse20014**](InlineResponse20014.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="barcoderangesidget"></a>
# **BarcodeRangesIdGet**
> InlineResponse20014 BarcodeRangesIdGet (int? id)

Show a single Barcode Range

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class BarcodeRangesIdGetExample
    {
        public void main()
        {


            var apiInstance = new BarcodeRangeApi();
            var id = 56;  // int? | 

            try
            {
                // Show a single Barcode Range
                InlineResponse20014 result = apiInstance.BarcodeRangesIdGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BarcodeRangeApi.BarcodeRangesIdGet: " + e.Message );
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

[**InlineResponse20014**](InlineResponse20014.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="barcoderangesidpatch"></a>
# **BarcodeRangesIdPatch**
> InlineResponse20014 BarcodeRangesIdPatch (BarcodeRangesIdBody body, int? id)

Update a Barcode Range

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class BarcodeRangesIdPatchExample
    {
        public void main()
        {


            var apiInstance = new BarcodeRangeApi();
            var body = new BarcodeRangesIdBody(); // BarcodeRangesIdBody | 
            var id = 56;  // int? | 

            try
            {
                // Update a Barcode Range
                InlineResponse20014 result = apiInstance.BarcodeRangesIdPatch(body, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BarcodeRangeApi.BarcodeRangesIdPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**BarcodeRangesIdBody**](BarcodeRangesIdBody.md)|  | 
 **id** | **int?**|  | 

### Return type

[**InlineResponse20014**](InlineResponse20014.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="barcoderangespost"></a>
# **BarcodeRangesPost**
> InlineResponse20014 BarcodeRangesPost (BarcodeRangesBody body)

Create a Barcode Range

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class BarcodeRangesPostExample
    {
        public void main()
        {


            var apiInstance = new BarcodeRangeApi();
            var body = new BarcodeRangesBody(); // BarcodeRangesBody | 

            try
            {
                // Create a Barcode Range
                InlineResponse20014 result = apiInstance.BarcodeRangesPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BarcodeRangeApi.BarcodeRangesPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**BarcodeRangesBody**](BarcodeRangesBody.md)|  | 

### Return type

[**InlineResponse20014**](InlineResponse20014.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

