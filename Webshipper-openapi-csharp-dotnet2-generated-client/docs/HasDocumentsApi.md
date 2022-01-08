# IO.Swagger.Api.HasDocumentsApi

All URIs are relative to *https://{tenant}.api.webshipper.io/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**HasDocumentsGet**](HasDocumentsApi.md#hasdocumentsget) | **GET** /has_documents | List all Has Documentss
[**HasDocumentsIdDelete**](HasDocumentsApi.md#hasdocumentsiddelete) | **DELETE** /has_documents/{id} | Delete a Has Documents
[**HasDocumentsIdGet**](HasDocumentsApi.md#hasdocumentsidget) | **GET** /has_documents/{id} | Show a single Has Documents
[**HasDocumentsIdPatch**](HasDocumentsApi.md#hasdocumentsidpatch) | **PATCH** /has_documents/{id} | Update a Has Documents
[**HasDocumentsPost**](HasDocumentsApi.md#hasdocumentspost) | **POST** /has_documents | Create a Has Documents

<a name="hasdocumentsget"></a>
# **HasDocumentsGet**
> InlineResponse20045 HasDocumentsGet (string filterId)

List all Has Documentss

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class HasDocumentsGetExample
    {
        public void main()
        {


            var apiInstance = new HasDocumentsApi();
            var filterId = filterId_example;  // string | Filter by id (optional) 

            try
            {
                // List all Has Documentss
                InlineResponse20045 result = apiInstance.HasDocumentsGet(filterId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HasDocumentsApi.HasDocumentsGet: " + e.Message );
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

[**InlineResponse20045**](InlineResponse20045.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="hasdocumentsiddelete"></a>
# **HasDocumentsIdDelete**
> InlineResponse20044 HasDocumentsIdDelete (int? id)

Delete a Has Documents

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class HasDocumentsIdDeleteExample
    {
        public void main()
        {


            var apiInstance = new HasDocumentsApi();
            var id = 56;  // int? | 

            try
            {
                // Delete a Has Documents
                InlineResponse20044 result = apiInstance.HasDocumentsIdDelete(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HasDocumentsApi.HasDocumentsIdDelete: " + e.Message );
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

[**InlineResponse20044**](InlineResponse20044.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="hasdocumentsidget"></a>
# **HasDocumentsIdGet**
> InlineResponse20044 HasDocumentsIdGet (int? id)

Show a single Has Documents

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class HasDocumentsIdGetExample
    {
        public void main()
        {


            var apiInstance = new HasDocumentsApi();
            var id = 56;  // int? | 

            try
            {
                // Show a single Has Documents
                InlineResponse20044 result = apiInstance.HasDocumentsIdGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HasDocumentsApi.HasDocumentsIdGet: " + e.Message );
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

[**InlineResponse20044**](InlineResponse20044.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="hasdocumentsidpatch"></a>
# **HasDocumentsIdPatch**
> InlineResponse20044 HasDocumentsIdPatch (HasDocumentsIdBody body, int? id)

Update a Has Documents

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class HasDocumentsIdPatchExample
    {
        public void main()
        {


            var apiInstance = new HasDocumentsApi();
            var body = new HasDocumentsIdBody(); // HasDocumentsIdBody | 
            var id = 56;  // int? | 

            try
            {
                // Update a Has Documents
                InlineResponse20044 result = apiInstance.HasDocumentsIdPatch(body, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HasDocumentsApi.HasDocumentsIdPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**HasDocumentsIdBody**](HasDocumentsIdBody.md)|  | 
 **id** | **int?**|  | 

### Return type

[**InlineResponse20044**](InlineResponse20044.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="hasdocumentspost"></a>
# **HasDocumentsPost**
> InlineResponse20044 HasDocumentsPost (HasDocumentsBody body)

Create a Has Documents

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class HasDocumentsPostExample
    {
        public void main()
        {


            var apiInstance = new HasDocumentsApi();
            var body = new HasDocumentsBody(); // HasDocumentsBody | 

            try
            {
                // Create a Has Documents
                InlineResponse20044 result = apiInstance.HasDocumentsPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HasDocumentsApi.HasDocumentsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**HasDocumentsBody**](HasDocumentsBody.md)|  | 

### Return type

[**InlineResponse20044**](InlineResponse20044.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

