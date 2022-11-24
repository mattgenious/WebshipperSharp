# IO.Swagger.Api.OAuthApplicationApi

All URIs are relative to *https://{tenant}.api.webshipper.io/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**OauthApplicationsGet**](OAuthApplicationApi.md#oauthapplicationsget) | **GET** /oauth_applications | List all OAuth Applications
[**OauthApplicationsIdGet**](OAuthApplicationApi.md#oauthapplicationsidget) | **GET** /oauth_applications/{id} | Show a single OAuth Application

<a name="oauthapplicationsget"></a>
# **OauthApplicationsGet**
> InlineResponse20062 OauthApplicationsGet (string filterId, string filterUid, string filterActive)

List all OAuth Applications

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class OauthApplicationsGetExample
    {
        public void main()
        {


            var apiInstance = new OAuthApplicationApi();
            var filterId = filterId_example;  // string | Filter by id (optional) 
            var filterUid = filterUid_example;  // string | Filter by uid (optional) 
            var filterActive = filterActive_example;  // string | Filter by active (optional) 

            try
            {
                // List all OAuth Applications
                InlineResponse20062 result = apiInstance.OauthApplicationsGet(filterId, filterUid, filterActive);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OAuthApplicationApi.OauthApplicationsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filterId** | **string**| Filter by id | [optional] 
 **filterUid** | **string**| Filter by uid | [optional] 
 **filterActive** | **string**| Filter by active | [optional] 

### Return type

[**InlineResponse20062**](InlineResponse20062.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="oauthapplicationsidget"></a>
# **OauthApplicationsIdGet**
> InlineResponse20061 OauthApplicationsIdGet (int? id)

Show a single OAuth Application

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class OauthApplicationsIdGetExample
    {
        public void main()
        {


            var apiInstance = new OAuthApplicationApi();
            var id = 56;  // int? | 

            try
            {
                // Show a single OAuth Application
                InlineResponse20061 result = apiInstance.OauthApplicationsIdGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OAuthApplicationApi.OauthApplicationsIdGet: " + e.Message );
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

[**InlineResponse20061**](InlineResponse20061.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

