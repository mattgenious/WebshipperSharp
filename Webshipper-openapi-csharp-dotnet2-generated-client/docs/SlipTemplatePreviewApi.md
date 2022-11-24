# IO.Swagger.Api.SlipTemplatePreviewApi

All URIs are relative to *https://{tenant}.api.webshipper.io/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SlipTemplatePreviewsGet**](SlipTemplatePreviewApi.md#sliptemplatepreviewsget) | **GET** /slip_template_previews | List all Slip Template Previews
[**SlipTemplatePreviewsIdDelete**](SlipTemplatePreviewApi.md#sliptemplatepreviewsiddelete) | **DELETE** /slip_template_previews/{id} | Delete a Slip Template Preview
[**SlipTemplatePreviewsIdGet**](SlipTemplatePreviewApi.md#sliptemplatepreviewsidget) | **GET** /slip_template_previews/{id} | Show a single Slip Template Preview
[**SlipTemplatePreviewsIdPatch**](SlipTemplatePreviewApi.md#sliptemplatepreviewsidpatch) | **PATCH** /slip_template_previews/{id} | Update a Slip Template Preview
[**SlipTemplatePreviewsPost**](SlipTemplatePreviewApi.md#sliptemplatepreviewspost) | **POST** /slip_template_previews | Create a Slip Template Preview

<a name="sliptemplatepreviewsget"></a>
# **SlipTemplatePreviewsGet**
> InlineResponse200112 SlipTemplatePreviewsGet (string filterId)

List all Slip Template Previews

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SlipTemplatePreviewsGetExample
    {
        public void main()
        {


            var apiInstance = new SlipTemplatePreviewApi();
            var filterId = filterId_example;  // string | Filter by id (optional) 

            try
            {
                // List all Slip Template Previews
                InlineResponse200112 result = apiInstance.SlipTemplatePreviewsGet(filterId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SlipTemplatePreviewApi.SlipTemplatePreviewsGet: " + e.Message );
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

[**InlineResponse200112**](InlineResponse200112.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sliptemplatepreviewsiddelete"></a>
# **SlipTemplatePreviewsIdDelete**
> InlineResponse200111 SlipTemplatePreviewsIdDelete (int? id)

Delete a Slip Template Preview

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SlipTemplatePreviewsIdDeleteExample
    {
        public void main()
        {


            var apiInstance = new SlipTemplatePreviewApi();
            var id = 56;  // int? | 

            try
            {
                // Delete a Slip Template Preview
                InlineResponse200111 result = apiInstance.SlipTemplatePreviewsIdDelete(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SlipTemplatePreviewApi.SlipTemplatePreviewsIdDelete: " + e.Message );
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

[**InlineResponse200111**](InlineResponse200111.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sliptemplatepreviewsidget"></a>
# **SlipTemplatePreviewsIdGet**
> InlineResponse200111 SlipTemplatePreviewsIdGet (int? id)

Show a single Slip Template Preview

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SlipTemplatePreviewsIdGetExample
    {
        public void main()
        {


            var apiInstance = new SlipTemplatePreviewApi();
            var id = 56;  // int? | 

            try
            {
                // Show a single Slip Template Preview
                InlineResponse200111 result = apiInstance.SlipTemplatePreviewsIdGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SlipTemplatePreviewApi.SlipTemplatePreviewsIdGet: " + e.Message );
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

[**InlineResponse200111**](InlineResponse200111.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sliptemplatepreviewsidpatch"></a>
# **SlipTemplatePreviewsIdPatch**
> InlineResponse200111 SlipTemplatePreviewsIdPatch (SlipTemplatePreviewsIdBody body, int? id)

Update a Slip Template Preview

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SlipTemplatePreviewsIdPatchExample
    {
        public void main()
        {


            var apiInstance = new SlipTemplatePreviewApi();
            var body = new SlipTemplatePreviewsIdBody(); // SlipTemplatePreviewsIdBody | 
            var id = 56;  // int? | 

            try
            {
                // Update a Slip Template Preview
                InlineResponse200111 result = apiInstance.SlipTemplatePreviewsIdPatch(body, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SlipTemplatePreviewApi.SlipTemplatePreviewsIdPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SlipTemplatePreviewsIdBody**](SlipTemplatePreviewsIdBody.md)|  | 
 **id** | **int?**|  | 

### Return type

[**InlineResponse200111**](InlineResponse200111.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sliptemplatepreviewspost"></a>
# **SlipTemplatePreviewsPost**
> InlineResponse200111 SlipTemplatePreviewsPost (SlipTemplatePreviewsBody body)

Create a Slip Template Preview

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SlipTemplatePreviewsPostExample
    {
        public void main()
        {


            var apiInstance = new SlipTemplatePreviewApi();
            var body = new SlipTemplatePreviewsBody(); // SlipTemplatePreviewsBody | 

            try
            {
                // Create a Slip Template Preview
                InlineResponse200111 result = apiInstance.SlipTemplatePreviewsPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SlipTemplatePreviewApi.SlipTemplatePreviewsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SlipTemplatePreviewsBody**](SlipTemplatePreviewsBody.md)|  | 

### Return type

[**InlineResponse200111**](InlineResponse200111.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

