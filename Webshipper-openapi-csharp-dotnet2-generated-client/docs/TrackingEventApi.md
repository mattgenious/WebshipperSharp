# IO.Swagger.Api.TrackingEventApi

All URIs are relative to *https://{tenant}.api.webshipper.io/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**TrackingEventsGet**](TrackingEventApi.md#trackingeventsget) | **GET** /tracking_events | List all Tracking Events
[**TrackingEventsIdGet**](TrackingEventApi.md#trackingeventsidget) | **GET** /tracking_events/{id} | Show a single Tracking Event

<a name="trackingeventsget"></a>
# **TrackingEventsGet**
> InlineResponse200117 TrackingEventsGet (string filterId, string filterCreatedAt)

List all Tracking Events

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TrackingEventsGetExample
    {
        public void main()
        {


            var apiInstance = new TrackingEventApi();
            var filterId = filterId_example;  // string | Filter by id (optional) 
            var filterCreatedAt = filterCreatedAt_example;  // string | Filter by created_at (optional) 

            try
            {
                // List all Tracking Events
                InlineResponse200117 result = apiInstance.TrackingEventsGet(filterId, filterCreatedAt);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TrackingEventApi.TrackingEventsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filterId** | **string**| Filter by id | [optional] 
 **filterCreatedAt** | **string**| Filter by created_at | [optional] 

### Return type

[**InlineResponse200117**](InlineResponse200117.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="trackingeventsidget"></a>
# **TrackingEventsIdGet**
> InlineResponse200116 TrackingEventsIdGet (int? id)

Show a single Tracking Event

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TrackingEventsIdGetExample
    {
        public void main()
        {


            var apiInstance = new TrackingEventApi();
            var id = 56;  // int? | 

            try
            {
                // Show a single Tracking Event
                InlineResponse200116 result = apiInstance.TrackingEventsIdGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TrackingEventApi.TrackingEventsIdGet: " + e.Message );
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

[**InlineResponse200116**](InlineResponse200116.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

