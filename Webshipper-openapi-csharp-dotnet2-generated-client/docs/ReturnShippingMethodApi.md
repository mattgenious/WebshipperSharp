# IO.Swagger.Api.ReturnShippingMethodApi

All URIs are relative to *https://{tenant}.api.webshipper.io/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ReturnShippingMethodsGet**](ReturnShippingMethodApi.md#returnshippingmethodsget) | **GET** /return_shipping_methods | List all Return Shipping Methods
[**ReturnShippingMethodsIdDelete**](ReturnShippingMethodApi.md#returnshippingmethodsiddelete) | **DELETE** /return_shipping_methods/{id} | Delete a Return Shipping Method
[**ReturnShippingMethodsIdGet**](ReturnShippingMethodApi.md#returnshippingmethodsidget) | **GET** /return_shipping_methods/{id} | Show a single Return Shipping Method
[**ReturnShippingMethodsIdPatch**](ReturnShippingMethodApi.md#returnshippingmethodsidpatch) | **PATCH** /return_shipping_methods/{id} | Update a Return Shipping Method
[**ReturnShippingMethodsPost**](ReturnShippingMethodApi.md#returnshippingmethodspost) | **POST** /return_shipping_methods | Create a Return Shipping Method

<a name="returnshippingmethodsget"></a>
# **ReturnShippingMethodsGet**
> InlineResponse20096 ReturnShippingMethodsGet (string filterId)

List all Return Shipping Methods

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ReturnShippingMethodsGetExample
    {
        public void main()
        {


            var apiInstance = new ReturnShippingMethodApi();
            var filterId = filterId_example;  // string | Filter by id (optional) 

            try
            {
                // List all Return Shipping Methods
                InlineResponse20096 result = apiInstance.ReturnShippingMethodsGet(filterId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReturnShippingMethodApi.ReturnShippingMethodsGet: " + e.Message );
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

[**InlineResponse20096**](InlineResponse20096.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="returnshippingmethodsiddelete"></a>
# **ReturnShippingMethodsIdDelete**
> InlineResponse20095 ReturnShippingMethodsIdDelete (int? id)

Delete a Return Shipping Method

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ReturnShippingMethodsIdDeleteExample
    {
        public void main()
        {


            var apiInstance = new ReturnShippingMethodApi();
            var id = 56;  // int? | 

            try
            {
                // Delete a Return Shipping Method
                InlineResponse20095 result = apiInstance.ReturnShippingMethodsIdDelete(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReturnShippingMethodApi.ReturnShippingMethodsIdDelete: " + e.Message );
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

[**InlineResponse20095**](InlineResponse20095.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="returnshippingmethodsidget"></a>
# **ReturnShippingMethodsIdGet**
> InlineResponse20095 ReturnShippingMethodsIdGet (int? id)

Show a single Return Shipping Method

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ReturnShippingMethodsIdGetExample
    {
        public void main()
        {


            var apiInstance = new ReturnShippingMethodApi();
            var id = 56;  // int? | 

            try
            {
                // Show a single Return Shipping Method
                InlineResponse20095 result = apiInstance.ReturnShippingMethodsIdGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReturnShippingMethodApi.ReturnShippingMethodsIdGet: " + e.Message );
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

[**InlineResponse20095**](InlineResponse20095.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="returnshippingmethodsidpatch"></a>
# **ReturnShippingMethodsIdPatch**
> InlineResponse20095 ReturnShippingMethodsIdPatch (ReturnShippingMethodsIdBody body, int? id)

Update a Return Shipping Method

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ReturnShippingMethodsIdPatchExample
    {
        public void main()
        {


            var apiInstance = new ReturnShippingMethodApi();
            var body = new ReturnShippingMethodsIdBody(); // ReturnShippingMethodsIdBody | 
            var id = 56;  // int? | 

            try
            {
                // Update a Return Shipping Method
                InlineResponse20095 result = apiInstance.ReturnShippingMethodsIdPatch(body, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReturnShippingMethodApi.ReturnShippingMethodsIdPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ReturnShippingMethodsIdBody**](ReturnShippingMethodsIdBody.md)|  | 
 **id** | **int?**|  | 

### Return type

[**InlineResponse20095**](InlineResponse20095.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="returnshippingmethodspost"></a>
# **ReturnShippingMethodsPost**
> InlineResponse20095 ReturnShippingMethodsPost (ReturnShippingMethodsBody body)

Create a Return Shipping Method

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ReturnShippingMethodsPostExample
    {
        public void main()
        {


            var apiInstance = new ReturnShippingMethodApi();
            var body = new ReturnShippingMethodsBody(); // ReturnShippingMethodsBody | 

            try
            {
                // Create a Return Shipping Method
                InlineResponse20095 result = apiInstance.ReturnShippingMethodsPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReturnShippingMethodApi.ReturnShippingMethodsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ReturnShippingMethodsBody**](ReturnShippingMethodsBody.md)|  | 

### Return type

[**InlineResponse20095**](InlineResponse20095.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

