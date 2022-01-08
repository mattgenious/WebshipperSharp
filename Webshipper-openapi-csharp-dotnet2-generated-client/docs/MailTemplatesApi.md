# IO.Swagger.Api.MailTemplatesApi

All URIs are relative to *https://{tenant}.api.webshipper.io/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**MailTemplatesGet**](MailTemplatesApi.md#mailtemplatesget) | **GET** /mail_templates | List all Mail Templatess
[**MailTemplatesIdDelete**](MailTemplatesApi.md#mailtemplatesiddelete) | **DELETE** /mail_templates/{id} | Delete a Mail Templates
[**MailTemplatesIdGet**](MailTemplatesApi.md#mailtemplatesidget) | **GET** /mail_templates/{id} | Show a single Mail Templates
[**MailTemplatesIdPatch**](MailTemplatesApi.md#mailtemplatesidpatch) | **PATCH** /mail_templates/{id} | Update a Mail Templates
[**MailTemplatesPost**](MailTemplatesApi.md#mailtemplatespost) | **POST** /mail_templates | Create a Mail Templates

<a name="mailtemplatesget"></a>
# **MailTemplatesGet**
> InlineResponse20057 MailTemplatesGet (string filterId, string filterPurpose)

List all Mail Templatess

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MailTemplatesGetExample
    {
        public void main()
        {


            var apiInstance = new MailTemplatesApi();
            var filterId = filterId_example;  // string | Filter by id (optional) 
            var filterPurpose = filterPurpose_example;  // string | Filter by purpose (optional) 

            try
            {
                // List all Mail Templatess
                InlineResponse20057 result = apiInstance.MailTemplatesGet(filterId, filterPurpose);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MailTemplatesApi.MailTemplatesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filterId** | **string**| Filter by id | [optional] 
 **filterPurpose** | **string**| Filter by purpose | [optional] 

### Return type

[**InlineResponse20057**](InlineResponse20057.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mailtemplatesiddelete"></a>
# **MailTemplatesIdDelete**
> InlineResponse20056 MailTemplatesIdDelete (int? id)

Delete a Mail Templates

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MailTemplatesIdDeleteExample
    {
        public void main()
        {


            var apiInstance = new MailTemplatesApi();
            var id = 56;  // int? | 

            try
            {
                // Delete a Mail Templates
                InlineResponse20056 result = apiInstance.MailTemplatesIdDelete(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MailTemplatesApi.MailTemplatesIdDelete: " + e.Message );
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

[**InlineResponse20056**](InlineResponse20056.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mailtemplatesidget"></a>
# **MailTemplatesIdGet**
> InlineResponse20056 MailTemplatesIdGet (int? id)

Show a single Mail Templates

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MailTemplatesIdGetExample
    {
        public void main()
        {


            var apiInstance = new MailTemplatesApi();
            var id = 56;  // int? | 

            try
            {
                // Show a single Mail Templates
                InlineResponse20056 result = apiInstance.MailTemplatesIdGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MailTemplatesApi.MailTemplatesIdGet: " + e.Message );
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

[**InlineResponse20056**](InlineResponse20056.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mailtemplatesidpatch"></a>
# **MailTemplatesIdPatch**
> InlineResponse20056 MailTemplatesIdPatch (MailTemplatesIdBody body, int? id)

Update a Mail Templates

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MailTemplatesIdPatchExample
    {
        public void main()
        {


            var apiInstance = new MailTemplatesApi();
            var body = new MailTemplatesIdBody(); // MailTemplatesIdBody | 
            var id = 56;  // int? | 

            try
            {
                // Update a Mail Templates
                InlineResponse20056 result = apiInstance.MailTemplatesIdPatch(body, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MailTemplatesApi.MailTemplatesIdPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**MailTemplatesIdBody**](MailTemplatesIdBody.md)|  | 
 **id** | **int?**|  | 

### Return type

[**InlineResponse20056**](InlineResponse20056.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mailtemplatespost"></a>
# **MailTemplatesPost**
> InlineResponse20056 MailTemplatesPost (MailTemplatesBody body)

Create a Mail Templates

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MailTemplatesPostExample
    {
        public void main()
        {


            var apiInstance = new MailTemplatesApi();
            var body = new MailTemplatesBody(); // MailTemplatesBody | 

            try
            {
                // Create a Mail Templates
                InlineResponse20056 result = apiInstance.MailTemplatesPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MailTemplatesApi.MailTemplatesPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**MailTemplatesBody**](MailTemplatesBody.md)|  | 

### Return type

[**InlineResponse20056**](InlineResponse20056.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

