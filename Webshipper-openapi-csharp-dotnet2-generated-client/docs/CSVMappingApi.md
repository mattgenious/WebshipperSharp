# IO.Swagger.Api.CSVMappingApi

All URIs are relative to *https://{tenant}.api.webshipper.io/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CsvMappingsGet**](CSVMappingApi.md#csvmappingsget) | **GET** /csv_mappings | List all CSV Mappings
[**CsvMappingsIdDelete**](CSVMappingApi.md#csvmappingsiddelete) | **DELETE** /csv_mappings/{id} | Delete a CSV Mapping
[**CsvMappingsIdGet**](CSVMappingApi.md#csvmappingsidget) | **GET** /csv_mappings/{id} | Show a single CSV Mapping
[**CsvMappingsIdPatch**](CSVMappingApi.md#csvmappingsidpatch) | **PATCH** /csv_mappings/{id} | Update a CSV Mapping
[**CsvMappingsPost**](CSVMappingApi.md#csvmappingspost) | **POST** /csv_mappings | Create a CSV Mapping

<a name="csvmappingsget"></a>
# **CsvMappingsGet**
> InlineResponse20019 CsvMappingsGet (string filterId)

List all CSV Mappings

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CsvMappingsGetExample
    {
        public void main()
        {


            var apiInstance = new CSVMappingApi();
            var filterId = filterId_example;  // string | Filter by id (optional) 

            try
            {
                // List all CSV Mappings
                InlineResponse20019 result = apiInstance.CsvMappingsGet(filterId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CSVMappingApi.CsvMappingsGet: " + e.Message );
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

[**InlineResponse20019**](InlineResponse20019.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="csvmappingsiddelete"></a>
# **CsvMappingsIdDelete**
> InlineResponse20018 CsvMappingsIdDelete (int? id)

Delete a CSV Mapping

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CsvMappingsIdDeleteExample
    {
        public void main()
        {


            var apiInstance = new CSVMappingApi();
            var id = 56;  // int? | 

            try
            {
                // Delete a CSV Mapping
                InlineResponse20018 result = apiInstance.CsvMappingsIdDelete(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CSVMappingApi.CsvMappingsIdDelete: " + e.Message );
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

[**InlineResponse20018**](InlineResponse20018.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="csvmappingsidget"></a>
# **CsvMappingsIdGet**
> InlineResponse20018 CsvMappingsIdGet (int? id)

Show a single CSV Mapping

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CsvMappingsIdGetExample
    {
        public void main()
        {


            var apiInstance = new CSVMappingApi();
            var id = 56;  // int? | 

            try
            {
                // Show a single CSV Mapping
                InlineResponse20018 result = apiInstance.CsvMappingsIdGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CSVMappingApi.CsvMappingsIdGet: " + e.Message );
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

[**InlineResponse20018**](InlineResponse20018.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="csvmappingsidpatch"></a>
# **CsvMappingsIdPatch**
> InlineResponse20018 CsvMappingsIdPatch (CsvMappingsIdBody body, int? id)

Update a CSV Mapping

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CsvMappingsIdPatchExample
    {
        public void main()
        {


            var apiInstance = new CSVMappingApi();
            var body = new CsvMappingsIdBody(); // CsvMappingsIdBody | 
            var id = 56;  // int? | 

            try
            {
                // Update a CSV Mapping
                InlineResponse20018 result = apiInstance.CsvMappingsIdPatch(body, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CSVMappingApi.CsvMappingsIdPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CsvMappingsIdBody**](CsvMappingsIdBody.md)|  | 
 **id** | **int?**|  | 

### Return type

[**InlineResponse20018**](InlineResponse20018.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="csvmappingspost"></a>
# **CsvMappingsPost**
> InlineResponse20018 CsvMappingsPost (CsvMappingsBody body)

Create a CSV Mapping

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CsvMappingsPostExample
    {
        public void main()
        {


            var apiInstance = new CSVMappingApi();
            var body = new CsvMappingsBody(); // CsvMappingsBody | 

            try
            {
                // Create a CSV Mapping
                InlineResponse20018 result = apiInstance.CsvMappingsPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CSVMappingApi.CsvMappingsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CsvMappingsBody**](CsvMappingsBody.md)|  | 

### Return type

[**InlineResponse20018**](InlineResponse20018.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

