# IO.Swagger.Api.PrinterJobApi

All URIs are relative to *https://{tenant}.api.webshipper.io/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**PrinterJobsGet**](PrinterJobApi.md#printerjobsget) | **GET** /printer_jobs | List all Printer Jobs
[**PrinterJobsIdDelete**](PrinterJobApi.md#printerjobsiddelete) | **DELETE** /printer_jobs/{id} | Delete a Printer Job
[**PrinterJobsIdGet**](PrinterJobApi.md#printerjobsidget) | **GET** /printer_jobs/{id} | Show a single Printer Job
[**PrinterJobsIdPatch**](PrinterJobApi.md#printerjobsidpatch) | **PATCH** /printer_jobs/{id} | Update a Printer Job
[**PrinterJobsPost**](PrinterJobApi.md#printerjobspost) | **POST** /printer_jobs | Create a Printer Job

<a name="printerjobsget"></a>
# **PrinterJobsGet**
> InlineResponse20084 PrinterJobsGet (string filterId, string filterPrinterClientId, string filterCreatedAt, string filterCompleted, string filterError, string filterTryCount, string filterPrinterId)

List all Printer Jobs

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PrinterJobsGetExample
    {
        public void main()
        {


            var apiInstance = new PrinterJobApi();
            var filterId = filterId_example;  // string | Filter by id (optional) 
            var filterPrinterClientId = filterPrinterClientId_example;  // string | Filter by printer_client_id (optional) 
            var filterCreatedAt = filterCreatedAt_example;  // string | Filter by created_at (optional) 
            var filterCompleted = filterCompleted_example;  // string | Filter by completed (optional) 
            var filterError = filterError_example;  // string | Filter by error (optional) 
            var filterTryCount = filterTryCount_example;  // string | Filter by try_count (optional) 
            var filterPrinterId = filterPrinterId_example;  // string | Filter by printer_id (optional) 

            try
            {
                // List all Printer Jobs
                InlineResponse20084 result = apiInstance.PrinterJobsGet(filterId, filterPrinterClientId, filterCreatedAt, filterCompleted, filterError, filterTryCount, filterPrinterId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PrinterJobApi.PrinterJobsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filterId** | **string**| Filter by id | [optional] 
 **filterPrinterClientId** | **string**| Filter by printer_client_id | [optional] 
 **filterCreatedAt** | **string**| Filter by created_at | [optional] 
 **filterCompleted** | **string**| Filter by completed | [optional] 
 **filterError** | **string**| Filter by error | [optional] 
 **filterTryCount** | **string**| Filter by try_count | [optional] 
 **filterPrinterId** | **string**| Filter by printer_id | [optional] 

### Return type

[**InlineResponse20084**](InlineResponse20084.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="printerjobsiddelete"></a>
# **PrinterJobsIdDelete**
> InlineResponse20083 PrinterJobsIdDelete (int? id)

Delete a Printer Job

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PrinterJobsIdDeleteExample
    {
        public void main()
        {


            var apiInstance = new PrinterJobApi();
            var id = 56;  // int? | 

            try
            {
                // Delete a Printer Job
                InlineResponse20083 result = apiInstance.PrinterJobsIdDelete(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PrinterJobApi.PrinterJobsIdDelete: " + e.Message );
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

[**InlineResponse20083**](InlineResponse20083.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="printerjobsidget"></a>
# **PrinterJobsIdGet**
> InlineResponse20083 PrinterJobsIdGet (int? id)

Show a single Printer Job

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PrinterJobsIdGetExample
    {
        public void main()
        {


            var apiInstance = new PrinterJobApi();
            var id = 56;  // int? | 

            try
            {
                // Show a single Printer Job
                InlineResponse20083 result = apiInstance.PrinterJobsIdGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PrinterJobApi.PrinterJobsIdGet: " + e.Message );
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

[**InlineResponse20083**](InlineResponse20083.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="printerjobsidpatch"></a>
# **PrinterJobsIdPatch**
> InlineResponse20083 PrinterJobsIdPatch (PrinterJobsIdBody body, int? id)

Update a Printer Job

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PrinterJobsIdPatchExample
    {
        public void main()
        {


            var apiInstance = new PrinterJobApi();
            var body = new PrinterJobsIdBody(); // PrinterJobsIdBody | 
            var id = 56;  // int? | 

            try
            {
                // Update a Printer Job
                InlineResponse20083 result = apiInstance.PrinterJobsIdPatch(body, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PrinterJobApi.PrinterJobsIdPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**PrinterJobsIdBody**](PrinterJobsIdBody.md)|  | 
 **id** | **int?**|  | 

### Return type

[**InlineResponse20083**](InlineResponse20083.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="printerjobspost"></a>
# **PrinterJobsPost**
> InlineResponse20083 PrinterJobsPost (PrinterJobsBody body)

Create a Printer Job

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PrinterJobsPostExample
    {
        public void main()
        {


            var apiInstance = new PrinterJobApi();
            var body = new PrinterJobsBody(); // PrinterJobsBody | 

            try
            {
                // Create a Printer Job
                InlineResponse20083 result = apiInstance.PrinterJobsPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PrinterJobApi.PrinterJobsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**PrinterJobsBody**](PrinterJobsBody.md)|  | 

### Return type

[**InlineResponse20083**](InlineResponse20083.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

