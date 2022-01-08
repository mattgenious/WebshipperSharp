# IO.Swagger.Model.RateQuotes
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Quotes** | [**List&lt;RateQuotesItems&gt;**](RateQuotesItems.md) | Array of quotes | [optional] 
**Success** | **string** | DEPRECATED. The request will return an error response if the quote failed. | [optional] 
**DeliveryAddress** | **Object** | Delivery address for the quote. Flattened resource of &#x27;Shipping Address&#x27; | [optional] 
**Price** | **int?** | The total price of the items | [optional] 
**Weight** | **int?** | Weight for the quote. | [optional] 
**WeightUnit** | **string** | The weight unit. Possible values: g, kg, lbs, oz. | [optional] 
**Height** | **int?** | Height for the quote. The unit must match the unit you are using for shipping rate configurations. | [optional] 
**Length** | **int?** | Length for the quote. The unit must match the unit you are using for shipping rate configurations. | [optional] 
**Width** | **int?** | Width for the quote. The unit must match the unit you are using for shipping rate configurations. | [optional] 
**DimensionsUnit** | **string** | Dimensions unit. Possible values: cm, m, in, ft | [optional] 
**SenderAddress** | **Object** | Delivery address for the quote. Flattened resource of &#x27;Shipping Address&#x27; | [optional] 
**Items** | [**List&lt;RateQuotesItems1&gt;**](RateQuotesItems1.md) | Array of items, each item should have fields &lt;code&gt;quantity&lt;/code&gt;, &lt;code&gt;sku&lt;/code&gt;, &lt;code&gt;description&lt;/code&gt; | [optional] 
**OrderChannelId** | **int?** | The id of the order channel for which to get shipping rates. | [optional] 
**IncludeHidden** | **bool?** | Also include shipping rates which are normally hidden during checkout. | [optional] 
**IsReturn** | **bool?** | Set to true to quote for return rates. If false standard rates are quoted. Default: false. | [optional] 
**AdditionalAttributes** | **string** | Possibility to add hash of additional attributes for filtering. | [optional] 
**FilterByCurrency** | **string** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

