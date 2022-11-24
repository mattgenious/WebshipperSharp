# IO.Swagger.Api.AutomationsDryRunApi

All URIs are relative to *https://{tenant}.api.webshipper.io/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AutomationsDryRunsGet**](AutomationsDryRunApi.md#automationsdryrunsget) | **GET** /automations_dry_runs | List all Automations Dry Runs
[**AutomationsDryRunsIdDelete**](AutomationsDryRunApi.md#automationsdryrunsiddelete) | **DELETE** /automations_dry_runs/{id} | Delete a Automations Dry Run
[**AutomationsDryRunsIdGet**](AutomationsDryRunApi.md#automationsdryrunsidget) | **GET** /automations_dry_runs/{id} | Show a single Automations Dry Run
[**AutomationsDryRunsIdPatch**](AutomationsDryRunApi.md#automationsdryrunsidpatch) | **PATCH** /automations_dry_runs/{id} | Update a Automations Dry Run
[**AutomationsDryRunsPost**](AutomationsDryRunApi.md#automationsdryrunspost) | **POST** /automations_dry_runs | Create a Automations Dry Run

<a name="automationsdryrunsget"></a>
# **AutomationsDryRunsGet**
> InlineResponse20013 AutomationsDryRunsGet (string filterId)

List all Automations Dry Runs

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AutomationsDryRunsGetExample
    {
        public void main()
        {


            var apiInstance = new AutomationsDryRunApi();
            var filterId = filterId_example;  // string | Filter by id (optional) 

            try
            {
                // List all Automations Dry Runs
                InlineResponse20013 result = apiInstance.AutomationsDryRunsGet(filterId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AutomationsDryRunApi.AutomationsDryRunsGet: " + e.Message );
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

[**InlineResponse20013**](InlineResponse20013.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="automationsdryrunsiddelete"></a>
# **AutomationsDryRunsIdDelete**
> InlineResponse20012 AutomationsDryRunsIdDelete (int? id)

Delete a Automations Dry Run

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AutomationsDryRunsIdDeleteExample
    {
        public void main()
        {


            var apiInstance = new AutomationsDryRunApi();
            var id = 56;  // int? | 

            try
            {
                // Delete a Automations Dry Run
                InlineResponse20012 result = apiInstance.AutomationsDryRunsIdDelete(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AutomationsDryRunApi.AutomationsDryRunsIdDelete: " + e.Message );
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

[**InlineResponse20012**](InlineResponse20012.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="automationsdryrunsidget"></a>
# **AutomationsDryRunsIdGet**
> InlineResponse20012 AutomationsDryRunsIdGet (int? id)

Show a single Automations Dry Run

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AutomationsDryRunsIdGetExample
    {
        public void main()
        {


            var apiInstance = new AutomationsDryRunApi();
            var id = 56;  // int? | 

            try
            {
                // Show a single Automations Dry Run
                InlineResponse20012 result = apiInstance.AutomationsDryRunsIdGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AutomationsDryRunApi.AutomationsDryRunsIdGet: " + e.Message );
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

[**InlineResponse20012**](InlineResponse20012.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="automationsdryrunsidpatch"></a>
# **AutomationsDryRunsIdPatch**
> InlineResponse20012 AutomationsDryRunsIdPatch (AutomationsDryRunsIdBody body, int? id)

Update a Automations Dry Run

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AutomationsDryRunsIdPatchExample
    {
        public void main()
        {


            var apiInstance = new AutomationsDryRunApi();
            var body = new AutomationsDryRunsIdBody(); // AutomationsDryRunsIdBody | 
            var id = 56;  // int? | 

            try
            {
                // Update a Automations Dry Run
                InlineResponse20012 result = apiInstance.AutomationsDryRunsIdPatch(body, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AutomationsDryRunApi.AutomationsDryRunsIdPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AutomationsDryRunsIdBody**](AutomationsDryRunsIdBody.md)|  | 
 **id** | **int?**|  | 

### Return type

[**InlineResponse20012**](InlineResponse20012.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="automationsdryrunspost"></a>
# **AutomationsDryRunsPost**
> InlineResponse20012 AutomationsDryRunsPost (AutomationsDryRunsBody body)

Create a Automations Dry Run

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AutomationsDryRunsPostExample
    {
        public void main()
        {


            var apiInstance = new AutomationsDryRunApi();
            var body = new AutomationsDryRunsBody(); // AutomationsDryRunsBody | 

            try
            {
                // Create a Automations Dry Run
                InlineResponse20012 result = apiInstance.AutomationsDryRunsPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AutomationsDryRunApi.AutomationsDryRunsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AutomationsDryRunsBody**](AutomationsDryRunsBody.md)|  | 

### Return type

[**InlineResponse20012**](InlineResponse20012.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

