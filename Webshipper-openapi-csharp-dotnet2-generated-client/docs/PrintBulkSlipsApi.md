# IO.Swagger.Api.PrintBulkSlipsApi

All URIs are relative to *https://{tenant}.api.webshipper.io/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**BulkPrinterJobsGet**](PrintBulkSlipsApi.md#bulkprinterjobsget) | **GET** /bulk_printer_jobs | List all Print Bulk Slipss
[**BulkPrinterJobsIdDelete**](PrintBulkSlipsApi.md#bulkprinterjobsiddelete) | **DELETE** /bulk_printer_jobs/{id} | Delete a Print Bulk Slips
[**BulkPrinterJobsIdGet**](PrintBulkSlipsApi.md#bulkprinterjobsidget) | **GET** /bulk_printer_jobs/{id} | Show a single Print Bulk Slips
[**BulkPrinterJobsIdPatch**](PrintBulkSlipsApi.md#bulkprinterjobsidpatch) | **PATCH** /bulk_printer_jobs/{id} | Update a Print Bulk Slips
[**BulkPrinterJobsPost**](PrintBulkSlipsApi.md#bulkprinterjobspost) | **POST** /bulk_printer_jobs | Create a Print Bulk Slips

<a name="bulkprinterjobsget"></a>
# **BulkPrinterJobsGet**
> InlineResponse20076 BulkPrinterJobsGet (string filterId)

List all Print Bulk Slipss

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class BulkPrinterJobsGetExample
    {
        public void main()
        {


            var apiInstance = new PrintBulkSlipsApi();
            var filterId = filterId_example;  // string | Filter by id (optional) 

            try
            {
                // List all Print Bulk Slipss
                InlineResponse20076 result = apiInstance.BulkPrinterJobsGet(filterId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PrintBulkSlipsApi.BulkPrinterJobsGet: " + e.Message );
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

[**InlineResponse20076**](InlineResponse20076.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="bulkprinterjobsiddelete"></a>
# **BulkPrinterJobsIdDelete**
> InlineResponse20075 BulkPrinterJobsIdDelete (int? id)

Delete a Print Bulk Slips

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class BulkPrinterJobsIdDeleteExample
    {
        public void main()
        {


            var apiInstance = new PrintBulkSlipsApi();
            var id = 56;  // int? | 

            try
            {
                // Delete a Print Bulk Slips
                InlineResponse20075 result = apiInstance.BulkPrinterJobsIdDelete(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PrintBulkSlipsApi.BulkPrinterJobsIdDelete: " + e.Message );
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

[**InlineResponse20075**](InlineResponse20075.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="bulkprinterjobsidget"></a>
# **BulkPrinterJobsIdGet**
> InlineResponse20075 BulkPrinterJobsIdGet (int? id)

Show a single Print Bulk Slips

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class BulkPrinterJobsIdGetExample
    {
        public void main()
        {


            var apiInstance = new PrintBulkSlipsApi();
            var id = 56;  // int? | 

            try
            {
                // Show a single Print Bulk Slips
                InlineResponse20075 result = apiInstance.BulkPrinterJobsIdGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PrintBulkSlipsApi.BulkPrinterJobsIdGet: " + e.Message );
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

[**InlineResponse20075**](InlineResponse20075.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="bulkprinterjobsidpatch"></a>
# **BulkPrinterJobsIdPatch**
> InlineResponse20075 BulkPrinterJobsIdPatch (BulkPrinterJobsIdBody body, int? id)

Update a Print Bulk Slips

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class BulkPrinterJobsIdPatchExample
    {
        public void main()
        {


            var apiInstance = new PrintBulkSlipsApi();
            var body = new BulkPrinterJobsIdBody(); // BulkPrinterJobsIdBody | 
            var id = 56;  // int? | 

            try
            {
                // Update a Print Bulk Slips
                InlineResponse20075 result = apiInstance.BulkPrinterJobsIdPatch(body, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PrintBulkSlipsApi.BulkPrinterJobsIdPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**BulkPrinterJobsIdBody**](BulkPrinterJobsIdBody.md)|  | 
 **id** | **int?**|  | 

### Return type

[**InlineResponse20075**](InlineResponse20075.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="bulkprinterjobspost"></a>
# **BulkPrinterJobsPost**
> InlineResponse20075 BulkPrinterJobsPost (BulkPrinterJobsBody body)

Create a Print Bulk Slips

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class BulkPrinterJobsPostExample
    {
        public void main()
        {


            var apiInstance = new PrintBulkSlipsApi();
            var body = new BulkPrinterJobsBody(); // BulkPrinterJobsBody | 

            try
            {
                // Create a Print Bulk Slips
                InlineResponse20075 result = apiInstance.BulkPrinterJobsPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PrintBulkSlipsApi.BulkPrinterJobsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**BulkPrinterJobsBody**](BulkPrinterJobsBody.md)|  | 

### Return type

[**InlineResponse20075**](InlineResponse20075.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

