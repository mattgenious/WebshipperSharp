# IO.Swagger.Api.OtherApi

All URIs are relative to *https://{tenant}.api.webshipper.io/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**BrandsGet**](OtherApi.md#brandsget) | **GET** /brands | List all Others
[**BrandsIdDelete**](OtherApi.md#brandsiddelete) | **DELETE** /brands/{id} | Delete a Other
[**BrandsIdGet**](OtherApi.md#brandsidget) | **GET** /brands/{id} | Show a single Other
[**BrandsIdPatch**](OtherApi.md#brandsidpatch) | **PATCH** /brands/{id} | Update a Other
[**BrandsPost**](OtherApi.md#brandspost) | **POST** /brands | Create a Other
[**ReturnRefundMethodsGet**](OtherApi.md#returnrefundmethodsget) | **GET** /return_refund_methods | List all Others
[**ReturnRefundMethodsIdDelete**](OtherApi.md#returnrefundmethodsiddelete) | **DELETE** /return_refund_methods/{id} | Delete a Other
[**ReturnRefundMethodsIdGet**](OtherApi.md#returnrefundmethodsidget) | **GET** /return_refund_methods/{id} | Show a single Other
[**ReturnRefundMethodsIdPatch**](OtherApi.md#returnrefundmethodsidpatch) | **PATCH** /return_refund_methods/{id} | Update a Other
[**ReturnRefundMethodsPost**](OtherApi.md#returnrefundmethodspost) | **POST** /return_refund_methods | Create a Other

<a name="brandsget"></a>
# **BrandsGet**
> InlineResponse2003 BrandsGet ()

List all Others

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class BrandsGetExample
    {
        public void main()
        {


            var apiInstance = new OtherApi();

            try
            {
                // List all Others
                InlineResponse2003 result = apiInstance.BrandsGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OtherApi.BrandsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**InlineResponse2003**](InlineResponse2003.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="brandsiddelete"></a>
# **BrandsIdDelete**
> InlineResponse2002 BrandsIdDelete (int? id)

Delete a Other

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class BrandsIdDeleteExample
    {
        public void main()
        {


            var apiInstance = new OtherApi();
            var id = 56;  // int? | 

            try
            {
                // Delete a Other
                InlineResponse2002 result = apiInstance.BrandsIdDelete(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OtherApi.BrandsIdDelete: " + e.Message );
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

[**InlineResponse2002**](InlineResponse2002.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="brandsidget"></a>
# **BrandsIdGet**
> InlineResponse2002 BrandsIdGet (int? id)

Show a single Other

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class BrandsIdGetExample
    {
        public void main()
        {


            var apiInstance = new OtherApi();
            var id = 56;  // int? | 

            try
            {
                // Show a single Other
                InlineResponse2002 result = apiInstance.BrandsIdGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OtherApi.BrandsIdGet: " + e.Message );
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

[**InlineResponse2002**](InlineResponse2002.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="brandsidpatch"></a>
# **BrandsIdPatch**
> InlineResponse2002 BrandsIdPatch (BrandsIdBody body, int? id)

Update a Other

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class BrandsIdPatchExample
    {
        public void main()
        {


            var apiInstance = new OtherApi();
            var body = new BrandsIdBody(); // BrandsIdBody | 
            var id = 56;  // int? | 

            try
            {
                // Update a Other
                InlineResponse2002 result = apiInstance.BrandsIdPatch(body, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OtherApi.BrandsIdPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**BrandsIdBody**](BrandsIdBody.md)|  | 
 **id** | **int?**|  | 

### Return type

[**InlineResponse2002**](InlineResponse2002.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="brandspost"></a>
# **BrandsPost**
> InlineResponse2002 BrandsPost (BrandsBody body)

Create a Other

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class BrandsPostExample
    {
        public void main()
        {


            var apiInstance = new OtherApi();
            var body = new BrandsBody(); // BrandsBody | 

            try
            {
                // Create a Other
                InlineResponse2002 result = apiInstance.BrandsPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OtherApi.BrandsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**BrandsBody**](BrandsBody.md)|  | 

### Return type

[**InlineResponse2002**](InlineResponse2002.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="returnrefundmethodsget"></a>
# **ReturnRefundMethodsGet**
> InlineResponse2001 ReturnRefundMethodsGet (string filterId)

List all Others

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ReturnRefundMethodsGetExample
    {
        public void main()
        {


            var apiInstance = new OtherApi();
            var filterId = filterId_example;  // string | Filter by id (optional) 

            try
            {
                // List all Others
                InlineResponse2001 result = apiInstance.ReturnRefundMethodsGet(filterId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OtherApi.ReturnRefundMethodsGet: " + e.Message );
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

[**InlineResponse2001**](InlineResponse2001.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="returnrefundmethodsiddelete"></a>
# **ReturnRefundMethodsIdDelete**
> InlineResponse200 ReturnRefundMethodsIdDelete (int? id)

Delete a Other

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ReturnRefundMethodsIdDeleteExample
    {
        public void main()
        {


            var apiInstance = new OtherApi();
            var id = 56;  // int? | 

            try
            {
                // Delete a Other
                InlineResponse200 result = apiInstance.ReturnRefundMethodsIdDelete(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OtherApi.ReturnRefundMethodsIdDelete: " + e.Message );
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

[**InlineResponse200**](InlineResponse200.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="returnrefundmethodsidget"></a>
# **ReturnRefundMethodsIdGet**
> InlineResponse200 ReturnRefundMethodsIdGet (int? id)

Show a single Other

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ReturnRefundMethodsIdGetExample
    {
        public void main()
        {


            var apiInstance = new OtherApi();
            var id = 56;  // int? | 

            try
            {
                // Show a single Other
                InlineResponse200 result = apiInstance.ReturnRefundMethodsIdGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OtherApi.ReturnRefundMethodsIdGet: " + e.Message );
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

[**InlineResponse200**](InlineResponse200.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="returnrefundmethodsidpatch"></a>
# **ReturnRefundMethodsIdPatch**
> InlineResponse200 ReturnRefundMethodsIdPatch (ReturnRefundMethodsIdBody body, int? id)

Update a Other

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ReturnRefundMethodsIdPatchExample
    {
        public void main()
        {


            var apiInstance = new OtherApi();
            var body = new ReturnRefundMethodsIdBody(); // ReturnRefundMethodsIdBody | 
            var id = 56;  // int? | 

            try
            {
                // Update a Other
                InlineResponse200 result = apiInstance.ReturnRefundMethodsIdPatch(body, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OtherApi.ReturnRefundMethodsIdPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ReturnRefundMethodsIdBody**](ReturnRefundMethodsIdBody.md)|  | 
 **id** | **int?**|  | 

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="returnrefundmethodspost"></a>
# **ReturnRefundMethodsPost**
> InlineResponse200 ReturnRefundMethodsPost (ReturnRefundMethodsBody body)

Create a Other

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ReturnRefundMethodsPostExample
    {
        public void main()
        {


            var apiInstance = new OtherApi();
            var body = new ReturnRefundMethodsBody(); // ReturnRefundMethodsBody | 

            try
            {
                // Create a Other
                InlineResponse200 result = apiInstance.ReturnRefundMethodsPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OtherApi.ReturnRefundMethodsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ReturnRefundMethodsBody**](ReturnRefundMethodsBody.md)|  | 

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

