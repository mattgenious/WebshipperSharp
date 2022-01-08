# IO.Swagger.Model.DropPointLocators
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CarrierId** | **int?** | ID of the carrier that you want to quote. &lt;strong&gt;This is only mandatory if no shipping_rate_id is given&lt;/strong&gt;. | [optional] 
**ServiceCode** | **string** | Service code for the service that you want to quote. &lt;strong&gt;This is only mandatory if no shipping_rate_id is given.&lt;/strong&gt; | [optional] 
**ShippingRateId** | **string** | ID of the shipping rate that you want to quote. &lt;strong&gt;This is only mandatory if no carrier_id is given.&lt;/strong&gt;. | [optional] 
**DropPointId** | **string** |  | [optional] 
**DeliveryAddress** | **string** | Flattened shipping address object. &lt;code&gt;zip&lt;/code&gt; and &lt;code&gt;country_code&lt;/code&gt;  are required and &lt;code&gt;address_1&lt;/code&gt; is optional. | [optional] 
**DropPoints** | [**List&lt;DropPoints&gt;**](DropPoints.md) | Array of drop points near delivery_address. This will be populated in the response. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

