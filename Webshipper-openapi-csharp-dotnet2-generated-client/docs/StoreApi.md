# IO.Swagger.Api.StoreApi

All URIs are relative to *https://{tenant}.api.webshipper.io/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**StoresGet**](StoreApi.md#storesget) | **GET** /stores | List all Stores
[**StoresIdDelete**](StoreApi.md#storesiddelete) | **DELETE** /stores/{id} | Delete a Store
[**StoresIdGet**](StoreApi.md#storesidget) | **GET** /stores/{id} | Show a single Store
[**StoresIdPatch**](StoreApi.md#storesidpatch) | **PATCH** /stores/{id} | Update a Store
[**StoresPost**](StoreApi.md#storespost) | **POST** /stores | Create a Store

<a name="storesget"></a>
# **StoresGet**
> InlineResponse200114 StoresGet (string filterId)

List all Stores

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class StoresGetExample
    {
        public void main()
        {


            var apiInstance = new StoreApi();
            var filterId = filterId_example;  // string | Filter by id (optional) 

            try
            {
                // List all Stores
                InlineResponse200114 result = apiInstance.StoresGet(filterId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreApi.StoresGet: " + e.Message );
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

[**InlineResponse200114**](InlineResponse200114.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="storesiddelete"></a>
# **StoresIdDelete**
> InlineResponse200113 StoresIdDelete (int? id)

Delete a Store

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class StoresIdDeleteExample
    {
        public void main()
        {


            var apiInstance = new StoreApi();
            var id = 56;  // int? | 

            try
            {
                // Delete a Store
                InlineResponse200113 result = apiInstance.StoresIdDelete(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreApi.StoresIdDelete: " + e.Message );
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

[**InlineResponse200113**](InlineResponse200113.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="storesidget"></a>
# **StoresIdGet**
> InlineResponse200113 StoresIdGet (int? id)

Show a single Store

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class StoresIdGetExample
    {
        public void main()
        {


            var apiInstance = new StoreApi();
            var id = 56;  // int? | 

            try
            {
                // Show a single Store
                InlineResponse200113 result = apiInstance.StoresIdGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreApi.StoresIdGet: " + e.Message );
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

[**InlineResponse200113**](InlineResponse200113.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="storesidpatch"></a>
# **StoresIdPatch**
> InlineResponse200113 StoresIdPatch (StoresIdBody body, int? id)

Update a Store

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class StoresIdPatchExample
    {
        public void main()
        {


            var apiInstance = new StoreApi();
            var body = new StoresIdBody(); // StoresIdBody | 
            var id = 56;  // int? | 

            try
            {
                // Update a Store
                InlineResponse200113 result = apiInstance.StoresIdPatch(body, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreApi.StoresIdPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**StoresIdBody**](StoresIdBody.md)|  | 
 **id** | **int?**|  | 

### Return type

[**InlineResponse200113**](InlineResponse200113.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="storespost"></a>
# **StoresPost**
> InlineResponse200113 StoresPost (StoresBody body)

Create a Store

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class StoresPostExample
    {
        public void main()
        {


            var apiInstance = new StoreApi();
            var body = new StoresBody(); // StoresBody | 

            try
            {
                // Create a Store
                InlineResponse200113 result = apiInstance.StoresPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreApi.StoresPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**StoresBody**](StoresBody.md)|  | 

### Return type

[**InlineResponse200113**](InlineResponse200113.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

