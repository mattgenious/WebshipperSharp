# IO.Swagger.Api.ShippingAddressApi

All URIs are relative to *https://{tenant}.api.webshipper.io/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ShippingAddressesGet**](ShippingAddressApi.md#shippingaddressesget) | **GET** /shipping_addresses | List all Shipping Addresss
[**ShippingAddressesIdDelete**](ShippingAddressApi.md#shippingaddressesiddelete) | **DELETE** /shipping_addresses/{id} | Delete a Shipping Address
[**ShippingAddressesIdGet**](ShippingAddressApi.md#shippingaddressesidget) | **GET** /shipping_addresses/{id} | Show a single Shipping Address
[**ShippingAddressesIdPatch**](ShippingAddressApi.md#shippingaddressesidpatch) | **PATCH** /shipping_addresses/{id} | Update a Shipping Address
[**ShippingAddressesPost**](ShippingAddressApi.md#shippingaddressespost) | **POST** /shipping_addresses | Create a Shipping Address

<a name="shippingaddressesget"></a>
# **ShippingAddressesGet**
> InlineResponse200100 ShippingAddressesGet (string filterId, string filterAttContact, string filterCompanyName, string filterAddress1, string filterAddress2, string filterCountryCode, string filterState, string filterZip, string filterAddressType, string filterSearch)

List all Shipping Addresss

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ShippingAddressesGetExample
    {
        public void main()
        {


            var apiInstance = new ShippingAddressApi();
            var filterId = filterId_example;  // string | Filter by id (optional) 
            var filterAttContact = filterAttContact_example;  // string | Filter by att_contact (optional) 
            var filterCompanyName = filterCompanyName_example;  // string | Filter by company_name (optional) 
            var filterAddress1 = filterAddress1_example;  // string | Filter by address_1 (optional) 
            var filterAddress2 = filterAddress2_example;  // string | Filter by address_2 (optional) 
            var filterCountryCode = filterCountryCode_example;  // string | Filter by country_code (optional) 
            var filterState = filterState_example;  // string | Filter by state (optional) 
            var filterZip = filterZip_example;  // string | Filter by zip (optional) 
            var filterAddressType = filterAddressType_example;  // string | Filter by address_type (optional) 
            var filterSearch = filterSearch_example;  // string | Filter by search (optional) 

            try
            {
                // List all Shipping Addresss
                InlineResponse200100 result = apiInstance.ShippingAddressesGet(filterId, filterAttContact, filterCompanyName, filterAddress1, filterAddress2, filterCountryCode, filterState, filterZip, filterAddressType, filterSearch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ShippingAddressApi.ShippingAddressesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filterId** | **string**| Filter by id | [optional] 
 **filterAttContact** | **string**| Filter by att_contact | [optional] 
 **filterCompanyName** | **string**| Filter by company_name | [optional] 
 **filterAddress1** | **string**| Filter by address_1 | [optional] 
 **filterAddress2** | **string**| Filter by address_2 | [optional] 
 **filterCountryCode** | **string**| Filter by country_code | [optional] 
 **filterState** | **string**| Filter by state | [optional] 
 **filterZip** | **string**| Filter by zip | [optional] 
 **filterAddressType** | **string**| Filter by address_type | [optional] 
 **filterSearch** | **string**| Filter by search | [optional] 

### Return type

[**InlineResponse200100**](InlineResponse200100.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="shippingaddressesiddelete"></a>
# **ShippingAddressesIdDelete**
> InlineResponse20099 ShippingAddressesIdDelete (int? id)

Delete a Shipping Address

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ShippingAddressesIdDeleteExample
    {
        public void main()
        {


            var apiInstance = new ShippingAddressApi();
            var id = 56;  // int? | 

            try
            {
                // Delete a Shipping Address
                InlineResponse20099 result = apiInstance.ShippingAddressesIdDelete(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ShippingAddressApi.ShippingAddressesIdDelete: " + e.Message );
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

[**InlineResponse20099**](InlineResponse20099.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="shippingaddressesidget"></a>
# **ShippingAddressesIdGet**
> InlineResponse20099 ShippingAddressesIdGet (int? id)

Show a single Shipping Address

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ShippingAddressesIdGetExample
    {
        public void main()
        {


            var apiInstance = new ShippingAddressApi();
            var id = 56;  // int? | 

            try
            {
                // Show a single Shipping Address
                InlineResponse20099 result = apiInstance.ShippingAddressesIdGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ShippingAddressApi.ShippingAddressesIdGet: " + e.Message );
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

[**InlineResponse20099**](InlineResponse20099.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="shippingaddressesidpatch"></a>
# **ShippingAddressesIdPatch**
> InlineResponse20099 ShippingAddressesIdPatch (ShippingAddressesIdBody body, int? id)

Update a Shipping Address

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ShippingAddressesIdPatchExample
    {
        public void main()
        {


            var apiInstance = new ShippingAddressApi();
            var body = new ShippingAddressesIdBody(); // ShippingAddressesIdBody | 
            var id = 56;  // int? | 

            try
            {
                // Update a Shipping Address
                InlineResponse20099 result = apiInstance.ShippingAddressesIdPatch(body, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ShippingAddressApi.ShippingAddressesIdPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ShippingAddressesIdBody**](ShippingAddressesIdBody.md)|  | 
 **id** | **int?**|  | 

### Return type

[**InlineResponse20099**](InlineResponse20099.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="shippingaddressespost"></a>
# **ShippingAddressesPost**
> InlineResponse20099 ShippingAddressesPost (ShippingAddressesBody body)

Create a Shipping Address

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ShippingAddressesPostExample
    {
        public void main()
        {


            var apiInstance = new ShippingAddressApi();
            var body = new ShippingAddressesBody(); // ShippingAddressesBody | 

            try
            {
                // Create a Shipping Address
                InlineResponse20099 result = apiInstance.ShippingAddressesPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ShippingAddressApi.ShippingAddressesPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ShippingAddressesBody**](ShippingAddressesBody.md)|  | 

### Return type

[**InlineResponse20099**](InlineResponse20099.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

