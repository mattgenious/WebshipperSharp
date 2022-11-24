# IO.Swagger.Api.ReportApi

All URIs are relative to *https://{tenant}.api.webshipper.io/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ReportsGet**](ReportApi.md#reportsget) | **GET** /reports | List all Reports
[**ReportsIdDelete**](ReportApi.md#reportsiddelete) | **DELETE** /reports/{id} | Delete a Report
[**ReportsIdGet**](ReportApi.md#reportsidget) | **GET** /reports/{id} | Show a single Report
[**ReportsIdPatch**](ReportApi.md#reportsidpatch) | **PATCH** /reports/{id} | Update a Report
[**ReportsPost**](ReportApi.md#reportspost) | **POST** /reports | Create a Report

<a name="reportsget"></a>
# **ReportsGet**
> InlineResponse20086 ReportsGet (string filterId)

List all Reports

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ReportsGetExample
    {
        public void main()
        {


            var apiInstance = new ReportApi();
            var filterId = filterId_example;  // string | Filter by id (optional) 

            try
            {
                // List all Reports
                InlineResponse20086 result = apiInstance.ReportsGet(filterId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportApi.ReportsGet: " + e.Message );
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

[**InlineResponse20086**](InlineResponse20086.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reportsiddelete"></a>
# **ReportsIdDelete**
> InlineResponse20085 ReportsIdDelete (int? id)

Delete a Report

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ReportsIdDeleteExample
    {
        public void main()
        {


            var apiInstance = new ReportApi();
            var id = 56;  // int? | 

            try
            {
                // Delete a Report
                InlineResponse20085 result = apiInstance.ReportsIdDelete(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportApi.ReportsIdDelete: " + e.Message );
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

[**InlineResponse20085**](InlineResponse20085.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reportsidget"></a>
# **ReportsIdGet**
> InlineResponse20085 ReportsIdGet (int? id)

Show a single Report

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ReportsIdGetExample
    {
        public void main()
        {


            var apiInstance = new ReportApi();
            var id = 56;  // int? | 

            try
            {
                // Show a single Report
                InlineResponse20085 result = apiInstance.ReportsIdGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportApi.ReportsIdGet: " + e.Message );
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

[**InlineResponse20085**](InlineResponse20085.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reportsidpatch"></a>
# **ReportsIdPatch**
> InlineResponse20085 ReportsIdPatch (ReportsIdBody body, int? id)

Update a Report

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ReportsIdPatchExample
    {
        public void main()
        {


            var apiInstance = new ReportApi();
            var body = new ReportsIdBody(); // ReportsIdBody | 
            var id = 56;  // int? | 

            try
            {
                // Update a Report
                InlineResponse20085 result = apiInstance.ReportsIdPatch(body, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportApi.ReportsIdPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ReportsIdBody**](ReportsIdBody.md)|  | 
 **id** | **int?**|  | 

### Return type

[**InlineResponse20085**](InlineResponse20085.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reportspost"></a>
# **ReportsPost**
> InlineResponse20085 ReportsPost (ReportsBody body)

Create a Report

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ReportsPostExample
    {
        public void main()
        {


            var apiInstance = new ReportApi();
            var body = new ReportsBody(); // ReportsBody | 

            try
            {
                // Create a Report
                InlineResponse20085 result = apiInstance.ReportsPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportApi.ReportsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ReportsBody**](ReportsBody.md)|  | 

### Return type

[**InlineResponse20085**](InlineResponse20085.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

