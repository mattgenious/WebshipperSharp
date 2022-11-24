# IO.Swagger.Api.SlipTemplateApi

All URIs are relative to *https://{tenant}.api.webshipper.io/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SlipTemplatesGet**](SlipTemplateApi.md#sliptemplatesget) | **GET** /slip_templates | List all Slip Templates
[**SlipTemplatesIdDelete**](SlipTemplateApi.md#sliptemplatesiddelete) | **DELETE** /slip_templates/{id} | Delete a Slip Template
[**SlipTemplatesIdGet**](SlipTemplateApi.md#sliptemplatesidget) | **GET** /slip_templates/{id} | Show a single Slip Template
[**SlipTemplatesIdPatch**](SlipTemplateApi.md#sliptemplatesidpatch) | **PATCH** /slip_templates/{id} | Update a Slip Template
[**SlipTemplatesPost**](SlipTemplateApi.md#sliptemplatespost) | **POST** /slip_templates | Create a Slip Template

<a name="sliptemplatesget"></a>
# **SlipTemplatesGet**
> InlineResponse200110 SlipTemplatesGet (string filterId, string filterReturnsOnly)

List all Slip Templates

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SlipTemplatesGetExample
    {
        public void main()
        {


            var apiInstance = new SlipTemplateApi();
            var filterId = filterId_example;  // string | Filter by id (optional) 
            var filterReturnsOnly = filterReturnsOnly_example;  // string | Filter by returns_only (optional) 

            try
            {
                // List all Slip Templates
                InlineResponse200110 result = apiInstance.SlipTemplatesGet(filterId, filterReturnsOnly);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SlipTemplateApi.SlipTemplatesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filterId** | **string**| Filter by id | [optional] 
 **filterReturnsOnly** | **string**| Filter by returns_only | [optional] 

### Return type

[**InlineResponse200110**](InlineResponse200110.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sliptemplatesiddelete"></a>
# **SlipTemplatesIdDelete**
> InlineResponse200109 SlipTemplatesIdDelete (int? id)

Delete a Slip Template

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SlipTemplatesIdDeleteExample
    {
        public void main()
        {


            var apiInstance = new SlipTemplateApi();
            var id = 56;  // int? | 

            try
            {
                // Delete a Slip Template
                InlineResponse200109 result = apiInstance.SlipTemplatesIdDelete(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SlipTemplateApi.SlipTemplatesIdDelete: " + e.Message );
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

[**InlineResponse200109**](InlineResponse200109.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sliptemplatesidget"></a>
# **SlipTemplatesIdGet**
> InlineResponse200109 SlipTemplatesIdGet (int? id)

Show a single Slip Template

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SlipTemplatesIdGetExample
    {
        public void main()
        {


            var apiInstance = new SlipTemplateApi();
            var id = 56;  // int? | 

            try
            {
                // Show a single Slip Template
                InlineResponse200109 result = apiInstance.SlipTemplatesIdGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SlipTemplateApi.SlipTemplatesIdGet: " + e.Message );
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

[**InlineResponse200109**](InlineResponse200109.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sliptemplatesidpatch"></a>
# **SlipTemplatesIdPatch**
> InlineResponse200109 SlipTemplatesIdPatch (SlipTemplatesIdBody body, int? id)

Update a Slip Template

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SlipTemplatesIdPatchExample
    {
        public void main()
        {


            var apiInstance = new SlipTemplateApi();
            var body = new SlipTemplatesIdBody(); // SlipTemplatesIdBody | 
            var id = 56;  // int? | 

            try
            {
                // Update a Slip Template
                InlineResponse200109 result = apiInstance.SlipTemplatesIdPatch(body, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SlipTemplateApi.SlipTemplatesIdPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SlipTemplatesIdBody**](SlipTemplatesIdBody.md)|  | 
 **id** | **int?**|  | 

### Return type

[**InlineResponse200109**](InlineResponse200109.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sliptemplatespost"></a>
# **SlipTemplatesPost**
> InlineResponse200109 SlipTemplatesPost (SlipTemplatesBody body)

Create a Slip Template

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SlipTemplatesPostExample
    {
        public void main()
        {


            var apiInstance = new SlipTemplateApi();
            var body = new SlipTemplatesBody(); // SlipTemplatesBody | 

            try
            {
                // Create a Slip Template
                InlineResponse200109 result = apiInstance.SlipTemplatesPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SlipTemplateApi.SlipTemplatesPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SlipTemplatesBody**](SlipTemplatesBody.md)|  | 

### Return type

[**InlineResponse200109**](InlineResponse200109.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

