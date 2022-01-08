# IO.Swagger.Api.RateQuoteApi

All URIs are relative to *https://{tenant}.api.webshipper.io/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**RateQuotesPost**](RateQuoteApi.md#ratequotespost) | **POST** /rate_quotes | Create a Rate Quote

<a name="ratequotespost"></a>
# **RateQuotesPost**
> InlineResponse2043 RateQuotesPost (RateQuotesBody body)

Create a Rate Quote

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RateQuotesPostExample
    {
        public void main()
        {


            var apiInstance = new RateQuoteApi();
            var body = new RateQuotesBody(); // RateQuotesBody | 

            try
            {
                // Create a Rate Quote
                InlineResponse2043 result = apiInstance.RateQuotesPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RateQuoteApi.RateQuotesPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RateQuotesBody**](RateQuotesBody.md)|  | 

### Return type

[**InlineResponse2043**](InlineResponse2043.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

