# IO.Swagger.Api.CSVMappingRuleApi

All URIs are relative to *https://{tenant}.api.webshipper.io/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CsvRulesGet**](CSVMappingRuleApi.md#csvrulesget) | **GET** /csv_rules | List all CSV Mapping Rules
[**CsvRulesIdDelete**](CSVMappingRuleApi.md#csvrulesiddelete) | **DELETE** /csv_rules/{id} | Delete a CSV Mapping Rule
[**CsvRulesIdGet**](CSVMappingRuleApi.md#csvrulesidget) | **GET** /csv_rules/{id} | Show a single CSV Mapping Rule
[**CsvRulesIdPatch**](CSVMappingRuleApi.md#csvrulesidpatch) | **PATCH** /csv_rules/{id} | Update a CSV Mapping Rule
[**CsvRulesPost**](CSVMappingRuleApi.md#csvrulespost) | **POST** /csv_rules | Create a CSV Mapping Rule

<a name="csvrulesget"></a>
# **CsvRulesGet**
> InlineResponse20021 CsvRulesGet (string filterId)

List all CSV Mapping Rules

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CsvRulesGetExample
    {
        public void main()
        {


            var apiInstance = new CSVMappingRuleApi();
            var filterId = filterId_example;  // string | Filter by id (optional) 

            try
            {
                // List all CSV Mapping Rules
                InlineResponse20021 result = apiInstance.CsvRulesGet(filterId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CSVMappingRuleApi.CsvRulesGet: " + e.Message );
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

[**InlineResponse20021**](InlineResponse20021.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="csvrulesiddelete"></a>
# **CsvRulesIdDelete**
> InlineResponse20020 CsvRulesIdDelete (int? id)

Delete a CSV Mapping Rule

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CsvRulesIdDeleteExample
    {
        public void main()
        {


            var apiInstance = new CSVMappingRuleApi();
            var id = 56;  // int? | 

            try
            {
                // Delete a CSV Mapping Rule
                InlineResponse20020 result = apiInstance.CsvRulesIdDelete(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CSVMappingRuleApi.CsvRulesIdDelete: " + e.Message );
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

[**InlineResponse20020**](InlineResponse20020.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="csvrulesidget"></a>
# **CsvRulesIdGet**
> InlineResponse20020 CsvRulesIdGet (int? id)

Show a single CSV Mapping Rule

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CsvRulesIdGetExample
    {
        public void main()
        {


            var apiInstance = new CSVMappingRuleApi();
            var id = 56;  // int? | 

            try
            {
                // Show a single CSV Mapping Rule
                InlineResponse20020 result = apiInstance.CsvRulesIdGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CSVMappingRuleApi.CsvRulesIdGet: " + e.Message );
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

[**InlineResponse20020**](InlineResponse20020.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="csvrulesidpatch"></a>
# **CsvRulesIdPatch**
> InlineResponse20020 CsvRulesIdPatch (CsvRulesIdBody body, int? id)

Update a CSV Mapping Rule

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CsvRulesIdPatchExample
    {
        public void main()
        {


            var apiInstance = new CSVMappingRuleApi();
            var body = new CsvRulesIdBody(); // CsvRulesIdBody | 
            var id = 56;  // int? | 

            try
            {
                // Update a CSV Mapping Rule
                InlineResponse20020 result = apiInstance.CsvRulesIdPatch(body, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CSVMappingRuleApi.CsvRulesIdPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CsvRulesIdBody**](CsvRulesIdBody.md)|  | 
 **id** | **int?**|  | 

### Return type

[**InlineResponse20020**](InlineResponse20020.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="csvrulespost"></a>
# **CsvRulesPost**
> InlineResponse20020 CsvRulesPost (CsvRulesBody body)

Create a CSV Mapping Rule

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CsvRulesPostExample
    {
        public void main()
        {


            var apiInstance = new CSVMappingRuleApi();
            var body = new CsvRulesBody(); // CsvRulesBody | 

            try
            {
                // Create a CSV Mapping Rule
                InlineResponse20020 result = apiInstance.CsvRulesPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CSVMappingRuleApi.CsvRulesPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CsvRulesBody**](CsvRulesBody.md)|  | 

### Return type

[**InlineResponse20020**](InlineResponse20020.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

