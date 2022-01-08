# IO.Swagger.Api.EventModelApi

All URIs are relative to *https://{tenant}.api.webshipper.io/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**EventModelsGet**](EventModelApi.md#eventmodelsget) | **GET** /event_models | List all EventModels
[**EventModelsIdDelete**](EventModelApi.md#eventmodelsiddelete) | **DELETE** /event_models/{id} | Delete a EventModel
[**EventModelsIdGet**](EventModelApi.md#eventmodelsidget) | **GET** /event_models/{id} | Show a single EventModel
[**EventModelsIdPatch**](EventModelApi.md#eventmodelsidpatch) | **PATCH** /event_models/{id} | Update a EventModel
[**EventModelsPost**](EventModelApi.md#eventmodelspost) | **POST** /event_models | Create a EventModel

<a name="eventmodelsget"></a>
# **EventModelsGet**
> InlineResponse20041 EventModelsGet (string filterId)

List all EventModels

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class EventModelsGetExample
    {
        public void main()
        {


            var apiInstance = new EventModelApi();
            var filterId = filterId_example;  // string | Filter by id (optional) 

            try
            {
                // List all EventModels
                InlineResponse20041 result = apiInstance.EventModelsGet(filterId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EventModelApi.EventModelsGet: " + e.Message );
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

[**InlineResponse20041**](InlineResponse20041.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="eventmodelsiddelete"></a>
# **EventModelsIdDelete**
> InlineResponse20040 EventModelsIdDelete (int? id)

Delete a EventModel

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class EventModelsIdDeleteExample
    {
        public void main()
        {


            var apiInstance = new EventModelApi();
            var id = 56;  // int? | 

            try
            {
                // Delete a EventModel
                InlineResponse20040 result = apiInstance.EventModelsIdDelete(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EventModelApi.EventModelsIdDelete: " + e.Message );
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

[**InlineResponse20040**](InlineResponse20040.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="eventmodelsidget"></a>
# **EventModelsIdGet**
> InlineResponse20040 EventModelsIdGet (int? id)

Show a single EventModel

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class EventModelsIdGetExample
    {
        public void main()
        {


            var apiInstance = new EventModelApi();
            var id = 56;  // int? | 

            try
            {
                // Show a single EventModel
                InlineResponse20040 result = apiInstance.EventModelsIdGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EventModelApi.EventModelsIdGet: " + e.Message );
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

[**InlineResponse20040**](InlineResponse20040.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="eventmodelsidpatch"></a>
# **EventModelsIdPatch**
> InlineResponse20040 EventModelsIdPatch (EventModelsIdBody body, int? id)

Update a EventModel

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class EventModelsIdPatchExample
    {
        public void main()
        {


            var apiInstance = new EventModelApi();
            var body = new EventModelsIdBody(); // EventModelsIdBody | 
            var id = 56;  // int? | 

            try
            {
                // Update a EventModel
                InlineResponse20040 result = apiInstance.EventModelsIdPatch(body, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EventModelApi.EventModelsIdPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**EventModelsIdBody**](EventModelsIdBody.md)|  | 
 **id** | **int?**|  | 

### Return type

[**InlineResponse20040**](InlineResponse20040.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="eventmodelspost"></a>
# **EventModelsPost**
> InlineResponse20040 EventModelsPost (EventModelsBody body)

Create a EventModel

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class EventModelsPostExample
    {
        public void main()
        {


            var apiInstance = new EventModelApi();
            var body = new EventModelsBody(); // EventModelsBody | 

            try
            {
                // Create a EventModel
                InlineResponse20040 result = apiInstance.EventModelsPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EventModelApi.EventModelsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**EventModelsBody**](EventModelsBody.md)|  | 

### Return type

[**InlineResponse20040**](InlineResponse20040.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

