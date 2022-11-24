# IO.Swagger.Api.DropPointLocatorApi

All URIs are relative to *https://{tenant}.api.webshipper.io/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DropPointLocatorsPost**](DropPointLocatorApi.md#droppointlocatorspost) | **POST** /drop_point_locators | Search for drop points

<a name="droppointlocatorspost"></a>
# **DropPointLocatorsPost**
> InlineResponse2041 DropPointLocatorsPost (DropPointLocatorsBody body)

Search for drop points

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DropPointLocatorsPostExample
    {
        public void main()
        {


            var apiInstance = new DropPointLocatorApi();
            var body = new DropPointLocatorsBody(); // DropPointLocatorsBody | 

            try
            {
                // Search for drop points
                InlineResponse2041 result = apiInstance.DropPointLocatorsPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DropPointLocatorApi.DropPointLocatorsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**DropPointLocatorsBody**](DropPointLocatorsBody.md)|  | 

### Return type

[**InlineResponse2041**](InlineResponse2041.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

