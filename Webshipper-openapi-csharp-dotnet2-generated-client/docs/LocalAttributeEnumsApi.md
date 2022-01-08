# IO.Swagger.Api.LocalAttributeEnumsApi

All URIs are relative to *https://{tenant}.api.webshipper.io/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**LocalAttrEnumsGet**](LocalAttributeEnumsApi.md#localattrenumsget) | **GET** /local_attr_enums | List all Local Attribute Enumss
[**LocalAttrEnumsIdGet**](LocalAttributeEnumsApi.md#localattrenumsidget) | **GET** /local_attr_enums/{id} | Show a single Local Attribute Enums

<a name="localattrenumsget"></a>
# **LocalAttrEnumsGet**
> InlineResponse20053 LocalAttrEnumsGet (string filterId)

List all Local Attribute Enumss

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class LocalAttrEnumsGetExample
    {
        public void main()
        {


            var apiInstance = new LocalAttributeEnumsApi();
            var filterId = filterId_example;  // string | Filter by id (optional) 

            try
            {
                // List all Local Attribute Enumss
                InlineResponse20053 result = apiInstance.LocalAttrEnumsGet(filterId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LocalAttributeEnumsApi.LocalAttrEnumsGet: " + e.Message );
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

[**InlineResponse20053**](InlineResponse20053.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="localattrenumsidget"></a>
# **LocalAttrEnumsIdGet**
> InlineResponse20052 LocalAttrEnumsIdGet (int? id)

Show a single Local Attribute Enums

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class LocalAttrEnumsIdGetExample
    {
        public void main()
        {


            var apiInstance = new LocalAttributeEnumsApi();
            var id = 56;  // int? | 

            try
            {
                // Show a single Local Attribute Enums
                InlineResponse20052 result = apiInstance.LocalAttrEnumsIdGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LocalAttributeEnumsApi.LocalAttrEnumsIdGet: " + e.Message );
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

[**InlineResponse20052**](InlineResponse20052.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

