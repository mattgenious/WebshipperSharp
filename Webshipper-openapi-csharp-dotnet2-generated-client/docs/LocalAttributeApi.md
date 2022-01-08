# IO.Swagger.Api.LocalAttributeApi

All URIs are relative to *https://{tenant}.api.webshipper.io/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**LocalAttrsGet**](LocalAttributeApi.md#localattrsget) | **GET** /local_attrs | List all Local Attributes
[**LocalAttrsIdGet**](LocalAttributeApi.md#localattrsidget) | **GET** /local_attrs/{id} | Show a single Local Attribute

<a name="localattrsget"></a>
# **LocalAttrsGet**
> InlineResponse20051 LocalAttrsGet (string filterId)

List all Local Attributes

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class LocalAttrsGetExample
    {
        public void main()
        {


            var apiInstance = new LocalAttributeApi();
            var filterId = filterId_example;  // string | Filter by id (optional) 

            try
            {
                // List all Local Attributes
                InlineResponse20051 result = apiInstance.LocalAttrsGet(filterId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LocalAttributeApi.LocalAttrsGet: " + e.Message );
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

[**InlineResponse20051**](InlineResponse20051.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="localattrsidget"></a>
# **LocalAttrsIdGet**
> InlineResponse20050 LocalAttrsIdGet (int? id)

Show a single Local Attribute

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class LocalAttrsIdGetExample
    {
        public void main()
        {


            var apiInstance = new LocalAttributeApi();
            var id = 56;  // int? | 

            try
            {
                // Show a single Local Attribute
                InlineResponse20050 result = apiInstance.LocalAttrsIdGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LocalAttributeApi.LocalAttrsIdGet: " + e.Message );
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

[**InlineResponse20050**](InlineResponse20050.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

