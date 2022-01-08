# IO.Swagger.Api.ErrorTypeApi

All URIs are relative to *https://{tenant}.api.webshipper.io/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ErrorTypesGet**](ErrorTypeApi.md#errortypesget) | **GET** /error_types | List all Error Types
[**ErrorTypesIdDelete**](ErrorTypeApi.md#errortypesiddelete) | **DELETE** /error_types/{id} | Delete a Error Type
[**ErrorTypesIdGet**](ErrorTypeApi.md#errortypesidget) | **GET** /error_types/{id} | Show a single Error Type
[**ErrorTypesIdPatch**](ErrorTypeApi.md#errortypesidpatch) | **PATCH** /error_types/{id} | Update a Error Type
[**ErrorTypesPost**](ErrorTypeApi.md#errortypespost) | **POST** /error_types | Create a Error Type

<a name="errortypesget"></a>
# **ErrorTypesGet**
> InlineResponse20037 ErrorTypesGet (string filterId)

List all Error Types

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ErrorTypesGetExample
    {
        public void main()
        {


            var apiInstance = new ErrorTypeApi();
            var filterId = filterId_example;  // string | Filter by id (optional) 

            try
            {
                // List all Error Types
                InlineResponse20037 result = apiInstance.ErrorTypesGet(filterId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ErrorTypeApi.ErrorTypesGet: " + e.Message );
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

[**InlineResponse20037**](InlineResponse20037.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="errortypesiddelete"></a>
# **ErrorTypesIdDelete**
> InlineResponse20036 ErrorTypesIdDelete (int? id)

Delete a Error Type

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ErrorTypesIdDeleteExample
    {
        public void main()
        {


            var apiInstance = new ErrorTypeApi();
            var id = 56;  // int? | 

            try
            {
                // Delete a Error Type
                InlineResponse20036 result = apiInstance.ErrorTypesIdDelete(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ErrorTypeApi.ErrorTypesIdDelete: " + e.Message );
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

[**InlineResponse20036**](InlineResponse20036.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="errortypesidget"></a>
# **ErrorTypesIdGet**
> InlineResponse20036 ErrorTypesIdGet (int? id)

Show a single Error Type

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ErrorTypesIdGetExample
    {
        public void main()
        {


            var apiInstance = new ErrorTypeApi();
            var id = 56;  // int? | 

            try
            {
                // Show a single Error Type
                InlineResponse20036 result = apiInstance.ErrorTypesIdGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ErrorTypeApi.ErrorTypesIdGet: " + e.Message );
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

[**InlineResponse20036**](InlineResponse20036.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="errortypesidpatch"></a>
# **ErrorTypesIdPatch**
> InlineResponse20036 ErrorTypesIdPatch (ErrorTypesIdBody body, int? id)

Update a Error Type

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ErrorTypesIdPatchExample
    {
        public void main()
        {


            var apiInstance = new ErrorTypeApi();
            var body = new ErrorTypesIdBody(); // ErrorTypesIdBody | 
            var id = 56;  // int? | 

            try
            {
                // Update a Error Type
                InlineResponse20036 result = apiInstance.ErrorTypesIdPatch(body, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ErrorTypeApi.ErrorTypesIdPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ErrorTypesIdBody**](ErrorTypesIdBody.md)|  | 
 **id** | **int?**|  | 

### Return type

[**InlineResponse20036**](InlineResponse20036.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="errortypespost"></a>
# **ErrorTypesPost**
> InlineResponse20036 ErrorTypesPost (ErrorTypesBody body)

Create a Error Type

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ErrorTypesPostExample
    {
        public void main()
        {


            var apiInstance = new ErrorTypeApi();
            var body = new ErrorTypesBody(); // ErrorTypesBody | 

            try
            {
                // Create a Error Type
                InlineResponse20036 result = apiInstance.ErrorTypesPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ErrorTypeApi.ErrorTypesPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ErrorTypesBody**](ErrorTypesBody.md)|  | 

### Return type

[**InlineResponse20036**](InlineResponse20036.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

