# IO.Swagger.Api.CSVUploadApi

All URIs are relative to *https://{tenant}.api.webshipper.io/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CsvUploadsPost**](CSVUploadApi.md#csvuploadspost) | **POST** /csv_uploads | Create a CSV Upload

<a name="csvuploadspost"></a>
# **CsvUploadsPost**
> InlineResponse204 CsvUploadsPost (CsvUploadsBody body)

Create a CSV Upload

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CsvUploadsPostExample
    {
        public void main()
        {


            var apiInstance = new CSVUploadApi();
            var body = new CsvUploadsBody(); // CsvUploadsBody | 

            try
            {
                // Create a CSV Upload
                InlineResponse204 result = apiInstance.CsvUploadsPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CSVUploadApi.CsvUploadsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CsvUploadsBody**](CsvUploadsBody.md)|  | 

### Return type

[**InlineResponse204**](InlineResponse204.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

