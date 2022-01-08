# IO.Swagger.Api.EndOfDayReportApi

All URIs are relative to *https://{tenant}.api.webshipper.io/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**EndOfDayReportsGet**](EndOfDayReportApi.md#endofdayreportsget) | **GET** /end_of_day_reports | List all End-of-day reports
[**EndOfDayReportsIdDelete**](EndOfDayReportApi.md#endofdayreportsiddelete) | **DELETE** /end_of_day_reports/{id} | Delete a End-of-day report
[**EndOfDayReportsIdGet**](EndOfDayReportApi.md#endofdayreportsidget) | **GET** /end_of_day_reports/{id} | Show a single End-of-day report
[**EndOfDayReportsIdPatch**](EndOfDayReportApi.md#endofdayreportsidpatch) | **PATCH** /end_of_day_reports/{id} | Update a End-of-day report
[**EndOfDayReportsPost**](EndOfDayReportApi.md#endofdayreportspost) | **POST** /end_of_day_reports | Create a End-of-day report

<a name="endofdayreportsget"></a>
# **EndOfDayReportsGet**
> InlineResponse20035 EndOfDayReportsGet (string filterId)

List all End-of-day reports

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class EndOfDayReportsGetExample
    {
        public void main()
        {


            var apiInstance = new EndOfDayReportApi();
            var filterId = filterId_example;  // string | Filter by id (optional) 

            try
            {
                // List all End-of-day reports
                InlineResponse20035 result = apiInstance.EndOfDayReportsGet(filterId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EndOfDayReportApi.EndOfDayReportsGet: " + e.Message );
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

[**InlineResponse20035**](InlineResponse20035.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="endofdayreportsiddelete"></a>
# **EndOfDayReportsIdDelete**
> InlineResponse20034 EndOfDayReportsIdDelete (int? id)

Delete a End-of-day report

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class EndOfDayReportsIdDeleteExample
    {
        public void main()
        {


            var apiInstance = new EndOfDayReportApi();
            var id = 56;  // int? | 

            try
            {
                // Delete a End-of-day report
                InlineResponse20034 result = apiInstance.EndOfDayReportsIdDelete(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EndOfDayReportApi.EndOfDayReportsIdDelete: " + e.Message );
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

[**InlineResponse20034**](InlineResponse20034.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="endofdayreportsidget"></a>
# **EndOfDayReportsIdGet**
> InlineResponse20034 EndOfDayReportsIdGet (int? id)

Show a single End-of-day report

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class EndOfDayReportsIdGetExample
    {
        public void main()
        {


            var apiInstance = new EndOfDayReportApi();
            var id = 56;  // int? | 

            try
            {
                // Show a single End-of-day report
                InlineResponse20034 result = apiInstance.EndOfDayReportsIdGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EndOfDayReportApi.EndOfDayReportsIdGet: " + e.Message );
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

[**InlineResponse20034**](InlineResponse20034.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="endofdayreportsidpatch"></a>
# **EndOfDayReportsIdPatch**
> InlineResponse20034 EndOfDayReportsIdPatch (EndOfDayReportsIdBody body, int? id)

Update a End-of-day report

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class EndOfDayReportsIdPatchExample
    {
        public void main()
        {


            var apiInstance = new EndOfDayReportApi();
            var body = new EndOfDayReportsIdBody(); // EndOfDayReportsIdBody | 
            var id = 56;  // int? | 

            try
            {
                // Update a End-of-day report
                InlineResponse20034 result = apiInstance.EndOfDayReportsIdPatch(body, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EndOfDayReportApi.EndOfDayReportsIdPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**EndOfDayReportsIdBody**](EndOfDayReportsIdBody.md)|  | 
 **id** | **int?**|  | 

### Return type

[**InlineResponse20034**](InlineResponse20034.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="endofdayreportspost"></a>
# **EndOfDayReportsPost**
> InlineResponse20034 EndOfDayReportsPost (EndOfDayReportsBody body)

Create a End-of-day report

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class EndOfDayReportsPostExample
    {
        public void main()
        {


            var apiInstance = new EndOfDayReportApi();
            var body = new EndOfDayReportsBody(); // EndOfDayReportsBody | 

            try
            {
                // Create a End-of-day report
                InlineResponse20034 result = apiInstance.EndOfDayReportsPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EndOfDayReportApi.EndOfDayReportsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**EndOfDayReportsBody**](EndOfDayReportsBody.md)|  | 

### Return type

[**InlineResponse20034**](InlineResponse20034.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

