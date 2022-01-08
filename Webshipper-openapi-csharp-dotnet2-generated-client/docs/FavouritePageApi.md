# IO.Swagger.Api.FavouritePageApi

All URIs are relative to *https://{tenant}.api.webshipper.io/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**FavouritePagesGet**](FavouritePageApi.md#favouritepagesget) | **GET** /favourite_pages | List all Favourite Pages
[**FavouritePagesIdDelete**](FavouritePageApi.md#favouritepagesiddelete) | **DELETE** /favourite_pages/{id} | Delete a Favourite Page
[**FavouritePagesIdGet**](FavouritePageApi.md#favouritepagesidget) | **GET** /favourite_pages/{id} | Show a single Favourite Page
[**FavouritePagesIdPatch**](FavouritePageApi.md#favouritepagesidpatch) | **PATCH** /favourite_pages/{id} | Update a Favourite Page
[**FavouritePagesPost**](FavouritePageApi.md#favouritepagespost) | **POST** /favourite_pages | Create a Favourite Page

<a name="favouritepagesget"></a>
# **FavouritePagesGet**
> InlineResponse20043 FavouritePagesGet (string filterId, string filterUserId)

List all Favourite Pages

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class FavouritePagesGetExample
    {
        public void main()
        {


            var apiInstance = new FavouritePageApi();
            var filterId = filterId_example;  // string | Filter by id (optional) 
            var filterUserId = filterUserId_example;  // string | Filter by user_id (optional) 

            try
            {
                // List all Favourite Pages
                InlineResponse20043 result = apiInstance.FavouritePagesGet(filterId, filterUserId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FavouritePageApi.FavouritePagesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filterId** | **string**| Filter by id | [optional] 
 **filterUserId** | **string**| Filter by user_id | [optional] 

### Return type

[**InlineResponse20043**](InlineResponse20043.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="favouritepagesiddelete"></a>
# **FavouritePagesIdDelete**
> InlineResponse20042 FavouritePagesIdDelete (int? id)

Delete a Favourite Page

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class FavouritePagesIdDeleteExample
    {
        public void main()
        {


            var apiInstance = new FavouritePageApi();
            var id = 56;  // int? | 

            try
            {
                // Delete a Favourite Page
                InlineResponse20042 result = apiInstance.FavouritePagesIdDelete(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FavouritePageApi.FavouritePagesIdDelete: " + e.Message );
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

[**InlineResponse20042**](InlineResponse20042.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="favouritepagesidget"></a>
# **FavouritePagesIdGet**
> InlineResponse20042 FavouritePagesIdGet (int? id)

Show a single Favourite Page

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class FavouritePagesIdGetExample
    {
        public void main()
        {


            var apiInstance = new FavouritePageApi();
            var id = 56;  // int? | 

            try
            {
                // Show a single Favourite Page
                InlineResponse20042 result = apiInstance.FavouritePagesIdGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FavouritePageApi.FavouritePagesIdGet: " + e.Message );
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

[**InlineResponse20042**](InlineResponse20042.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="favouritepagesidpatch"></a>
# **FavouritePagesIdPatch**
> InlineResponse20042 FavouritePagesIdPatch (FavouritePagesIdBody body, int? id)

Update a Favourite Page

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class FavouritePagesIdPatchExample
    {
        public void main()
        {


            var apiInstance = new FavouritePageApi();
            var body = new FavouritePagesIdBody(); // FavouritePagesIdBody | 
            var id = 56;  // int? | 

            try
            {
                // Update a Favourite Page
                InlineResponse20042 result = apiInstance.FavouritePagesIdPatch(body, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FavouritePageApi.FavouritePagesIdPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**FavouritePagesIdBody**](FavouritePagesIdBody.md)|  | 
 **id** | **int?**|  | 

### Return type

[**InlineResponse20042**](InlineResponse20042.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="favouritepagespost"></a>
# **FavouritePagesPost**
> InlineResponse20042 FavouritePagesPost (FavouritePagesBody body)

Create a Favourite Page

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class FavouritePagesPostExample
    {
        public void main()
        {


            var apiInstance = new FavouritePageApi();
            var body = new FavouritePagesBody(); // FavouritePagesBody | 

            try
            {
                // Create a Favourite Page
                InlineResponse20042 result = apiInstance.FavouritePagesPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FavouritePageApi.FavouritePagesPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**FavouritePagesBody**](FavouritePagesBody.md)|  | 

### Return type

[**InlineResponse20042**](InlineResponse20042.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

