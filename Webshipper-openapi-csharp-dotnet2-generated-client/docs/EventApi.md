# IO.Swagger.Api.EventApi

All URIs are relative to *https://{tenant}.api.webshipper.io/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**EventsGet**](EventApi.md#eventsget) | **GET** /events | List all Events
[**EventsIdDelete**](EventApi.md#eventsiddelete) | **DELETE** /events/{id} | Delete a Event
[**EventsIdGet**](EventApi.md#eventsidget) | **GET** /events/{id} | Show a single Event
[**EventsIdPatch**](EventApi.md#eventsidpatch) | **PATCH** /events/{id} | Update a Event
[**EventsPost**](EventApi.md#eventspost) | **POST** /events | Create a Event

<a name="eventsget"></a>
# **EventsGet**
> InlineResponse20039 EventsGet (string filterId)

List all Events

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class EventsGetExample
    {
        public void main()
        {


            var apiInstance = new EventApi();
            var filterId = filterId_example;  // string | Filter by id (optional) 

            try
            {
                // List all Events
                InlineResponse20039 result = apiInstance.EventsGet(filterId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EventApi.EventsGet: " + e.Message );
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

[**InlineResponse20039**](InlineResponse20039.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="eventsiddelete"></a>
# **EventsIdDelete**
> InlineResponse20038 EventsIdDelete (int? id)

Delete a Event

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class EventsIdDeleteExample
    {
        public void main()
        {


            var apiInstance = new EventApi();
            var id = 56;  // int? | 

            try
            {
                // Delete a Event
                InlineResponse20038 result = apiInstance.EventsIdDelete(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EventApi.EventsIdDelete: " + e.Message );
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

[**InlineResponse20038**](InlineResponse20038.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="eventsidget"></a>
# **EventsIdGet**
> InlineResponse20038 EventsIdGet (int? id)

Show a single Event

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class EventsIdGetExample
    {
        public void main()
        {


            var apiInstance = new EventApi();
            var id = 56;  // int? | 

            try
            {
                // Show a single Event
                InlineResponse20038 result = apiInstance.EventsIdGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EventApi.EventsIdGet: " + e.Message );
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

[**InlineResponse20038**](InlineResponse20038.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="eventsidpatch"></a>
# **EventsIdPatch**
> InlineResponse20038 EventsIdPatch (EventsIdBody body, int? id)

Update a Event

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class EventsIdPatchExample
    {
        public void main()
        {


            var apiInstance = new EventApi();
            var body = new EventsIdBody(); // EventsIdBody | 
            var id = 56;  // int? | 

            try
            {
                // Update a Event
                InlineResponse20038 result = apiInstance.EventsIdPatch(body, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EventApi.EventsIdPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**EventsIdBody**](EventsIdBody.md)|  | 
 **id** | **int?**|  | 

### Return type

[**InlineResponse20038**](InlineResponse20038.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="eventspost"></a>
# **EventsPost**
> InlineResponse20038 EventsPost (EventsBody body)

Create a Event

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class EventsPostExample
    {
        public void main()
        {


            var apiInstance = new EventApi();
            var body = new EventsBody(); // EventsBody | 

            try
            {
                // Create a Event
                InlineResponse20038 result = apiInstance.EventsPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EventApi.EventsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**EventsBody**](EventsBody.md)|  | 

### Return type

[**InlineResponse20038**](InlineResponse20038.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

