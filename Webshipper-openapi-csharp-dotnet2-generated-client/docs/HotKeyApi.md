# IO.Swagger.Api.HotKeyApi

All URIs are relative to *https://{tenant}.api.webshipper.io/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**HotKeysGet**](HotKeyApi.md#hotkeysget) | **GET** /hot_keys | List all HotKeys
[**HotKeysIdDelete**](HotKeyApi.md#hotkeysiddelete) | **DELETE** /hot_keys/{id} | Delete a HotKey
[**HotKeysIdGet**](HotKeyApi.md#hotkeysidget) | **GET** /hot_keys/{id} | Show a single HotKey
[**HotKeysIdPatch**](HotKeyApi.md#hotkeysidpatch) | **PATCH** /hot_keys/{id} | Update a HotKey
[**HotKeysPost**](HotKeyApi.md#hotkeyspost) | **POST** /hot_keys | Create a HotKey

<a name="hotkeysget"></a>
# **HotKeysGet**
> InlineResponse20047 HotKeysGet (string filterId)

List all HotKeys

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class HotKeysGetExample
    {
        public void main()
        {


            var apiInstance = new HotKeyApi();
            var filterId = filterId_example;  // string | Filter by id (optional) 

            try
            {
                // List all HotKeys
                InlineResponse20047 result = apiInstance.HotKeysGet(filterId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HotKeyApi.HotKeysGet: " + e.Message );
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

[**InlineResponse20047**](InlineResponse20047.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="hotkeysiddelete"></a>
# **HotKeysIdDelete**
> InlineResponse20046 HotKeysIdDelete (int? id)

Delete a HotKey

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class HotKeysIdDeleteExample
    {
        public void main()
        {


            var apiInstance = new HotKeyApi();
            var id = 56;  // int? | 

            try
            {
                // Delete a HotKey
                InlineResponse20046 result = apiInstance.HotKeysIdDelete(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HotKeyApi.HotKeysIdDelete: " + e.Message );
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

[**InlineResponse20046**](InlineResponse20046.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="hotkeysidget"></a>
# **HotKeysIdGet**
> InlineResponse20046 HotKeysIdGet (int? id)

Show a single HotKey

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class HotKeysIdGetExample
    {
        public void main()
        {


            var apiInstance = new HotKeyApi();
            var id = 56;  // int? | 

            try
            {
                // Show a single HotKey
                InlineResponse20046 result = apiInstance.HotKeysIdGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HotKeyApi.HotKeysIdGet: " + e.Message );
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

[**InlineResponse20046**](InlineResponse20046.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="hotkeysidpatch"></a>
# **HotKeysIdPatch**
> InlineResponse20046 HotKeysIdPatch (HotKeysIdBody body, int? id)

Update a HotKey

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class HotKeysIdPatchExample
    {
        public void main()
        {


            var apiInstance = new HotKeyApi();
            var body = new HotKeysIdBody(); // HotKeysIdBody | 
            var id = 56;  // int? | 

            try
            {
                // Update a HotKey
                InlineResponse20046 result = apiInstance.HotKeysIdPatch(body, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HotKeyApi.HotKeysIdPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**HotKeysIdBody**](HotKeysIdBody.md)|  | 
 **id** | **int?**|  | 

### Return type

[**InlineResponse20046**](InlineResponse20046.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="hotkeyspost"></a>
# **HotKeysPost**
> InlineResponse20046 HotKeysPost (HotKeysBody body)

Create a HotKey

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class HotKeysPostExample
    {
        public void main()
        {


            var apiInstance = new HotKeyApi();
            var body = new HotKeysBody(); // HotKeysBody | 

            try
            {
                // Create a HotKey
                InlineResponse20046 result = apiInstance.HotKeysPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HotKeyApi.HotKeysPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**HotKeysBody**](HotKeysBody.md)|  | 

### Return type

[**InlineResponse20046**](InlineResponse20046.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

