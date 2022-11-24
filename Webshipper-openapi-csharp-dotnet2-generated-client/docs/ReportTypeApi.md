# IO.Swagger.Api.ReportTypeApi

All URIs are relative to *https://{tenant}.api.webshipper.io/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ReportTypesGet**](ReportTypeApi.md#reporttypesget) | **GET** /report_types | List all Report Types
[**ReportTypesIdDelete**](ReportTypeApi.md#reporttypesiddelete) | **DELETE** /report_types/{id} | Delete a Report Type
[**ReportTypesIdGet**](ReportTypeApi.md#reporttypesidget) | **GET** /report_types/{id} | Show a single Report Type
[**ReportTypesIdPatch**](ReportTypeApi.md#reporttypesidpatch) | **PATCH** /report_types/{id} | Update a Report Type
[**ReportTypesPost**](ReportTypeApi.md#reporttypespost) | **POST** /report_types | Create a Report Type

<a name="reporttypesget"></a>
# **ReportTypesGet**
> InlineResponse20088 ReportTypesGet (string filterId)

List all Report Types

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ReportTypesGetExample
    {
        public void main()
        {


            var apiInstance = new ReportTypeApi();
            var filterId = filterId_example;  // string | Filter by id (optional) 

            try
            {
                // List all Report Types
                InlineResponse20088 result = apiInstance.ReportTypesGet(filterId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportTypeApi.ReportTypesGet: " + e.Message );
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

[**InlineResponse20088**](InlineResponse20088.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reporttypesiddelete"></a>
# **ReportTypesIdDelete**
> InlineResponse20087 ReportTypesIdDelete (int? id)

Delete a Report Type

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ReportTypesIdDeleteExample
    {
        public void main()
        {


            var apiInstance = new ReportTypeApi();
            var id = 56;  // int? | 

            try
            {
                // Delete a Report Type
                InlineResponse20087 result = apiInstance.ReportTypesIdDelete(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportTypeApi.ReportTypesIdDelete: " + e.Message );
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

[**InlineResponse20087**](InlineResponse20087.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reporttypesidget"></a>
# **ReportTypesIdGet**
> InlineResponse20087 ReportTypesIdGet (int? id)

Show a single Report Type

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ReportTypesIdGetExample
    {
        public void main()
        {


            var apiInstance = new ReportTypeApi();
            var id = 56;  // int? | 

            try
            {
                // Show a single Report Type
                InlineResponse20087 result = apiInstance.ReportTypesIdGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportTypeApi.ReportTypesIdGet: " + e.Message );
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

[**InlineResponse20087**](InlineResponse20087.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reporttypesidpatch"></a>
# **ReportTypesIdPatch**
> InlineResponse20087 ReportTypesIdPatch (ReportTypesIdBody body, int? id)

Update a Report Type

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ReportTypesIdPatchExample
    {
        public void main()
        {


            var apiInstance = new ReportTypeApi();
            var body = new ReportTypesIdBody(); // ReportTypesIdBody | 
            var id = 56;  // int? | 

            try
            {
                // Update a Report Type
                InlineResponse20087 result = apiInstance.ReportTypesIdPatch(body, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportTypeApi.ReportTypesIdPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ReportTypesIdBody**](ReportTypesIdBody.md)|  | 
 **id** | **int?**|  | 

### Return type

[**InlineResponse20087**](InlineResponse20087.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reporttypespost"></a>
# **ReportTypesPost**
> InlineResponse20087 ReportTypesPost (ReportTypesBody body)

Create a Report Type

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ReportTypesPostExample
    {
        public void main()
        {


            var apiInstance = new ReportTypeApi();
            var body = new ReportTypesBody(); // ReportTypesBody | 

            try
            {
                // Create a Report Type
                InlineResponse20087 result = apiInstance.ReportTypesPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportTypeApi.ReportTypesPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ReportTypesBody**](ReportTypesBody.md)|  | 

### Return type

[**InlineResponse20087**](InlineResponse20087.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

