# IO.Swagger.Api.PrintableApi

All URIs are relative to *https://{tenant}.api.webshipper.io/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**PrintablesGet**](PrintableApi.md#printablesget) | **GET** /printables | List all Printables
[**PrintablesIdDelete**](PrintableApi.md#printablesiddelete) | **DELETE** /printables/{id} | Delete a Printable
[**PrintablesIdGet**](PrintableApi.md#printablesidget) | **GET** /printables/{id} | Show a single Printable
[**PrintablesIdPatch**](PrintableApi.md#printablesidpatch) | **PATCH** /printables/{id} | Update a Printable
[**PrintablesPost**](PrintableApi.md#printablespost) | **POST** /printables | Create a Printable

<a name="printablesget"></a>
# **PrintablesGet**
> InlineResponse20078 PrintablesGet (string filterId)

List all Printables

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PrintablesGetExample
    {
        public void main()
        {


            var apiInstance = new PrintableApi();
            var filterId = filterId_example;  // string | Filter by id (optional) 

            try
            {
                // List all Printables
                InlineResponse20078 result = apiInstance.PrintablesGet(filterId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PrintableApi.PrintablesGet: " + e.Message );
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

[**InlineResponse20078**](InlineResponse20078.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="printablesiddelete"></a>
# **PrintablesIdDelete**
> InlineResponse20077 PrintablesIdDelete (int? id)

Delete a Printable

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PrintablesIdDeleteExample
    {
        public void main()
        {


            var apiInstance = new PrintableApi();
            var id = 56;  // int? | 

            try
            {
                // Delete a Printable
                InlineResponse20077 result = apiInstance.PrintablesIdDelete(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PrintableApi.PrintablesIdDelete: " + e.Message );
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

[**InlineResponse20077**](InlineResponse20077.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="printablesidget"></a>
# **PrintablesIdGet**
> InlineResponse20077 PrintablesIdGet (int? id)

Show a single Printable

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PrintablesIdGetExample
    {
        public void main()
        {


            var apiInstance = new PrintableApi();
            var id = 56;  // int? | 

            try
            {
                // Show a single Printable
                InlineResponse20077 result = apiInstance.PrintablesIdGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PrintableApi.PrintablesIdGet: " + e.Message );
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

[**InlineResponse20077**](InlineResponse20077.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="printablesidpatch"></a>
# **PrintablesIdPatch**
> InlineResponse20077 PrintablesIdPatch (PrintablesIdBody body, int? id)

Update a Printable

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PrintablesIdPatchExample
    {
        public void main()
        {


            var apiInstance = new PrintableApi();
            var body = new PrintablesIdBody(); // PrintablesIdBody | 
            var id = 56;  // int? | 

            try
            {
                // Update a Printable
                InlineResponse20077 result = apiInstance.PrintablesIdPatch(body, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PrintableApi.PrintablesIdPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**PrintablesIdBody**](PrintablesIdBody.md)|  | 
 **id** | **int?**|  | 

### Return type

[**InlineResponse20077**](InlineResponse20077.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="printablespost"></a>
# **PrintablesPost**
> InlineResponse20077 PrintablesPost (PrintablesBody body)

Create a Printable

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PrintablesPostExample
    {
        public void main()
        {


            var apiInstance = new PrintableApi();
            var body = new PrintablesBody(); // PrintablesBody | 

            try
            {
                // Create a Printable
                InlineResponse20077 result = apiInstance.PrintablesPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PrintableApi.PrintablesPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**PrintablesBody**](PrintablesBody.md)|  | 

### Return type

[**InlineResponse20077**](InlineResponse20077.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

