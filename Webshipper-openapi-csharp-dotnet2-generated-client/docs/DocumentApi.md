# IO.Swagger.Api.DocumentApi

All URIs are relative to *https://{tenant}.api.webshipper.io/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DocumentsGet**](DocumentApi.md#documentsget) | **GET** /documents | List all Documents
[**DocumentsIdDelete**](DocumentApi.md#documentsiddelete) | **DELETE** /documents/{id} | Delete a Document
[**DocumentsIdGet**](DocumentApi.md#documentsidget) | **GET** /documents/{id} | Show a single Document
[**DocumentsIdPatch**](DocumentApi.md#documentsidpatch) | **PATCH** /documents/{id} | Update a Document
[**DocumentsPost**](DocumentApi.md#documentspost) | **POST** /documents | Create a Document

<a name="documentsget"></a>
# **DocumentsGet**
> InlineResponse20031 DocumentsGet (string filterId, string filterIsSpecial)

List all Documents

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DocumentsGetExample
    {
        public void main()
        {


            var apiInstance = new DocumentApi();
            var filterId = filterId_example;  // string | Filter by id (optional) 
            var filterIsSpecial = filterIsSpecial_example;  // string | Filter by is_special (optional) 

            try
            {
                // List all Documents
                InlineResponse20031 result = apiInstance.DocumentsGet(filterId, filterIsSpecial);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentApi.DocumentsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filterId** | **string**| Filter by id | [optional] 
 **filterIsSpecial** | **string**| Filter by is_special | [optional] 

### Return type

[**InlineResponse20031**](InlineResponse20031.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="documentsiddelete"></a>
# **DocumentsIdDelete**
> InlineResponse20030 DocumentsIdDelete (int? id)

Delete a Document

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DocumentsIdDeleteExample
    {
        public void main()
        {


            var apiInstance = new DocumentApi();
            var id = 56;  // int? | 

            try
            {
                // Delete a Document
                InlineResponse20030 result = apiInstance.DocumentsIdDelete(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentApi.DocumentsIdDelete: " + e.Message );
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

[**InlineResponse20030**](InlineResponse20030.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="documentsidget"></a>
# **DocumentsIdGet**
> InlineResponse20030 DocumentsIdGet (int? id)

Show a single Document

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DocumentsIdGetExample
    {
        public void main()
        {


            var apiInstance = new DocumentApi();
            var id = 56;  // int? | 

            try
            {
                // Show a single Document
                InlineResponse20030 result = apiInstance.DocumentsIdGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentApi.DocumentsIdGet: " + e.Message );
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

[**InlineResponse20030**](InlineResponse20030.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="documentsidpatch"></a>
# **DocumentsIdPatch**
> InlineResponse20030 DocumentsIdPatch (DocumentsIdBody body, int? id)

Update a Document

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DocumentsIdPatchExample
    {
        public void main()
        {


            var apiInstance = new DocumentApi();
            var body = new DocumentsIdBody(); // DocumentsIdBody | 
            var id = 56;  // int? | 

            try
            {
                // Update a Document
                InlineResponse20030 result = apiInstance.DocumentsIdPatch(body, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentApi.DocumentsIdPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**DocumentsIdBody**](DocumentsIdBody.md)|  | 
 **id** | **int?**|  | 

### Return type

[**InlineResponse20030**](InlineResponse20030.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="documentspost"></a>
# **DocumentsPost**
> InlineResponse20030 DocumentsPost (DocumentsBody body)

Create a Document

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DocumentsPostExample
    {
        public void main()
        {


            var apiInstance = new DocumentApi();
            var body = new DocumentsBody(); // DocumentsBody | 

            try
            {
                // Create a Document
                InlineResponse20030 result = apiInstance.DocumentsPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentApi.DocumentsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**DocumentsBody**](DocumentsBody.md)|  | 

### Return type

[**InlineResponse20030**](InlineResponse20030.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

