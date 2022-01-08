# IO.Swagger.Api.PrinterClientApi

All URIs are relative to *https://{tenant}.api.webshipper.io/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**PrinterClientsGet**](PrinterClientApi.md#printerclientsget) | **GET** /printer_clients | List all Printer Clients
[**PrinterClientsIdGet**](PrinterClientApi.md#printerclientsidget) | **GET** /printer_clients/{id} | Show a single Printer Client
[**PrinterClientsIdPatch**](PrinterClientApi.md#printerclientsidpatch) | **PATCH** /printer_clients/{id} | Update a Printer Client

<a name="printerclientsget"></a>
# **PrinterClientsGet**
> InlineResponse20082 PrinterClientsGet (string filterId)

List all Printer Clients

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PrinterClientsGetExample
    {
        public void main()
        {


            var apiInstance = new PrinterClientApi();
            var filterId = filterId_example;  // string | Filter by id (optional) 

            try
            {
                // List all Printer Clients
                InlineResponse20082 result = apiInstance.PrinterClientsGet(filterId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PrinterClientApi.PrinterClientsGet: " + e.Message );
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

[**InlineResponse20082**](InlineResponse20082.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="printerclientsidget"></a>
# **PrinterClientsIdGet**
> InlineResponse20081 PrinterClientsIdGet (int? id)

Show a single Printer Client

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PrinterClientsIdGetExample
    {
        public void main()
        {


            var apiInstance = new PrinterClientApi();
            var id = 56;  // int? | 

            try
            {
                // Show a single Printer Client
                InlineResponse20081 result = apiInstance.PrinterClientsIdGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PrinterClientApi.PrinterClientsIdGet: " + e.Message );
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

[**InlineResponse20081**](InlineResponse20081.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="printerclientsidpatch"></a>
# **PrinterClientsIdPatch**
> InlineResponse20081 PrinterClientsIdPatch (PrinterClientsIdBody body, int? id)

Update a Printer Client

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PrinterClientsIdPatchExample
    {
        public void main()
        {


            var apiInstance = new PrinterClientApi();
            var body = new PrinterClientsIdBody(); // PrinterClientsIdBody | 
            var id = 56;  // int? | 

            try
            {
                // Update a Printer Client
                InlineResponse20081 result = apiInstance.PrinterClientsIdPatch(body, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PrinterClientApi.PrinterClientsIdPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**PrinterClientsIdBody**](PrinterClientsIdBody.md)|  | 
 **id** | **int?**|  | 

### Return type

[**InlineResponse20081**](InlineResponse20081.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

