# IO.Swagger.Api.MergedOrderApi

All URIs are relative to *https://{tenant}.api.webshipper.io/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**OrderMergesPost**](MergedOrderApi.md#ordermergespost) | **POST** /order_merges | Create a Merged Order

<a name="ordermergespost"></a>
# **OrderMergesPost**
> InlineResponse2042 OrderMergesPost (OrderMergesBody body)

Create a Merged Order

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class OrderMergesPostExample
    {
        public void main()
        {


            var apiInstance = new MergedOrderApi();
            var body = new OrderMergesBody(); // OrderMergesBody | 

            try
            {
                // Create a Merged Order
                InlineResponse2042 result = apiInstance.OrderMergesPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MergedOrderApi.OrderMergesPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**OrderMergesBody**](OrderMergesBody.md)|  | 

### Return type

[**InlineResponse2042**](InlineResponse2042.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

