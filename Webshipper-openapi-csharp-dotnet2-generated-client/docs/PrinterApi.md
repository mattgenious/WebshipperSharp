# IO.Swagger.Api.PrinterApi

All URIs are relative to *https://{tenant}.api.webshipper.io/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**PrintersGet**](PrinterApi.md#printersget) | **GET** /printers | List all Printers
[**PrintersIdGet**](PrinterApi.md#printersidget) | **GET** /printers/{id} | Show a single Printer

<a name="printersget"></a>
# **PrintersGet**
> InlineResponse20080 PrintersGet (string filterId)

List all Printers

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PrintersGetExample
    {
        public void main()
        {


            var apiInstance = new PrinterApi();
            var filterId = filterId_example;  // string | Filter by id (optional) 

            try
            {
                // List all Printers
                InlineResponse20080 result = apiInstance.PrintersGet(filterId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PrinterApi.PrintersGet: " + e.Message );
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

[**InlineResponse20080**](InlineResponse20080.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="printersidget"></a>
# **PrintersIdGet**
> InlineResponse20079 PrintersIdGet (int? id)

Show a single Printer

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PrintersIdGetExample
    {
        public void main()
        {


            var apiInstance = new PrinterApi();
            var id = 56;  // int? | 

            try
            {
                // Show a single Printer
                InlineResponse20079 result = apiInstance.PrintersIdGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PrinterApi.PrintersIdGet: " + e.Message );
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

[**InlineResponse20079**](InlineResponse20079.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

