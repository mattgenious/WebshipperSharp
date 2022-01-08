# IO.Swagger.Api.PackageApi

All URIs are relative to *https://{tenant}.api.webshipper.io/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**PackagesGet**](PackageApi.md#packagesget) | **GET** /packages | List all Packages
[**PackagesIdGet**](PackageApi.md#packagesidget) | **GET** /packages/{id} | Show a single Package
[**PackagesPost**](PackageApi.md#packagespost) | **POST** /packages | Create a Package

<a name="packagesget"></a>
# **PackagesGet**
> InlineResponse20072 PackagesGet (string filterId)

List all Packages

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PackagesGetExample
    {
        public void main()
        {


            var apiInstance = new PackageApi();
            var filterId = filterId_example;  // string | Filter by id (optional) 

            try
            {
                // List all Packages
                InlineResponse20072 result = apiInstance.PackagesGet(filterId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PackageApi.PackagesGet: " + e.Message );
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

[**InlineResponse20072**](InlineResponse20072.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="packagesidget"></a>
# **PackagesIdGet**
> InlineResponse20071 PackagesIdGet (int? id)

Show a single Package

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PackagesIdGetExample
    {
        public void main()
        {


            var apiInstance = new PackageApi();
            var id = 56;  // int? | 

            try
            {
                // Show a single Package
                InlineResponse20071 result = apiInstance.PackagesIdGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PackageApi.PackagesIdGet: " + e.Message );
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

[**InlineResponse20071**](InlineResponse20071.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="packagespost"></a>
# **PackagesPost**
> InlineResponse20071 PackagesPost (PackagesBody body)

Create a Package

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PackagesPostExample
    {
        public void main()
        {


            var apiInstance = new PackageApi();
            var body = new PackagesBody(); // PackagesBody | 

            try
            {
                // Create a Package
                InlineResponse20071 result = apiInstance.PackagesPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PackageApi.PackagesPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**PackagesBody**](PackagesBody.md)|  | 

### Return type

[**InlineResponse20071**](InlineResponse20071.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

