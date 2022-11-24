# IO.Swagger.Api.AdditionalAttributeApi

All URIs are relative to *https://{tenant}.api.webshipper.io/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AdditionalAttributesGet**](AdditionalAttributeApi.md#additionalattributesget) | **GET** /additional_attributes | List all Additional Attributes
[**AdditionalAttributesIdDelete**](AdditionalAttributeApi.md#additionalattributesiddelete) | **DELETE** /additional_attributes/{id} | Delete a Additional Attribute
[**AdditionalAttributesIdGet**](AdditionalAttributeApi.md#additionalattributesidget) | **GET** /additional_attributes/{id} | Show a single Additional Attribute
[**AdditionalAttributesIdPatch**](AdditionalAttributeApi.md#additionalattributesidpatch) | **PATCH** /additional_attributes/{id} | Update a Additional Attribute
[**AdditionalAttributesPost**](AdditionalAttributeApi.md#additionalattributespost) | **POST** /additional_attributes | Create a Additional Attribute

<a name="additionalattributesget"></a>
# **AdditionalAttributesGet**
> InlineResponse2007 AdditionalAttributesGet (string filterId)

List all Additional Attributes

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AdditionalAttributesGetExample
    {
        public void main()
        {


            var apiInstance = new AdditionalAttributeApi();
            var filterId = filterId_example;  // string | Filter by id (optional) 

            try
            {
                // List all Additional Attributes
                InlineResponse2007 result = apiInstance.AdditionalAttributesGet(filterId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdditionalAttributeApi.AdditionalAttributesGet: " + e.Message );
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

[**InlineResponse2007**](InlineResponse2007.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="additionalattributesiddelete"></a>
# **AdditionalAttributesIdDelete**
> InlineResponse2006 AdditionalAttributesIdDelete (int? id)

Delete a Additional Attribute

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AdditionalAttributesIdDeleteExample
    {
        public void main()
        {


            var apiInstance = new AdditionalAttributeApi();
            var id = 56;  // int? | 

            try
            {
                // Delete a Additional Attribute
                InlineResponse2006 result = apiInstance.AdditionalAttributesIdDelete(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdditionalAttributeApi.AdditionalAttributesIdDelete: " + e.Message );
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

[**InlineResponse2006**](InlineResponse2006.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="additionalattributesidget"></a>
# **AdditionalAttributesIdGet**
> InlineResponse2006 AdditionalAttributesIdGet (int? id)

Show a single Additional Attribute

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AdditionalAttributesIdGetExample
    {
        public void main()
        {


            var apiInstance = new AdditionalAttributeApi();
            var id = 56;  // int? | 

            try
            {
                // Show a single Additional Attribute
                InlineResponse2006 result = apiInstance.AdditionalAttributesIdGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdditionalAttributeApi.AdditionalAttributesIdGet: " + e.Message );
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

[**InlineResponse2006**](InlineResponse2006.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="additionalattributesidpatch"></a>
# **AdditionalAttributesIdPatch**
> InlineResponse2006 AdditionalAttributesIdPatch (AdditionalAttributesIdBody body, int? id)

Update a Additional Attribute

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AdditionalAttributesIdPatchExample
    {
        public void main()
        {


            var apiInstance = new AdditionalAttributeApi();
            var body = new AdditionalAttributesIdBody(); // AdditionalAttributesIdBody | 
            var id = 56;  // int? | 

            try
            {
                // Update a Additional Attribute
                InlineResponse2006 result = apiInstance.AdditionalAttributesIdPatch(body, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdditionalAttributeApi.AdditionalAttributesIdPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AdditionalAttributesIdBody**](AdditionalAttributesIdBody.md)|  | 
 **id** | **int?**|  | 

### Return type

[**InlineResponse2006**](InlineResponse2006.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="additionalattributespost"></a>
# **AdditionalAttributesPost**
> InlineResponse2006 AdditionalAttributesPost (AdditionalAttributesBody body)

Create a Additional Attribute

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AdditionalAttributesPostExample
    {
        public void main()
        {


            var apiInstance = new AdditionalAttributeApi();
            var body = new AdditionalAttributesBody(); // AdditionalAttributesBody | 

            try
            {
                // Create a Additional Attribute
                InlineResponse2006 result = apiInstance.AdditionalAttributesPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdditionalAttributeApi.AdditionalAttributesPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AdditionalAttributesBody**](AdditionalAttributesBody.md)|  | 

### Return type

[**InlineResponse2006**](InlineResponse2006.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

