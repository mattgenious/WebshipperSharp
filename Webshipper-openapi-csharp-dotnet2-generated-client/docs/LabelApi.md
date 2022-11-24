# IO.Swagger.Api.LabelApi

All URIs are relative to *https://{tenant}.api.webshipper.io/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**LabelsGet**](LabelApi.md#labelsget) | **GET** /labels | List all Labels
[**LabelsIdGet**](LabelApi.md#labelsidget) | **GET** /labels/{id} | Show a single Label

<a name="labelsget"></a>
# **LabelsGet**
> InlineResponse20049 LabelsGet (string filterId)

List all Labels

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class LabelsGetExample
    {
        public void main()
        {


            var apiInstance = new LabelApi();
            var filterId = filterId_example;  // string | Filter by id (optional) 

            try
            {
                // List all Labels
                InlineResponse20049 result = apiInstance.LabelsGet(filterId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LabelApi.LabelsGet: " + e.Message );
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

[**InlineResponse20049**](InlineResponse20049.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="labelsidget"></a>
# **LabelsIdGet**
> InlineResponse20048 LabelsIdGet (int? id)

Show a single Label

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class LabelsIdGetExample
    {
        public void main()
        {


            var apiInstance = new LabelApi();
            var id = 56;  // int? | 

            try
            {
                // Show a single Label
                InlineResponse20048 result = apiInstance.LabelsIdGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LabelApi.LabelsIdGet: " + e.Message );
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

[**InlineResponse20048**](InlineResponse20048.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

