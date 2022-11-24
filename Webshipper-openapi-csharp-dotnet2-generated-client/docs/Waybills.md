# IO.Swagger.Model.Waybills
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**WaybillName** | **string** | Name of the waybill type | [optional] 
**WaybillCode** | **string** | Code identifying the type of waybill | [optional] 
**Reference** | **string** | Unique reference returned from the carrier implementation when a waybill is opened. | [optional] 
**ConsolidationKey** | **string** |  | [optional] 
**BarcodeSerial** | **int?** | This will be assigned by the API if the waybill type has a barcode requirement. | [optional] 
**Status** | **int?** | Indicates whether the waybill is open or closed. When you want to close the waybill, you simply need to update the status of the way bill and set it to closed. | [optional] 
**ShipmentCount** | **string** | This is a read-only attribute which returns the total number of shipments. | [optional] 
**Currency** | **string** |  | [optional] 
**Copies** | **int?** |  | [optional] 
**CreatedAt** | **string** | The time when the resource was created | [optional] 
**UpdatedAt** | **string** | The time when resource was last updated or when it was created if it was never updated | [optional] 
**Documents** | **string** | Array of documents. This is available when the waybill is closed. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

