# IO.Swagger.Api.TagApi

All URIs are relative to *https://{tenant}.api.webshipper.io/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**TagsGet**](TagApi.md#tagsget) | **GET** /tags | List all Tags

<a name="tagsget"></a>
# **TagsGet**
> InlineResponse200115 TagsGet (string filterId)

List all Tags

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TagsGetExample
    {
        public void main()
        {


            var apiInstance = new TagApi();
            var filterId = filterId_example;  // string | Filter by id (optional) 

            try
            {
                // List all Tags
                InlineResponse200115 result = apiInstance.TagsGet(filterId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TagApi.TagsGet: " + e.Message );
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

[**InlineResponse200115**](InlineResponse200115.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

