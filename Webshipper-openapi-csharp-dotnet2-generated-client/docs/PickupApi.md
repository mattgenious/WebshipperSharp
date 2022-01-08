# IO.Swagger.Api.PickupApi

All URIs are relative to *https://{tenant}.api.webshipper.io/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**PickupsGet**](PickupApi.md#pickupsget) | **GET** /pickups | List all Pickups
[**PickupsIdDelete**](PickupApi.md#pickupsiddelete) | **DELETE** /pickups/{id} | Delete a Pickup
[**PickupsIdGet**](PickupApi.md#pickupsidget) | **GET** /pickups/{id} | Show a single Pickup
[**PickupsIdPatch**](PickupApi.md#pickupsidpatch) | **PATCH** /pickups/{id} | Update a Pickup
[**PickupsPost**](PickupApi.md#pickupspost) | **POST** /pickups | Create a Pickup

<a name="pickupsget"></a>
# **PickupsGet**
> InlineResponse20074 PickupsGet (string filterId)

List all Pickups

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PickupsGetExample
    {
        public void main()
        {


            var apiInstance = new PickupApi();
            var filterId = filterId_example;  // string | Filter by id (optional) 

            try
            {
                // List all Pickups
                InlineResponse20074 result = apiInstance.PickupsGet(filterId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PickupApi.PickupsGet: " + e.Message );
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

[**InlineResponse20074**](InlineResponse20074.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pickupsiddelete"></a>
# **PickupsIdDelete**
> InlineResponse20073 PickupsIdDelete (int? id)

Delete a Pickup

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PickupsIdDeleteExample
    {
        public void main()
        {


            var apiInstance = new PickupApi();
            var id = 56;  // int? | 

            try
            {
                // Delete a Pickup
                InlineResponse20073 result = apiInstance.PickupsIdDelete(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PickupApi.PickupsIdDelete: " + e.Message );
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

[**InlineResponse20073**](InlineResponse20073.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pickupsidget"></a>
# **PickupsIdGet**
> InlineResponse20073 PickupsIdGet (int? id)

Show a single Pickup

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PickupsIdGetExample
    {
        public void main()
        {


            var apiInstance = new PickupApi();
            var id = 56;  // int? | 

            try
            {
                // Show a single Pickup
                InlineResponse20073 result = apiInstance.PickupsIdGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PickupApi.PickupsIdGet: " + e.Message );
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

[**InlineResponse20073**](InlineResponse20073.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pickupsidpatch"></a>
# **PickupsIdPatch**
> InlineResponse20073 PickupsIdPatch (PickupsIdBody body, int? id)

Update a Pickup

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PickupsIdPatchExample
    {
        public void main()
        {


            var apiInstance = new PickupApi();
            var body = new PickupsIdBody(); // PickupsIdBody | 
            var id = 56;  // int? | 

            try
            {
                // Update a Pickup
                InlineResponse20073 result = apiInstance.PickupsIdPatch(body, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PickupApi.PickupsIdPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**PickupsIdBody**](PickupsIdBody.md)|  | 
 **id** | **int?**|  | 

### Return type

[**InlineResponse20073**](InlineResponse20073.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pickupspost"></a>
# **PickupsPost**
> InlineResponse20073 PickupsPost (PickupsBody body)

Create a Pickup

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PickupsPostExample
    {
        public void main()
        {


            var apiInstance = new PickupApi();
            var body = new PickupsBody(); // PickupsBody | 

            try
            {
                // Create a Pickup
                InlineResponse20073 result = apiInstance.PickupsPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PickupApi.PickupsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**PickupsBody**](PickupsBody.md)|  | 

### Return type

[**InlineResponse20073**](InlineResponse20073.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

