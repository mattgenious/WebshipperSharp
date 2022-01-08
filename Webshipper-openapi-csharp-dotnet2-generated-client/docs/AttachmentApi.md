# IO.Swagger.Api.AttachmentApi

All URIs are relative to *https://{tenant}.api.webshipper.io/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AttachmentsGet**](AttachmentApi.md#attachmentsget) | **GET** /attachments | List all Attachments
[**AttachmentsIdDelete**](AttachmentApi.md#attachmentsiddelete) | **DELETE** /attachments/{id} | Delete a Attachment
[**AttachmentsIdGet**](AttachmentApi.md#attachmentsidget) | **GET** /attachments/{id} | Show a single Attachment
[**AttachmentsIdPatch**](AttachmentApi.md#attachmentsidpatch) | **PATCH** /attachments/{id} | Update a Attachment
[**AttachmentsPost**](AttachmentApi.md#attachmentspost) | **POST** /attachments | Create a Attachment

<a name="attachmentsget"></a>
# **AttachmentsGet**
> InlineResponse2009 AttachmentsGet (string filterId)

List all Attachments

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AttachmentsGetExample
    {
        public void main()
        {


            var apiInstance = new AttachmentApi();
            var filterId = filterId_example;  // string | Filter by id (optional) 

            try
            {
                // List all Attachments
                InlineResponse2009 result = apiInstance.AttachmentsGet(filterId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AttachmentApi.AttachmentsGet: " + e.Message );
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

[**InlineResponse2009**](InlineResponse2009.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="attachmentsiddelete"></a>
# **AttachmentsIdDelete**
> InlineResponse2008 AttachmentsIdDelete (int? id)

Delete a Attachment

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AttachmentsIdDeleteExample
    {
        public void main()
        {


            var apiInstance = new AttachmentApi();
            var id = 56;  // int? | 

            try
            {
                // Delete a Attachment
                InlineResponse2008 result = apiInstance.AttachmentsIdDelete(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AttachmentApi.AttachmentsIdDelete: " + e.Message );
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

[**InlineResponse2008**](InlineResponse2008.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="attachmentsidget"></a>
# **AttachmentsIdGet**
> InlineResponse2008 AttachmentsIdGet (int? id)

Show a single Attachment

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AttachmentsIdGetExample
    {
        public void main()
        {


            var apiInstance = new AttachmentApi();
            var id = 56;  // int? | 

            try
            {
                // Show a single Attachment
                InlineResponse2008 result = apiInstance.AttachmentsIdGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AttachmentApi.AttachmentsIdGet: " + e.Message );
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

[**InlineResponse2008**](InlineResponse2008.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="attachmentsidpatch"></a>
# **AttachmentsIdPatch**
> InlineResponse2008 AttachmentsIdPatch (AttachmentsIdBody body, int? id)

Update a Attachment

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AttachmentsIdPatchExample
    {
        public void main()
        {


            var apiInstance = new AttachmentApi();
            var body = new AttachmentsIdBody(); // AttachmentsIdBody | 
            var id = 56;  // int? | 

            try
            {
                // Update a Attachment
                InlineResponse2008 result = apiInstance.AttachmentsIdPatch(body, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AttachmentApi.AttachmentsIdPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AttachmentsIdBody**](AttachmentsIdBody.md)|  | 
 **id** | **int?**|  | 

### Return type

[**InlineResponse2008**](InlineResponse2008.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="attachmentspost"></a>
# **AttachmentsPost**
> InlineResponse2008 AttachmentsPost (AttachmentsBody body)

Create a Attachment

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AttachmentsPostExample
    {
        public void main()
        {


            var apiInstance = new AttachmentApi();
            var body = new AttachmentsBody(); // AttachmentsBody | 

            try
            {
                // Create a Attachment
                InlineResponse2008 result = apiInstance.AttachmentsPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AttachmentApi.AttachmentsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AttachmentsBody**](AttachmentsBody.md)|  | 

### Return type

[**InlineResponse2008**](InlineResponse2008.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

