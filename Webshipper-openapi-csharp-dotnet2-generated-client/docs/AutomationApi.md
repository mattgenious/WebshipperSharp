# IO.Swagger.Api.AutomationApi

All URIs are relative to *https://{tenant}.api.webshipper.io/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AutomationsGet**](AutomationApi.md#automationsget) | **GET** /automations | List all Automations
[**AutomationsIdDelete**](AutomationApi.md#automationsiddelete) | **DELETE** /automations/{id} | Delete a Automation
[**AutomationsIdGet**](AutomationApi.md#automationsidget) | **GET** /automations/{id} | Show a single Automation
[**AutomationsIdPatch**](AutomationApi.md#automationsidpatch) | **PATCH** /automations/{id} | Update a Automation
[**AutomationsPost**](AutomationApi.md#automationspost) | **POST** /automations | Create a Automation

<a name="automationsget"></a>
# **AutomationsGet**
> InlineResponse20011 AutomationsGet (string filterId)

List all Automations

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AutomationsGetExample
    {
        public void main()
        {


            var apiInstance = new AutomationApi();
            var filterId = filterId_example;  // string | Filter by id (optional) 

            try
            {
                // List all Automations
                InlineResponse20011 result = apiInstance.AutomationsGet(filterId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AutomationApi.AutomationsGet: " + e.Message );
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

[**InlineResponse20011**](InlineResponse20011.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="automationsiddelete"></a>
# **AutomationsIdDelete**
> InlineResponse20010 AutomationsIdDelete (int? id)

Delete a Automation

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AutomationsIdDeleteExample
    {
        public void main()
        {


            var apiInstance = new AutomationApi();
            var id = 56;  // int? | 

            try
            {
                // Delete a Automation
                InlineResponse20010 result = apiInstance.AutomationsIdDelete(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AutomationApi.AutomationsIdDelete: " + e.Message );
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

[**InlineResponse20010**](InlineResponse20010.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="automationsidget"></a>
# **AutomationsIdGet**
> InlineResponse20010 AutomationsIdGet (int? id)

Show a single Automation

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AutomationsIdGetExample
    {
        public void main()
        {


            var apiInstance = new AutomationApi();
            var id = 56;  // int? | 

            try
            {
                // Show a single Automation
                InlineResponse20010 result = apiInstance.AutomationsIdGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AutomationApi.AutomationsIdGet: " + e.Message );
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

[**InlineResponse20010**](InlineResponse20010.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="automationsidpatch"></a>
# **AutomationsIdPatch**
> InlineResponse20010 AutomationsIdPatch (AutomationsIdBody body, int? id)

Update a Automation

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AutomationsIdPatchExample
    {
        public void main()
        {


            var apiInstance = new AutomationApi();
            var body = new AutomationsIdBody(); // AutomationsIdBody | 
            var id = 56;  // int? | 

            try
            {
                // Update a Automation
                InlineResponse20010 result = apiInstance.AutomationsIdPatch(body, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AutomationApi.AutomationsIdPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AutomationsIdBody**](AutomationsIdBody.md)|  | 
 **id** | **int?**|  | 

### Return type

[**InlineResponse20010**](InlineResponse20010.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="automationspost"></a>
# **AutomationsPost**
> InlineResponse20010 AutomationsPost (AutomationsBody body)

Create a Automation

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AutomationsPostExample
    {
        public void main()
        {


            var apiInstance = new AutomationApi();
            var body = new AutomationsBody(); // AutomationsBody | 

            try
            {
                // Create a Automation
                InlineResponse20010 result = apiInstance.AutomationsPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AutomationApi.AutomationsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AutomationsBody**](AutomationsBody.md)|  | 

### Return type

[**InlineResponse20010**](InlineResponse20010.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

