# IO.Swagger.Model.Pickups
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PickupInstruction** | **string** | Instruction to the carrier. | [optional] 
**PickupLocationCloseTime** | **string** | When the pickup location is closing. | [optional] 
**PickupTime** | **string** | The time you want the carrier to arrive at the pickup address. | [optional] 
**Reference** | **string** | The reference returned by the carrier. | [optional] 
**Status** | **int?** | Decides if the pickup is &lt;code&gt;requested&lt;/code&gt; or &lt;code&gt;cancelled&lt;/code&gt;. To cancel a pickup you must update the status to cancelled.  | [optional] 
**CreatedAt** | **string** | The time when the resource was created | [optional] 
**UpdatedAt** | **string** | The time when resource was last updated or when it was created if it was never updated | [optional] 
**ShippingAddress** | **string** | The address where the shipments must be picked up. | [optional] 
**Carrier** | **string** | The carrier that should pickup the shipments. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

