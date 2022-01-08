# IO.Swagger.Api.RequeueablePrinterJobsApi

All URIs are relative to *https://{tenant}.api.webshipper.io/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**PrinterRequeueJobsGet**](RequeueablePrinterJobsApi.md#printerrequeuejobsget) | **GET** /printer_requeue_jobs | List all Requeueable Printer Jobss
[**PrinterRequeueJobsIdDelete**](RequeueablePrinterJobsApi.md#printerrequeuejobsiddelete) | **DELETE** /printer_requeue_jobs/{id} | Delete a Requeueable Printer Jobs
[**PrinterRequeueJobsIdGet**](RequeueablePrinterJobsApi.md#printerrequeuejobsidget) | **GET** /printer_requeue_jobs/{id} | Show a single Requeueable Printer Jobs
[**PrinterRequeueJobsIdPatch**](RequeueablePrinterJobsApi.md#printerrequeuejobsidpatch) | **PATCH** /printer_requeue_jobs/{id} | Update a Requeueable Printer Jobs
[**PrinterRequeueJobsPost**](RequeueablePrinterJobsApi.md#printerrequeuejobspost) | **POST** /printer_requeue_jobs | Create a Requeueable Printer Jobs

<a name="printerrequeuejobsget"></a>
# **PrinterRequeueJobsGet**
> InlineResponse20090 PrinterRequeueJobsGet (string filterId)

List all Requeueable Printer Jobss

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PrinterRequeueJobsGetExample
    {
        public void main()
        {


            var apiInstance = new RequeueablePrinterJobsApi();
            var filterId = filterId_example;  // string | Filter by id (optional) 

            try
            {
                // List all Requeueable Printer Jobss
                InlineResponse20090 result = apiInstance.PrinterRequeueJobsGet(filterId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RequeueablePrinterJobsApi.PrinterRequeueJobsGet: " + e.Message );
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

[**InlineResponse20090**](InlineResponse20090.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="printerrequeuejobsiddelete"></a>
# **PrinterRequeueJobsIdDelete**
> InlineResponse20089 PrinterRequeueJobsIdDelete (int? id)

Delete a Requeueable Printer Jobs

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PrinterRequeueJobsIdDeleteExample
    {
        public void main()
        {


            var apiInstance = new RequeueablePrinterJobsApi();
            var id = 56;  // int? | 

            try
            {
                // Delete a Requeueable Printer Jobs
                InlineResponse20089 result = apiInstance.PrinterRequeueJobsIdDelete(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RequeueablePrinterJobsApi.PrinterRequeueJobsIdDelete: " + e.Message );
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

[**InlineResponse20089**](InlineResponse20089.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="printerrequeuejobsidget"></a>
# **PrinterRequeueJobsIdGet**
> InlineResponse20089 PrinterRequeueJobsIdGet (int? id)

Show a single Requeueable Printer Jobs

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PrinterRequeueJobsIdGetExample
    {
        public void main()
        {


            var apiInstance = new RequeueablePrinterJobsApi();
            var id = 56;  // int? | 

            try
            {
                // Show a single Requeueable Printer Jobs
                InlineResponse20089 result = apiInstance.PrinterRequeueJobsIdGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RequeueablePrinterJobsApi.PrinterRequeueJobsIdGet: " + e.Message );
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

[**InlineResponse20089**](InlineResponse20089.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="printerrequeuejobsidpatch"></a>
# **PrinterRequeueJobsIdPatch**
> InlineResponse20089 PrinterRequeueJobsIdPatch (PrinterRequeueJobsIdBody body, int? id)

Update a Requeueable Printer Jobs

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PrinterRequeueJobsIdPatchExample
    {
        public void main()
        {


            var apiInstance = new RequeueablePrinterJobsApi();
            var body = new PrinterRequeueJobsIdBody(); // PrinterRequeueJobsIdBody | 
            var id = 56;  // int? | 

            try
            {
                // Update a Requeueable Printer Jobs
                InlineResponse20089 result = apiInstance.PrinterRequeueJobsIdPatch(body, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RequeueablePrinterJobsApi.PrinterRequeueJobsIdPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**PrinterRequeueJobsIdBody**](PrinterRequeueJobsIdBody.md)|  | 
 **id** | **int?**|  | 

### Return type

[**InlineResponse20089**](InlineResponse20089.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="printerrequeuejobspost"></a>
# **PrinterRequeueJobsPost**
> InlineResponse20089 PrinterRequeueJobsPost (PrinterRequeueJobsBody body)

Create a Requeueable Printer Jobs

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PrinterRequeueJobsPostExample
    {
        public void main()
        {


            var apiInstance = new RequeueablePrinterJobsApi();
            var body = new PrinterRequeueJobsBody(); // PrinterRequeueJobsBody | 

            try
            {
                // Create a Requeueable Printer Jobs
                InlineResponse20089 result = apiInstance.PrinterRequeueJobsPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RequeueablePrinterJobsApi.PrinterRequeueJobsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**PrinterRequeueJobsBody**](PrinterRequeueJobsBody.md)|  | 

### Return type

[**InlineResponse20089**](InlineResponse20089.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

