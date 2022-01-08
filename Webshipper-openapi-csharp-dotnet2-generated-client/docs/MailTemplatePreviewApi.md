# IO.Swagger.Api.MailTemplatePreviewApi

All URIs are relative to *https://{tenant}.api.webshipper.io/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**MailTemplatePreviewsGet**](MailTemplatePreviewApi.md#mailtemplatepreviewsget) | **GET** /mail_template_previews | List all Mail Template Previews
[**MailTemplatePreviewsIdDelete**](MailTemplatePreviewApi.md#mailtemplatepreviewsiddelete) | **DELETE** /mail_template_previews/{id} | Delete a Mail Template Preview
[**MailTemplatePreviewsIdGet**](MailTemplatePreviewApi.md#mailtemplatepreviewsidget) | **GET** /mail_template_previews/{id} | Show a single Mail Template Preview
[**MailTemplatePreviewsIdPatch**](MailTemplatePreviewApi.md#mailtemplatepreviewsidpatch) | **PATCH** /mail_template_previews/{id} | Update a Mail Template Preview
[**MailTemplatePreviewsPost**](MailTemplatePreviewApi.md#mailtemplatepreviewspost) | **POST** /mail_template_previews | Create a Mail Template Preview

<a name="mailtemplatepreviewsget"></a>
# **MailTemplatePreviewsGet**
> InlineResponse20055 MailTemplatePreviewsGet (string filterId)

List all Mail Template Previews

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MailTemplatePreviewsGetExample
    {
        public void main()
        {


            var apiInstance = new MailTemplatePreviewApi();
            var filterId = filterId_example;  // string | Filter by id (optional) 

            try
            {
                // List all Mail Template Previews
                InlineResponse20055 result = apiInstance.MailTemplatePreviewsGet(filterId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MailTemplatePreviewApi.MailTemplatePreviewsGet: " + e.Message );
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

[**InlineResponse20055**](InlineResponse20055.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mailtemplatepreviewsiddelete"></a>
# **MailTemplatePreviewsIdDelete**
> InlineResponse20054 MailTemplatePreviewsIdDelete (int? id)

Delete a Mail Template Preview

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MailTemplatePreviewsIdDeleteExample
    {
        public void main()
        {


            var apiInstance = new MailTemplatePreviewApi();
            var id = 56;  // int? | 

            try
            {
                // Delete a Mail Template Preview
                InlineResponse20054 result = apiInstance.MailTemplatePreviewsIdDelete(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MailTemplatePreviewApi.MailTemplatePreviewsIdDelete: " + e.Message );
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

[**InlineResponse20054**](InlineResponse20054.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mailtemplatepreviewsidget"></a>
# **MailTemplatePreviewsIdGet**
> InlineResponse20054 MailTemplatePreviewsIdGet (int? id)

Show a single Mail Template Preview

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MailTemplatePreviewsIdGetExample
    {
        public void main()
        {


            var apiInstance = new MailTemplatePreviewApi();
            var id = 56;  // int? | 

            try
            {
                // Show a single Mail Template Preview
                InlineResponse20054 result = apiInstance.MailTemplatePreviewsIdGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MailTemplatePreviewApi.MailTemplatePreviewsIdGet: " + e.Message );
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

[**InlineResponse20054**](InlineResponse20054.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mailtemplatepreviewsidpatch"></a>
# **MailTemplatePreviewsIdPatch**
> InlineResponse20054 MailTemplatePreviewsIdPatch (MailTemplatePreviewsIdBody body, int? id)

Update a Mail Template Preview

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MailTemplatePreviewsIdPatchExample
    {
        public void main()
        {


            var apiInstance = new MailTemplatePreviewApi();
            var body = new MailTemplatePreviewsIdBody(); // MailTemplatePreviewsIdBody | 
            var id = 56;  // int? | 

            try
            {
                // Update a Mail Template Preview
                InlineResponse20054 result = apiInstance.MailTemplatePreviewsIdPatch(body, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MailTemplatePreviewApi.MailTemplatePreviewsIdPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**MailTemplatePreviewsIdBody**](MailTemplatePreviewsIdBody.md)|  | 
 **id** | **int?**|  | 

### Return type

[**InlineResponse20054**](InlineResponse20054.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mailtemplatepreviewspost"></a>
# **MailTemplatePreviewsPost**
> InlineResponse20054 MailTemplatePreviewsPost (MailTemplatePreviewsBody body)

Create a Mail Template Preview

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MailTemplatePreviewsPostExample
    {
        public void main()
        {


            var apiInstance = new MailTemplatePreviewApi();
            var body = new MailTemplatePreviewsBody(); // MailTemplatePreviewsBody | 

            try
            {
                // Create a Mail Template Preview
                InlineResponse20054 result = apiInstance.MailTemplatePreviewsPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MailTemplatePreviewApi.MailTemplatePreviewsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**MailTemplatePreviewsBody**](MailTemplatePreviewsBody.md)|  | 

### Return type

[**InlineResponse20054**](InlineResponse20054.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

