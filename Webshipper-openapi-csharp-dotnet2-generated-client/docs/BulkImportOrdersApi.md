# IO.Swagger.Api.BulkImportOrdersApi

All URIs are relative to *https://{tenant}.api.webshipper.io/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**BulkImportOrdersGet**](BulkImportOrdersApi.md#bulkimportordersget) | **GET** /bulk_import_orders | List all Bulk import orderss
[**BulkImportOrdersIdDelete**](BulkImportOrdersApi.md#bulkimportordersiddelete) | **DELETE** /bulk_import_orders/{id} | Delete a Bulk import orders
[**BulkImportOrdersIdGet**](BulkImportOrdersApi.md#bulkimportordersidget) | **GET** /bulk_import_orders/{id} | Show a single Bulk import orders
[**BulkImportOrdersIdPatch**](BulkImportOrdersApi.md#bulkimportordersidpatch) | **PATCH** /bulk_import_orders/{id} | Update a Bulk import orders
[**BulkImportOrdersPost**](BulkImportOrdersApi.md#bulkimportorderspost) | **POST** /bulk_import_orders | Create a Bulk import orders

<a name="bulkimportordersget"></a>
# **BulkImportOrdersGet**
> InlineResponse20017 BulkImportOrdersGet (string filterId)

List all Bulk import orderss

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class BulkImportOrdersGetExample
    {
        public void main()
        {


            var apiInstance = new BulkImportOrdersApi();
            var filterId = filterId_example;  // string | Filter by id (optional) 

            try
            {
                // List all Bulk import orderss
                InlineResponse20017 result = apiInstance.BulkImportOrdersGet(filterId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BulkImportOrdersApi.BulkImportOrdersGet: " + e.Message );
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

[**InlineResponse20017**](InlineResponse20017.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="bulkimportordersiddelete"></a>
# **BulkImportOrdersIdDelete**
> InlineResponse20016 BulkImportOrdersIdDelete (int? id)

Delete a Bulk import orders

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class BulkImportOrdersIdDeleteExample
    {
        public void main()
        {


            var apiInstance = new BulkImportOrdersApi();
            var id = 56;  // int? | 

            try
            {
                // Delete a Bulk import orders
                InlineResponse20016 result = apiInstance.BulkImportOrdersIdDelete(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BulkImportOrdersApi.BulkImportOrdersIdDelete: " + e.Message );
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

[**InlineResponse20016**](InlineResponse20016.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="bulkimportordersidget"></a>
# **BulkImportOrdersIdGet**
> InlineResponse20016 BulkImportOrdersIdGet (int? id)

Show a single Bulk import orders

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class BulkImportOrdersIdGetExample
    {
        public void main()
        {


            var apiInstance = new BulkImportOrdersApi();
            var id = 56;  // int? | 

            try
            {
                // Show a single Bulk import orders
                InlineResponse20016 result = apiInstance.BulkImportOrdersIdGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BulkImportOrdersApi.BulkImportOrdersIdGet: " + e.Message );
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

[**InlineResponse20016**](InlineResponse20016.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="bulkimportordersidpatch"></a>
# **BulkImportOrdersIdPatch**
> InlineResponse20016 BulkImportOrdersIdPatch (BulkImportOrdersIdBody body, int? id)

Update a Bulk import orders

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class BulkImportOrdersIdPatchExample
    {
        public void main()
        {


            var apiInstance = new BulkImportOrdersApi();
            var body = new BulkImportOrdersIdBody(); // BulkImportOrdersIdBody | 
            var id = 56;  // int? | 

            try
            {
                // Update a Bulk import orders
                InlineResponse20016 result = apiInstance.BulkImportOrdersIdPatch(body, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BulkImportOrdersApi.BulkImportOrdersIdPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**BulkImportOrdersIdBody**](BulkImportOrdersIdBody.md)|  | 
 **id** | **int?**|  | 

### Return type

[**InlineResponse20016**](InlineResponse20016.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="bulkimportorderspost"></a>
# **BulkImportOrdersPost**
> InlineResponse20016 BulkImportOrdersPost (BulkImportOrdersBody body)

Create a Bulk import orders

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class BulkImportOrdersPostExample
    {
        public void main()
        {


            var apiInstance = new BulkImportOrdersApi();
            var body = new BulkImportOrdersBody(); // BulkImportOrdersBody | 

            try
            {
                // Create a Bulk import orders
                InlineResponse20016 result = apiInstance.BulkImportOrdersPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BulkImportOrdersApi.BulkImportOrdersPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**BulkImportOrdersBody**](BulkImportOrdersBody.md)|  | 

### Return type

[**InlineResponse20016**](InlineResponse20016.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

