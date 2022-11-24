# IO.Swagger.Api.ReturnOrderApi

All URIs are relative to *https://{tenant}.api.webshipper.io/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ReturnsGet**](ReturnOrderApi.md#returnsget) | **GET** /returns | List all Return Orders
[**ReturnsIdDelete**](ReturnOrderApi.md#returnsiddelete) | **DELETE** /returns/{id} | Delete a Return Order
[**ReturnsIdGet**](ReturnOrderApi.md#returnsidget) | **GET** /returns/{id} | Show a single Return Order
[**ReturnsIdPatch**](ReturnOrderApi.md#returnsidpatch) | **PATCH** /returns/{id} | Update a Return Order
[**ReturnsPost**](ReturnOrderApi.md#returnspost) | **POST** /returns | Create a Return Order

<a name="returnsget"></a>
# **ReturnsGet**
> InlineResponse20092 ReturnsGet (string filterId, string filterSecret, string filterStatus, string filterPortalId, string filterFreeText, string filterReturnCauses)

List all Return Orders

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ReturnsGetExample
    {
        public void main()
        {


            var apiInstance = new ReturnOrderApi();
            var filterId = filterId_example;  // string | Filter by id (optional) 
            var filterSecret = filterSecret_example;  // string | Filter by secret (optional) 
            var filterStatus = filterStatus_example;  // string | Filter by status (optional) 
            var filterPortalId = filterPortalId_example;  // string | Filter by portal_id (optional) 
            var filterFreeText = filterFreeText_example;  // string | Filter by free_text (optional) 
            var filterReturnCauses = filterReturnCauses_example;  // string | Filter by return_causes (optional) 

            try
            {
                // List all Return Orders
                InlineResponse20092 result = apiInstance.ReturnsGet(filterId, filterSecret, filterStatus, filterPortalId, filterFreeText, filterReturnCauses);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReturnOrderApi.ReturnsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filterId** | **string**| Filter by id | [optional] 
 **filterSecret** | **string**| Filter by secret | [optional] 
 **filterStatus** | **string**| Filter by status | [optional] 
 **filterPortalId** | **string**| Filter by portal_id | [optional] 
 **filterFreeText** | **string**| Filter by free_text | [optional] 
 **filterReturnCauses** | **string**| Filter by return_causes | [optional] 

### Return type

[**InlineResponse20092**](InlineResponse20092.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="returnsiddelete"></a>
# **ReturnsIdDelete**
> InlineResponse20091 ReturnsIdDelete (int? id)

Delete a Return Order

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ReturnsIdDeleteExample
    {
        public void main()
        {


            var apiInstance = new ReturnOrderApi();
            var id = 56;  // int? | 

            try
            {
                // Delete a Return Order
                InlineResponse20091 result = apiInstance.ReturnsIdDelete(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReturnOrderApi.ReturnsIdDelete: " + e.Message );
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

[**InlineResponse20091**](InlineResponse20091.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="returnsidget"></a>
# **ReturnsIdGet**
> InlineResponse20091 ReturnsIdGet (int? id)

Show a single Return Order

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ReturnsIdGetExample
    {
        public void main()
        {


            var apiInstance = new ReturnOrderApi();
            var id = 56;  // int? | 

            try
            {
                // Show a single Return Order
                InlineResponse20091 result = apiInstance.ReturnsIdGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReturnOrderApi.ReturnsIdGet: " + e.Message );
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

[**InlineResponse20091**](InlineResponse20091.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="returnsidpatch"></a>
# **ReturnsIdPatch**
> InlineResponse20091 ReturnsIdPatch (ReturnsIdBody body, int? id)

Update a Return Order

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ReturnsIdPatchExample
    {
        public void main()
        {


            var apiInstance = new ReturnOrderApi();
            var body = new ReturnsIdBody(); // ReturnsIdBody | 
            var id = 56;  // int? | 

            try
            {
                // Update a Return Order
                InlineResponse20091 result = apiInstance.ReturnsIdPatch(body, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReturnOrderApi.ReturnsIdPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ReturnsIdBody**](ReturnsIdBody.md)|  | 
 **id** | **int?**|  | 

### Return type

[**InlineResponse20091**](InlineResponse20091.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="returnspost"></a>
# **ReturnsPost**
> InlineResponse20091 ReturnsPost (ReturnsBody body)

Create a Return Order

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ReturnsPostExample
    {
        public void main()
        {


            var apiInstance = new ReturnOrderApi();
            var body = new ReturnsBody(); // ReturnsBody | 

            try
            {
                // Create a Return Order
                InlineResponse20091 result = apiInstance.ReturnsPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReturnOrderApi.ReturnsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ReturnsBody**](ReturnsBody.md)|  | 

### Return type

[**InlineResponse20091**](InlineResponse20091.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

