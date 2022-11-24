# IO.Swagger.Api.CustomsLineApi

All URIs are relative to *https://{tenant}.api.webshipper.io/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CustomsLinesGet**](CustomsLineApi.md#customslinesget) | **GET** /customs_lines | List all Customs Lines
[**CustomsLinesIdDelete**](CustomsLineApi.md#customslinesiddelete) | **DELETE** /customs_lines/{id} | Delete a Customs Line
[**CustomsLinesIdGet**](CustomsLineApi.md#customslinesidget) | **GET** /customs_lines/{id} | Show a single Customs Line
[**CustomsLinesIdPatch**](CustomsLineApi.md#customslinesidpatch) | **PATCH** /customs_lines/{id} | Update a Customs Line
[**CustomsLinesPost**](CustomsLineApi.md#customslinespost) | **POST** /customs_lines | Create a Customs Line

<a name="customslinesget"></a>
# **CustomsLinesGet**
> InlineResponse20029 CustomsLinesGet (string filterId)

List all Customs Lines

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CustomsLinesGetExample
    {
        public void main()
        {


            var apiInstance = new CustomsLineApi();
            var filterId = filterId_example;  // string | Filter by id (optional) 

            try
            {
                // List all Customs Lines
                InlineResponse20029 result = apiInstance.CustomsLinesGet(filterId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomsLineApi.CustomsLinesGet: " + e.Message );
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

[**InlineResponse20029**](InlineResponse20029.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customslinesiddelete"></a>
# **CustomsLinesIdDelete**
> InlineResponse20028 CustomsLinesIdDelete (int? id)

Delete a Customs Line

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CustomsLinesIdDeleteExample
    {
        public void main()
        {


            var apiInstance = new CustomsLineApi();
            var id = 56;  // int? | 

            try
            {
                // Delete a Customs Line
                InlineResponse20028 result = apiInstance.CustomsLinesIdDelete(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomsLineApi.CustomsLinesIdDelete: " + e.Message );
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

[**InlineResponse20028**](InlineResponse20028.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customslinesidget"></a>
# **CustomsLinesIdGet**
> InlineResponse20028 CustomsLinesIdGet (int? id)

Show a single Customs Line

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CustomsLinesIdGetExample
    {
        public void main()
        {


            var apiInstance = new CustomsLineApi();
            var id = 56;  // int? | 

            try
            {
                // Show a single Customs Line
                InlineResponse20028 result = apiInstance.CustomsLinesIdGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomsLineApi.CustomsLinesIdGet: " + e.Message );
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

[**InlineResponse20028**](InlineResponse20028.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customslinesidpatch"></a>
# **CustomsLinesIdPatch**
> InlineResponse20028 CustomsLinesIdPatch (CustomsLinesIdBody body, int? id)

Update a Customs Line

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CustomsLinesIdPatchExample
    {
        public void main()
        {


            var apiInstance = new CustomsLineApi();
            var body = new CustomsLinesIdBody(); // CustomsLinesIdBody | 
            var id = 56;  // int? | 

            try
            {
                // Update a Customs Line
                InlineResponse20028 result = apiInstance.CustomsLinesIdPatch(body, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomsLineApi.CustomsLinesIdPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CustomsLinesIdBody**](CustomsLinesIdBody.md)|  | 
 **id** | **int?**|  | 

### Return type

[**InlineResponse20028**](InlineResponse20028.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customslinespost"></a>
# **CustomsLinesPost**
> InlineResponse20028 CustomsLinesPost (CustomsLinesBody body)

Create a Customs Line

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CustomsLinesPostExample
    {
        public void main()
        {


            var apiInstance = new CustomsLineApi();
            var body = new CustomsLinesBody(); // CustomsLinesBody | 

            try
            {
                // Create a Customs Line
                InlineResponse20028 result = apiInstance.CustomsLinesPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomsLineApi.CustomsLinesPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CustomsLinesBody**](CustomsLinesBody.md)|  | 

### Return type

[**InlineResponse20028**](InlineResponse20028.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

