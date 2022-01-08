# IO.Swagger.Model.Orders
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**OrderChannelId** | **int?** | DEPRECATED Assign a relation instead | [optional] 
**Status** | **string** | Enum status of the order. Possible values: pending, dispatched, partly_dispatched, cancelled, error, missing_rate, on_hold | [optional] 
**ExtRef** | **string** | External ( hidden ) reference for the order. Used by system to update the order in e.g. order channels. Must be unique in scope of order channels. | [optional] 
**VisibleRef** | **string** | Visible reference - the friendly/visible external order number | [optional] 
**DropPoint** | [**DropPoints**](DropPoints.md) |  | [optional] 
**OriginalShipping** | **Object** | Flattened resource describing the original shipping option from the order channel. This will be used for matching in cases where shipping was not quoted from Webshipper. | [optional] 
**OrderLines** | [**List&lt;OrderLines&gt;**](OrderLines.md) | Flattened resource of type OrderLine | [optional] 
**DeliveryAddress** | [**ShippingAddresses**](ShippingAddresses.md) |  | [optional] 
**SenderAddress** | [**ShippingAddresses**](ShippingAddresses.md) |  | [optional] 
**BillingAddress** | [**ShippingAddresses**](ShippingAddresses.md) |  | [optional] 
**SoldFromAddress** | [**ShippingAddresses**](ShippingAddresses.md) |  | [optional] 
**Currency** | **string** | Currency code of the order | [optional] 
**InternalComment** | **string** | Internal order comment. | [optional] 
**ExternalComment** | **string** | External order comment. Will typically be the order comment from e-commerce checkout. | [optional] 
**ErrorMessage** | **Object** | Any error message that resulted from the latest attempt at making a shipment from the order. | [optional] 
**Slip** | **string** | The order slip in PDF format using base64 encoding. This will only be included if the parameter fields[orders] includes slip. | [optional] 
**Base64** | **string** |  | [optional] 
**UpdatedAt** | **string** | The time when resource was last updated or when it was created if it was never updated | [optional] 
**CreatedAt** | **string** | The time when the resource was created | [optional] 
**LockState** | **string** | When an order is locked, it cannot be modified or sent until it is unlocked. Possible values: &lt;code&gt;locked&lt;/code&gt; or &lt;code&gt;unlocked&lt;/code&gt;. | [optional] 
**Source** | **string** | A description of how the order was created in Webshipper. Possible values: &#x27;api&#x27;, &#x27;manual&#x27; or &#x27;csv&#x27; | [optional] 
**Tags** | **List&lt;string&gt;** | Array of strings used to tag an order | [optional] 
**ErrorClass** | **string** | A string like &#x27;address&#x27; or &#x27;carrier_downtime&#x27; describe which type of error caused the order to fail | [optional] 
**SlipPrinted** | **bool?** |  | [optional] 
**LabelPrinted** | **bool?** |  | [optional] 
**CreateShipmentAutomatically** | **string** |  | [optional] 
**LatestStatusEvent** | **string** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

