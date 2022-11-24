# IO.Swagger.Api.MergedPDFApi

All URIs are relative to *https://{tenant}.api.webshipper.io/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**PdfMergesIdGet**](MergedPDFApi.md#pdfmergesidget) | **GET** /pdf_merges/{id} | Show a single Merged PDF
[**PdfMergesPost**](MergedPDFApi.md#pdfmergespost) | **POST** /pdf_merges | Create a Merged PDF

<a name="pdfmergesidget"></a>
# **PdfMergesIdGet**
> InlineResponse20058 PdfMergesIdGet (int? id)

Show a single Merged PDF

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PdfMergesIdGetExample
    {
        public void main()
        {


            var apiInstance = new MergedPDFApi();
            var id = 56;  // int? | 

            try
            {
                // Show a single Merged PDF
                InlineResponse20058 result = apiInstance.PdfMergesIdGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MergedPDFApi.PdfMergesIdGet: " + e.Message );
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

[**InlineResponse20058**](InlineResponse20058.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pdfmergespost"></a>
# **PdfMergesPost**
> InlineResponse20058 PdfMergesPost (PdfMergesBody body)

Create a Merged PDF

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PdfMergesPostExample
    {
        public void main()
        {


            var apiInstance = new MergedPDFApi();
            var body = new PdfMergesBody(); // PdfMergesBody | 

            try
            {
                // Create a Merged PDF
                InlineResponse20058 result = apiInstance.PdfMergesPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MergedPDFApi.PdfMergesPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**PdfMergesBody**](PdfMergesBody.md)|  | 

### Return type

[**InlineResponse20058**](InlineResponse20058.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

