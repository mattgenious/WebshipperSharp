# IO.Swagger.Api.ServiceQuoteApi

All URIs are relative to *https://{tenant}.api.webshipper.io/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ServiceQuotesPost**](ServiceQuoteApi.md#servicequotespost) | **POST** /service_quotes | Create a Service Quote

<a name="servicequotespost"></a>
# **ServiceQuotesPost**
> InlineResponse2044 ServiceQuotesPost (ServiceQuotesBody body)

Create a Service Quote

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ServiceQuotesPostExample
    {
        public void main()
        {


            var apiInstance = new ServiceQuoteApi();
            var body = new ServiceQuotesBody(); // ServiceQuotesBody | 

            try
            {
                // Create a Service Quote
                InlineResponse2044 result = apiInstance.ServiceQuotesPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServiceQuoteApi.ServiceQuotesPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ServiceQuotesBody**](ServiceQuotesBody.md)|  | 

### Return type

[**InlineResponse2044**](InlineResponse2044.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

