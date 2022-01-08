# IO.Swagger.Api.ShippingRateExpressionApi

All URIs are relative to *https://{tenant}.api.webshipper.io/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ExpressionsGet**](ShippingRateExpressionApi.md#expressionsget) | **GET** /expressions | List all Shipping Rate Expressions
[**ExpressionsIdDelete**](ShippingRateExpressionApi.md#expressionsiddelete) | **DELETE** /expressions/{id} | Delete a Shipping Rate Expression
[**ExpressionsIdGet**](ShippingRateExpressionApi.md#expressionsidget) | **GET** /expressions/{id} | Show a single Shipping Rate Expression
[**ExpressionsIdPatch**](ShippingRateExpressionApi.md#expressionsidpatch) | **PATCH** /expressions/{id} | Update a Shipping Rate Expression
[**ExpressionsPost**](ShippingRateExpressionApi.md#expressionspost) | **POST** /expressions | Create a Shipping Rate Expression

<a name="expressionsget"></a>
# **ExpressionsGet**
> InlineResponse200106 ExpressionsGet (string filterId)

List all Shipping Rate Expressions

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ExpressionsGetExample
    {
        public void main()
        {


            var apiInstance = new ShippingRateExpressionApi();
            var filterId = filterId_example;  // string | Filter by id (optional) 

            try
            {
                // List all Shipping Rate Expressions
                InlineResponse200106 result = apiInstance.ExpressionsGet(filterId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ShippingRateExpressionApi.ExpressionsGet: " + e.Message );
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

[**InlineResponse200106**](InlineResponse200106.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="expressionsiddelete"></a>
# **ExpressionsIdDelete**
> InlineResponse200105 ExpressionsIdDelete (int? id)

Delete a Shipping Rate Expression

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ExpressionsIdDeleteExample
    {
        public void main()
        {


            var apiInstance = new ShippingRateExpressionApi();
            var id = 56;  // int? | 

            try
            {
                // Delete a Shipping Rate Expression
                InlineResponse200105 result = apiInstance.ExpressionsIdDelete(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ShippingRateExpressionApi.ExpressionsIdDelete: " + e.Message );
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

[**InlineResponse200105**](InlineResponse200105.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="expressionsidget"></a>
# **ExpressionsIdGet**
> InlineResponse200105 ExpressionsIdGet (int? id)

Show a single Shipping Rate Expression

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ExpressionsIdGetExample
    {
        public void main()
        {


            var apiInstance = new ShippingRateExpressionApi();
            var id = 56;  // int? | 

            try
            {
                // Show a single Shipping Rate Expression
                InlineResponse200105 result = apiInstance.ExpressionsIdGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ShippingRateExpressionApi.ExpressionsIdGet: " + e.Message );
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

[**InlineResponse200105**](InlineResponse200105.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="expressionsidpatch"></a>
# **ExpressionsIdPatch**
> InlineResponse200105 ExpressionsIdPatch (ExpressionsIdBody body, int? id)

Update a Shipping Rate Expression

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ExpressionsIdPatchExample
    {
        public void main()
        {


            var apiInstance = new ShippingRateExpressionApi();
            var body = new ExpressionsIdBody(); // ExpressionsIdBody | 
            var id = 56;  // int? | 

            try
            {
                // Update a Shipping Rate Expression
                InlineResponse200105 result = apiInstance.ExpressionsIdPatch(body, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ShippingRateExpressionApi.ExpressionsIdPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ExpressionsIdBody**](ExpressionsIdBody.md)|  | 
 **id** | **int?**|  | 

### Return type

[**InlineResponse200105**](InlineResponse200105.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="expressionspost"></a>
# **ExpressionsPost**
> InlineResponse200105 ExpressionsPost (ExpressionsBody body)

Create a Shipping Rate Expression

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ExpressionsPostExample
    {
        public void main()
        {


            var apiInstance = new ShippingRateExpressionApi();
            var body = new ExpressionsBody(); // ExpressionsBody | 

            try
            {
                // Create a Shipping Rate Expression
                InlineResponse200105 result = apiInstance.ExpressionsPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ShippingRateExpressionApi.ExpressionsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ExpressionsBody**](ExpressionsBody.md)|  | 

### Return type

[**InlineResponse200105**](InlineResponse200105.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

