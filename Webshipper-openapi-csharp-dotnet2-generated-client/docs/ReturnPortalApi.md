# IO.Swagger.Api.ReturnPortalApi

All URIs are relative to *https://{tenant}.api.webshipper.io/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ReturnPortalsGet**](ReturnPortalApi.md#returnportalsget) | **GET** /return_portals | List all Return Portals
[**ReturnPortalsIdDelete**](ReturnPortalApi.md#returnportalsiddelete) | **DELETE** /return_portals/{id} | Delete a Return Portal
[**ReturnPortalsIdGet**](ReturnPortalApi.md#returnportalsidget) | **GET** /return_portals/{id} | Show a single Return Portal
[**ReturnPortalsIdPatch**](ReturnPortalApi.md#returnportalsidpatch) | **PATCH** /return_portals/{id} | Update a Return Portal
[**ReturnPortalsPost**](ReturnPortalApi.md#returnportalspost) | **POST** /return_portals | Create a Return Portal

<a name="returnportalsget"></a>
# **ReturnPortalsGet**
> InlineResponse20094 ReturnPortalsGet (string filterId)

List all Return Portals

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ReturnPortalsGetExample
    {
        public void main()
        {


            var apiInstance = new ReturnPortalApi();
            var filterId = filterId_example;  // string | Filter by id (optional) 

            try
            {
                // List all Return Portals
                InlineResponse20094 result = apiInstance.ReturnPortalsGet(filterId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReturnPortalApi.ReturnPortalsGet: " + e.Message );
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

[**InlineResponse20094**](InlineResponse20094.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="returnportalsiddelete"></a>
# **ReturnPortalsIdDelete**
> InlineResponse20093 ReturnPortalsIdDelete (int? id)

Delete a Return Portal

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ReturnPortalsIdDeleteExample
    {
        public void main()
        {


            var apiInstance = new ReturnPortalApi();
            var id = 56;  // int? | 

            try
            {
                // Delete a Return Portal
                InlineResponse20093 result = apiInstance.ReturnPortalsIdDelete(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReturnPortalApi.ReturnPortalsIdDelete: " + e.Message );
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

[**InlineResponse20093**](InlineResponse20093.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="returnportalsidget"></a>
# **ReturnPortalsIdGet**
> InlineResponse20093 ReturnPortalsIdGet (int? id)

Show a single Return Portal

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ReturnPortalsIdGetExample
    {
        public void main()
        {


            var apiInstance = new ReturnPortalApi();
            var id = 56;  // int? | 

            try
            {
                // Show a single Return Portal
                InlineResponse20093 result = apiInstance.ReturnPortalsIdGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReturnPortalApi.ReturnPortalsIdGet: " + e.Message );
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

[**InlineResponse20093**](InlineResponse20093.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="returnportalsidpatch"></a>
# **ReturnPortalsIdPatch**
> InlineResponse20093 ReturnPortalsIdPatch (ReturnPortalsIdBody body, int? id)

Update a Return Portal

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ReturnPortalsIdPatchExample
    {
        public void main()
        {


            var apiInstance = new ReturnPortalApi();
            var body = new ReturnPortalsIdBody(); // ReturnPortalsIdBody | 
            var id = 56;  // int? | 

            try
            {
                // Update a Return Portal
                InlineResponse20093 result = apiInstance.ReturnPortalsIdPatch(body, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReturnPortalApi.ReturnPortalsIdPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ReturnPortalsIdBody**](ReturnPortalsIdBody.md)|  | 
 **id** | **int?**|  | 

### Return type

[**InlineResponse20093**](InlineResponse20093.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="returnportalspost"></a>
# **ReturnPortalsPost**
> InlineResponse20093 ReturnPortalsPost (ReturnPortalsBody body)

Create a Return Portal

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ReturnPortalsPostExample
    {
        public void main()
        {


            var apiInstance = new ReturnPortalApi();
            var body = new ReturnPortalsBody(); // ReturnPortalsBody | 

            try
            {
                // Create a Return Portal
                InlineResponse20093 result = apiInstance.ReturnPortalsPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReturnPortalApi.ReturnPortalsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ReturnPortalsBody**](ReturnPortalsBody.md)|  | 

### Return type

[**InlineResponse20093**](InlineResponse20093.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

