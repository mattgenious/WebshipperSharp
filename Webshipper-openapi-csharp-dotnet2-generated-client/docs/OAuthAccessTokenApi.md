# IO.Swagger.Api.OAuthAccessTokenApi

All URIs are relative to *https://{tenant}.api.webshipper.io/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**OauthAccessTokensGet**](OAuthAccessTokenApi.md#oauthaccesstokensget) | **GET** /oauth_access_tokens | List all OAuth Access Tokens
[**OauthAccessTokensIdGet**](OAuthAccessTokenApi.md#oauthaccesstokensidget) | **GET** /oauth_access_tokens/{id} | Show a single OAuth Access Token

<a name="oauthaccesstokensget"></a>
# **OauthAccessTokensGet**
> InlineResponse20060 OauthAccessTokensGet (string filterId)

List all OAuth Access Tokens

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class OauthAccessTokensGetExample
    {
        public void main()
        {


            var apiInstance = new OAuthAccessTokenApi();
            var filterId = filterId_example;  // string | Filter by id (optional) 

            try
            {
                // List all OAuth Access Tokens
                InlineResponse20060 result = apiInstance.OauthAccessTokensGet(filterId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OAuthAccessTokenApi.OauthAccessTokensGet: " + e.Message );
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

[**InlineResponse20060**](InlineResponse20060.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="oauthaccesstokensidget"></a>
# **OauthAccessTokensIdGet**
> InlineResponse20059 OauthAccessTokensIdGet (int? id)

Show a single OAuth Access Token

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class OauthAccessTokensIdGetExample
    {
        public void main()
        {


            var apiInstance = new OAuthAccessTokenApi();
            var id = 56;  // int? | 

            try
            {
                // Show a single OAuth Access Token
                InlineResponse20059 result = apiInstance.OauthAccessTokensIdGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OAuthAccessTokenApi.OauthAccessTokensIdGet: " + e.Message );
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

[**InlineResponse20059**](InlineResponse20059.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

